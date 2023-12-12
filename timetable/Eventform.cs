using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cmp;

namespace timetable
{
    public partial class Eventform : Form
    {
        //tạo 1 chuỗi kết nối 
        String connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";

        public Eventform()
        {
            InitializeComponent();
        }

        private void Eventform_Load(object sender, EventArgs e)
        {
            // Lấy ngày từ các biến static
            string? dayString = UserControlDays.static_day;

            // Chuyển đổi giá trị string sang int sử dụng int.TryParse
            if (int.TryParse(dayString, out int day))
            {
                // Lấy các giá trị khác
                int month = Form1.static_month;
                int year = Form1.static_year;

                // Tạo đối tượng DateTime từ các thông tin trên
                DateTime eventDate = new DateTime(year, month, day);

                // Format ngày theo định dạng yêu cầu
                string formattedDate = $"{eventDate.ToString("dddd, d")}{GetDayText(day)} {eventDate.ToString("MMMM, yyyy")}";

                // Hiển thị ngày đã được định dạng trên TextBox
                txtDate.Text = formattedDate;

                // Load trạng thái của event đã hoàn thành từ database
                LoadCompletionStatus(eventDate);

                // Load và hiển thị chi tiết sự kiện nếu có
                LoadAndDisplayEventDetails(eventDate);  
            }
        }

        //Load và hiển thị lại sự kiện đã save
        private void LoadAndDisplayEventDetails(DateTime eventDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT * FROM tbl_timetable WHERE date = @date";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", eventDate);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Hiển thị chi tiết sự kiện từ database trên form
                        txtEvent.Text = reader["event"].ToString();
                        checkCompleted.Checked = Convert.ToBoolean(reader["IsCompleted"]);

                        // Update label status
                        UpdateStatusLabel(checkCompleted.Checked);
                    }
                }
            }
        }

        // Load trạng thái của event đã hoàn thành từ database
        private void LoadCompletionStatus(DateTime eventDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Truy vấn SQL để chọn sự kiện đã hoàn thành 
                string sql = "SELECT IsCompleted FROM tbl_timetable WHERE date = @date";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", eventDate);

                try
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        bool isCompleted = Convert.ToBoolean(result);
                        checkCompleted.Checked = isCompleted;

                        // Cập nhật trạng thái cho label của checkbox
                        UpdateStatusLabel(isCompleted);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading completion status: {ex.Message}");
                }
            }
        }

        //Cập nhật trạng thái cho label của checkbox
        private void UpdateStatusLabel(bool isCompleted)
        {
            // Hiển thị màu của checkbox khi được tick
            if (isCompleted)
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Completed";
            }
            else
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Not Completed";
            }
        }

        // Hàm chuyển đổi số ngày thành chữ (ví dụ, "1" thành "1st")
        private string GetDayText(int day)
        {
            if (day >= 11 && day <= 13)
            {
                return "th";
            }

            switch (day % 10)
            {
                case 1:
                    return "st";
                case 2:
                    return "nd";
                case 3:
                    return "rd";
                default:
                    return "th";
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            DateTime eventDate;

            // Lấy ngày từ các biến static
            string? dayString = UserControlDays.static_day;

            // Chuyển đổi giá trị string sang int sử dụng int.TryParse
            if (int.TryParse(dayString, out int day))
            {
                // Lấy các giá trị khác
                int month = Form1.static_month;
                int year = Form1.static_year;

                // Tạo đối tượng DateTime từ các thông tin trên
                eventDate = new DateTime(year, month, day);
            }
            else
            {
                // Xử lý trường hợp không chuyển đổi được giá trị string sang int
                MessageBox.Show("Invalid day value. Please check the input.");
                return; // Exit the method if the day value is invalid
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                //Truy vấn SQL để chèn event và checkCompleted vào database
                // Trong phương thức btnsave_Click
                string sql = "INSERT INTO tbl_timetable(id, date, event, IsCompleted) VALUES (@id, @date, @event, @isCompleted)" +
                             "ON DUPLICATE KEY UPDATE event = @event, IsCompleted = @isCompleted";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", GetEventId(eventDate));
                cmd.Parameters.AddWithValue("@date", eventDate);
                cmd.Parameters.AddWithValue("@event", txtEvent.Text);
                cmd.Parameters.AddWithValue("@isCompleted", checkCompleted.Checked);

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved!");

                    // Cập nhập trạng thái
                    UpdateStatusLabel(checkCompleted.Checked);

                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        //Lấy id cho sự kiện được chọn 
        private int GetEventId(DateTime eventDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Tạo lệnh SQL để chọn bản ghi
                string getIdSql = "SELECT id FROM tbl_timetable WHERE date = @date";
                MySqlCommand getIdCmd = new MySqlCommand(getIdSql, conn);
                getIdCmd.Parameters.AddWithValue("@date", eventDate);

                object result = getIdCmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // Nếu không tìm thấy bản ghi, thì chèn một bản ghi mới và trả về ID của nó
                    string insertSql = "INSERT INTO tbl_timetable(date, event, IsCompleted) VALUES (@date, @event, @isCompleted)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@date", eventDate);
                    insertCmd.Parameters.AddWithValue("@event", "");
                    insertCmd.Parameters.AddWithValue("@isCompleted", false);

                    insertCmd.ExecuteNonQuery();

                    // Lấy ID của bản ghi mới chèn
                    string newIdSql = "SELECT id FROM tbl_timetable WHERE date = @date";
                    MySqlCommand newIdCmd = new MySqlCommand(newIdSql, conn);
                    newIdCmd.Parameters.AddWithValue("@date", eventDate);

                    object newIdResult = newIdCmd.ExecuteScalar();

                    if (newIdResult != null && newIdResult != DBNull.Value)
                    {
                        return Convert.ToInt32(newIdResult);
                    }
                }

                return -1;
            }
        }


        //Hàm kiểm tra hiển thị trạng thái hoàn thành của event 
        private void checkCompleted_CheckedChanged(object sender, EventArgs e)
        {
            bool isCompleted = checkCompleted.Checked;

            // Hiển thị màu cho checkbox khi được tick 
            if (isCompleted)
            { 
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Completed";
            }
            else
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Not Completed";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Tìm kiếm form cha và đóng nó
            Form parentForm = this.FindForm()!; // Sử dụng toán tử bỏ qua null

            if (parentForm != null)
            {
                // Đóng form hiện tại
                parentForm.Hide();
            }
            else
            {
                // Xử lý trường hợp UserControlDays không được chứa trong một form
            }
        }

        private void deleteEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            // Tạo một thể hiện của DeleteEventform để xóa sự kiện
            DeleteEventform deleteEventForm = new DeleteEventform();
            // Hiển thị DeleteEventform dưới dạng hộp thoại và chờ đến khi nó đóng
            deleteEventForm.ShowDialog();
        }
    }
}

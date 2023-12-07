using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace timetable
{
    public partial class Addeventform : Form
    {
        String connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";

        //Form1 cha, dùng để làm mới hiển thị sau khi thêm sự kiện
        private Form1 parentForm;
        
        //Constructor, nhận Form1 làm tham số
        public Addeventform(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        // Sự kiện khi form được tải
        private void Addeventform_Load(object sender, EventArgs e)
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
                txtaddDate.Text = formattedDate;

            }
        }
        // Phương thức để lấy đuôi cho số ngày
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

        // Sự kiện khi nút "Back" được nhấn
        private void btnaddback_Click_1(object sender, EventArgs e)
        {
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

        // Sự kiện khi nút "Save" được nhấn
        private void btnaddsave_Click(object sender, EventArgs e)
        {
            string dateString = txtaddDate.Text;

            // Điều kiện để nhập vào ngày, tháng, năm
            if (DateTime.TryParseExact(dateString, "dd-MMMM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime eventDate))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    //Kiểm tra xem có bản ghi nào đã được tạo ở ngày được chọn không
                    int existingEventId = GetEventId(eventDate);

                    //Chuỗi SQL và đối tượng MySqlCommand để thực hiện truy vấn SQL
                    string sql = "";
                    MySqlCommand cmd = new MySqlCommand();

                    if (existingEventId != -1)
                    {
                        // Cập nhập bản ghi của event trước 
                        sql = "UPDATE tbl_timetable SET event = @event, IsCompleted = @isCompleted WHERE id = @eventId";
                        cmd.Parameters.AddWithValue("@eventId", existingEventId);
                    }
                    else
                    {
                        // Tạo 1 bản ghi mới 
                        sql = "INSERT INTO tbl_timetable(date, event, IsCompleted) VALUES (@date, @event, @isCompleted)";
                        cmd.Parameters.AddWithValue("@date", eventDate);
                    }

                    cmd.Connection = conn;
                    cmd.CommandText = sql;

                    // Các tham số chung cho cả cập nhật và tạo mới 
                    cmd.Parameters.AddWithValue("@event", txtaddEvent.Text);
                    cmd.Parameters.AddWithValue("@isCompleted", false);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Saved!");

                        // Làm mới hiển thị trong Form1
                        RefreshForm1();

                        // Đóng form hiện tại
                        Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter a valid date in the format 'dd-MMMM-yyyy'.");
            }
        }

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

        private void RefreshForm1()
        {
            parentForm.RefreshDisplay();
        }
    }
}

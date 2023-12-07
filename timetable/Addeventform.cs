using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetable
{
    public partial class Addeventform : Form
    {
        String connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";

        public Addeventform()
        {
            InitializeComponent();
        }

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

        private void btnaddsave_Click(object sender, EventArgs e)
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

                // Check if an event with the same date already exists
                int eventId = GetEventId(eventDate);

                // Truy vấn SQL để chèn event và checkCompleted vào database
                string sql = "INSERT INTO tbl_timetable(id, date, event, IsCompleted) VALUES (@id, @date, @event, @isCompleted)" +
                             "ON DUPLICATE KEY UPDATE event = @event, IsCompleted = @isCompleted";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", eventId);
                cmd.Parameters.AddWithValue("@date", eventDate);
                cmd.Parameters.AddWithValue("@event", txtaddEvent.Text);
                cmd.Parameters.AddWithValue("@isCompleted", false); // Assuming the event is not completed initially

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved!");

                    // Check if the event date is in the future
                    if (eventDate > DateTime.UtcNow.Date)
                    {
                        // If in the future, show in upcoming events
                    /*    Form1.Instance.ViewUpcomingEvents();
                    }
                    else
                    {
                        // If not in the future, show in overdue events
                        Form1.Instance.ViewOverdueEvents();*/
                    }

                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
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
                    // Nếu không tìm thấy bản ghi, thì trả về -1
                    return -1;
                }
            }
        }
    }
}

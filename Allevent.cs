using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class Allevent : Form
    {
        // Define the connection string here
        private readonly string connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";

        public Allevent()
        {
            InitializeComponent();
        }

        private void Allevent_Load(object sender, EventArgs e)
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
                string formattedDate = $"{eventDate:dddd, d}{GetDaySuffix(day)} {eventDate:MMMM, yyyy}";

                // Hiển thị ngày đã được định dạng trên TextBox
                lbdays.Text = formattedDate;

                // Hiển thị tất cả sự kiện trong ngày
                displayallevent();
            }
        }

        private string GetDaySuffix(int day)
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

        private void displayallevent()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Tạo đối tượng DateTime từ các biến static
                string? dayString = UserControlDays.static_day;

                if (!string.IsNullOrEmpty(dayString) && int.TryParse(dayString, out int day))
                {
                    int month = Form1.static_month;
                    int year = Form1.static_year;

                    DateTime eventDate = new DateTime(year, month, day);

                    String sql = "SELECT * FROM tbl_timetable WHERE date = @date";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", eventDate);

                    // Flag to check if any events exist
                    bool eventsExist = false;

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if there are any events
                        if (reader.HasRows)
                        {
                            eventsExist = true;

                            // Clear existing text in displayallev
                            displayallev.Text = "";

                            int eventCounter = 1;

                            while (reader.Read())
                            {
                                // Assuming you have a column named "event" in your table
                                string? eventName = reader["event"].ToString();

                                // Append each event to the displayallev TextBox with a numbered format
                                displayallev.Text += $"{eventCounter}. {eventName}" + Environment.NewLine;

                                // Increment the counter for the next event
                                eventCounter++;
                            }
                        }
                    }
                }
            }
        }

    private void btnback_Click(object sender, EventArgs e)
        {
            // Tìm kiếm form cha và đóng nó
            Form? parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Đóng form hiện tại
                parentForm.Hide();
            }
        }
    }
}

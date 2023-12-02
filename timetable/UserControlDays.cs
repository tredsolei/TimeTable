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

namespace timetable
{
    public partial class UserControlDays : UserControl
    {
        String connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";
        public static string? static_day;

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void lbevent_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu là một sự kiện chuột
            if (e is MouseEventArgs mouseEventArgs)
            {
                // Kiểm tra nếu là một nhấn chuột trái
                if (mouseEventArgs.Button == MouseButtons.Left)
                {
                    // Xử lý sự kiện nhấn chuột trái
                    static_day = lbdays.Text;
                    timer1.Start();
                    Eventform eventform = new Eventform();
                    eventform.Show();
                }
                // Kiểm tra nếu là một nhấn chuột phải
                else if (mouseEventArgs.Button == MouseButtons.Right)
                {
                    // Xử lý sự kiện nhấn chuột phải
                    static_day = lbdays.Text;
                    Allevent allevent = new Allevent();
                    allevent.Show();
                }
            }
        }

        // Hiển thị Event
        public void displayEvent()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Tạo đối tượng DateTime từ các biến static
                string dayString = lbdays.Text;

                if (int.TryParse(dayString, out int day))
                {
                    int month = Form1.static_month;
                    int year = Form1.static_year;

                    DateTime eventDate = new DateTime(year, month, day);

                    String sql = "SELECT * FROM tbl_timetable WHERE date = @date";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@date", eventDate);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbevent.Text = reader["event"].ToString();
                        }
                    }
                }
                else
                {
                    // Xử lý trường hợp không chuyển đổi được giá trị string sang int
                    MessageBox.Show("Invalid day value. Please check the input.");
                }
            }
        }

        // Phương thức công khai để yêu cầu hiển thị sự kiện
        public void RequestDisplayEvent()
        {
            // Gọi phương thức hiển thị sự kiện
            displayEvent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }
    }
}

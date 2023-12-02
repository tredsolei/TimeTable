using System;
using System.Windows.Forms;

namespace timetable
{
    public partial class Allevent : Form
    {
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
            }
            else
            {
                // Xử lý trường hợp không chuyển đổi được giá trị string sang int
                MessageBox.Show("Invalid day value. Please check the input.");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Tìm kiếm form cha và đóng nó
            Form parentForm = this.FindForm();

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
    }
}

using MySqlX.XDevAPI.Relational;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace timetable
{
    public partial class Allevent : Form
    {
        private string selectedDay;
        private int selectedMonth;

        public Allevent()
        {
            InitializeComponent();

            // Assign a default value if needed
            selectedDay = "DefaultDay";
        }
        // Thêm phương thức để thiết lập ngày và tháng từ UserControlDays


        private void Allevent_Load(object sender, EventArgs e)
        {
            // Call the SetDateAndMonth method to set the initial date and month
            SetDateAndMonth("DefaultDay", 1);
        }

        private void SetDateAndMonth(string day, int month)
        {
            selectedDay = day;
            selectedMonth = month;
            // Gọi phương thức hiển thị ngày và tháng
            displaylabel();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form Allevent
            Form1 defaultform = new Form1();

            // Hiển thị form Allevent
            defaultform.Show();

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

        private void displaylabel()
        {
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;

            if (int.TryParse(selectedDay, out int day) && selectedMonth >= 1 && selectedMonth <= 12)
            {
                string dateString = $"{selectedMonth:D2}/{day:D2}";

                if (DateTime.TryParseExact(dateString, "MM/dd", cultureInfo, DateTimeStyles.None, out DateTime selectedDate))
                {
                    // Use string interpolation to format the date
                    labelday.Text = $"{selectedDate:dddd, dd}{GetDaySuffix(day)} {selectedDate:MMMM, yyyy}";
                }
                else
                {
                    // Handle the case where parsing fails
                    labelday.Text = "Invalid Date";
                }
            }
            else
            {
                // Handle the case where parsing of day or month fails
                labelday.Text = "Invalid Date";
            }
        }

    }
}

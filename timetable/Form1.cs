using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace timetable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int day, month, year;

        public static int static_month, static_year;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gọi hàm hiển thị ngày khi form được tải
            displayDays();
        }

        private void displayDays()
        {
            // Lấy ngày và giờ hiện tại theo múi giờ UTC
            DateTime now = DateTime.UtcNow;
            month = now.Month;
            year = now.Year;
            day = now.Day;

            // Lấy tên của tháng hiện tại
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            // Hiển thị tháng và năm hiện tại trong label
            lbmonth.Text = monthname + " " + year;

            // Hiển thị thứ ngày tháng năm hiện tại với đuôi
            lbtoday.Text = $"Today: {now.ToString("dddd, d")}{GetDaySuffix(now.Day)} {now.ToString("MMMM, yyyy", CultureInfo.InvariantCulture)}";
            static_month = month;
            static_year = year;

            // Tính toán ngày đầu tháng và số ngày trong tháng
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            // Tính toán thứ của ngày đầu tháng (1 đến 7, 1 là Chủ Nhật)
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Chuyển thứ 0 thành thứ 7 (Chủ Nhật)
            if (dayoftheweek == 0)
            {
                dayoftheweek = 7;
            }

            // UserControl cho những ngày trống trước ngày đầu tháng
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // UserControl cho mỗi ngày trong tháng
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

            //Hiển thị event khi ấn chạy chương trình
            foreach (Control control in daycontainer.Controls)
            {
                if (control is UserControlDays)
                {
                    ((UserControlDays)control).RequestDisplayEvent();
                }
            }
        }


        // Phương thức để xác định đuôi cho số ngày
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

        private void btntoday_Click(object sender, EventArgs e)
        {
            // Xóa daycontainer và hiển thị lại các ngày trong tháng hiện tại
            daycontainer.Controls.Clear();
            displayDays();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            // Xóa daycontainer và hiển thị các ngày của tháng trước đó
            daycontainer.Controls.Clear();
            month--;

            // Điều chỉnh năm nếu cần
            if (month < 1)
            {
                month = 12;
                year--;
            }

            static_month = month;
            static_year = year;

            // Tính toán ngày đầu tháng và số ngày trong tháng mới
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            // Tính toán thứ của ngày đầu tháng (1 đến 7, 1 là Chủ Nhật)
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Chuyển thứ 0 thành thứ 7 (Chủ Nhật)
            if (dayoftheweek == 0)
            {
                dayoftheweek = 7;
            }

            // Cập nhật label với tháng và năm mới
            lbmonth.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;

            // UserControl cho những ngày trống trước ngày đầu tháng
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // UserControl cho mỗi ngày trong tháng
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

            //Hiển thị event khi ấn chạy chương trình
            foreach (Control control in daycontainer.Controls)
            {
                if (control is UserControlDays)
                {
                    ((UserControlDays)control).RequestDisplayEvent();
                }
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            // Xóa daycontainer và hiển thị các ngày của tháng tiếp theo
            daycontainer.Controls.Clear();
            month++;

            // Điều chỉnh năm nếu cần
            if (month > 12)
            {
                month = 1;
                year++;
            }

            static_month = month;
            static_year = year;

            // Tính toán ngày đầu tháng và số ngày trong tháng mới
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);

            // Tính toán thứ của ngày đầu tháng (1 đến 7, 1 là Chủ Nhật)
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            // Chuyển thứ 0 thành thứ 7 (Chủ Nhật)
            if (dayoftheweek == 0)
            {
                dayoftheweek = 7;
            }

            // Cập nhật label với tháng và năm mới
            lbmonth.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(month) + " " + year;

            // UserControl cho những ngày trống trước ngày đầu tháng
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // UserControl cho mỗi ngày trong tháng
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }

            //Hiển thị event khi ấn chạy chương trình
            foreach (Control control in daycontainer.Controls)
            {
                if (control is UserControlDays)
                {
                    ((UserControlDays)control).RequestDisplayEvent();
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog with Yes and No buttons
            DialogResult result = MessageBox.Show("Are you sure to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // If the user chooses "Yes," close the current form
                this.Close();
            }
            // If the user chooses "No," do nothing
        }

    }
}

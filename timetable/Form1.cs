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

        int month, year;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load form và hiển thị các ngày trong tháng hiện tại
            displayDays();
        }

        private void displayDays()
        {
            // Lấy ngày hiện tại và thiết lập tháng và năm ban đầu
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            // Hiển thị tháng và năm hiện tại trong label
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmonth.Text = monthname + " " + year;

            // Tính toán ngày đầu tháng và số ngày trong tháng
            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

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
        }

        private void btntoday_CLick(object sender, EventArgs e)
        {
            // Xóa daycontainer và hiển thị các ngày trong tháng hiện tại
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

            // Tính toán ngày đầu tháng và số ngày trong tháng mới
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

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

            // Tính toán ngày đầu tháng và số ngày trong tháng mới
            DateTime startofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

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
        }
    }
}

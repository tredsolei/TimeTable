using Microsoft.VisualBasic;
using System;
using System.Globalization;

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
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmonth.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1); 
            int days = DateTime.DaysInMonth(now.Year, now.Month); 
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")); 
            
            //User control trống
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }

            // User control cho ngày
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

    }
}

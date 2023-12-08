using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace timetable
{
    public partial class Form1 : Form
    {
        String connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none;Convert Zero Datetime=true";

        private static Form1 _instance;


        // Public property to access the instance
        public static Form1 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
        }
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

            // UserControl cho những ngày trống sau tháng
            int remainingDays = 7 - ((dayoftheweek - 1 + days) % 7);

            // Tính toán tổng số ngày cần thêm
            int totalRemainingDays = remainingDays + 7 * ((days - remainingDays) / 7);

            for (int i = 1; i <= totalRemainingDays; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
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

            // UserControl cho những ngày trống sau tháng
            int remainingDays = 7 - ((dayoftheweek - 1 + days) % 7);

            // Tính toán tổng số ngày cần thêm
            int totalRemainingDays = remainingDays + 7 * ((days - remainingDays) / 7);

            for (int i = 1; i <= totalRemainingDays; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
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
            //
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

            // UserControl cho những ngày trống sau tháng
            int remainingDays = 7 - ((dayoftheweek - 1 + days) % 7);

            // Tính toán tổng số ngày cần thêm
            int totalRemainingDays = remainingDays + 7 * ((days - remainingDays) / 7);

            for (int i = 1; i <= totalRemainingDays; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
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
            // Hiển thị hộp thoại xác nhận với 2 nút Yes và No 
            DialogResult result = MessageBox.Show("Are you sure to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra lựa chọn
            if (result == DialogResult.Yes)
            {
                // Nếu chọn Yes thì đóng form hiện tại 
                this.Close();
            }
            // Nếu chọn No thì không làm gì
        }

        // Phương thức để xem sự kiện quá hạn
        public void ViewOverdueEvents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Lấy ngày hiện tại
                DateTime currentDate = DateTime.UtcNow;

                // Truy vấn SQL để chọn các sự kiện quá hạn và loại các sự kiện đã hoàn thành
                string sql = "SELECT * FROM tbl_timetable WHERE date < @currentDate AND IsCompleted = false";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@currentDate", currentDate);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Tại nơi lưu trữ những sự kiện quá hạn
                    StringBuilder overdueEventsBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        // Truy xuất sự kiện 
                        DateTime eventDate = Convert.ToDateTime(reader["date"]).Date;
                        string? eventName = reader["event"].ToString();

                        // Kiểm tra sự kiện 
                        if (eventDate < currentDate.Date)
                        {
                            // Nối những sự kiện quá hạn vào nơi lưu trữ 
                            overdueEventsBuilder.AppendLine($"Date: {eventDate.ToString("d")}, Event: {eventName}");
                        }
                    }

                    // Hiển thị 
                    if (overdueEventsBuilder.Length > 0)
                    {
                        MessageBox.Show($"Overdue Events:\n{overdueEventsBuilder.ToString()}", "Overdue Events");
                    }
                    else
                    {
                        MessageBox.Show("No overdue events.", "Overdue Events");
                    }
                }
            }
        }

        //Phương thức để xem sự kiện sắp tới
        public void ViewUpcomingEvents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Lấy ngày hiện tại
                DateTime currentDate = DateTime.UtcNow;

                // Truy vấn SQL để chọn các sự kiện chưa xảy ra và sắp xếp tăng dần theo ngày 
                string sql = "SELECT * FROM tbl_timetable WHERE date >= @currentDate AND IsCompleted = false ORDER BY date ASC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@currentDate", currentDate);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Tại nơi lưu trữ những sự kiện sắp tới
                    StringBuilder upcomingEventsBuilder = new StringBuilder();

                    while (reader.Read())
                    {
                        // Truy xuất sự kiện 
                        DateTime eventDate = Convert.ToDateTime(reader["date"]).Date;
                        string? eventName = reader["event"].ToString();
                        // Kiểm tra sự kiện 
                        if (eventDate >= currentDate.Date)
                        {
                            // Nối những sự kiện sắp tới vào nơi lưu trữ 
                            upcomingEventsBuilder.AppendLine($"Date: {eventDate.ToString("d")}, Event: {eventName}");
                        }
                    }

                    // Hiển thị 
                    if (upcomingEventsBuilder.Length > 0)
                    {
                        MessageBox.Show($"Upcoming Events:\n{upcomingEventsBuilder.ToString()}", "Upcoming Events");
                    }
                    else
                    {
                        MessageBox.Show("No upcoming events.", "Upcoming Events");
                    }
                }
            }
        }
        // Xử lý sự kiện khi menu "Overdue Events" được chọn
        private void overdueEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOverdueEvents();
        }

        //Xử lý sự kiện khi menu "Upcoming Events" được chọn
        private void upcomingEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUpcomingEvents();
        }

        //Xử lý sự kiện khi menu "Add Events" được chọn
        private void addEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addeventform addEventform = new Addeventform(this);
            DialogResult result = addEventform.ShowDialog();

            // Kiểm tra kết quả sau khi đóng form1
            if (result == DialogResult.OK)
            {
                // Xử lý những hành động sau khi đóng form1
                RefreshDisplay();
            }
        }

        // Phương thức để làm mới hiển thị
        public void RefreshDisplay()
        {
            // Xóa tất cả các controls trong daycontainer trước khi tải lại dữ liệu
            daycontainer.Controls.Clear();
            // Tải lại dữ liệu từ cơ sở dữ liệu vào DataGridView
            LoadDataIntoDataGridView();
            // Hiển thị lại các ngày trên daycontainer
            displayDays();
            
        }

        // Xử lý sự kiện khi menu "Delete Events" được chọn
        private void deleteEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của DeleteEventform để xóa sự kiện
            DeleteEventform deleteEventForm = new DeleteEventform();
            // Hiển thị DeleteEventform dưới dạng hộp thoại và chờ đến khi nó đóng
            deleteEventForm.ShowDialog();
        }

        // Phương thức để tải dữ liệu từ cơ sở dữ liệu vào DataGridView
        private void LoadDataIntoDataGridView()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu MySQL
            string connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";

            // Truy vấn SQL để lấy dữ liệu từ bảng tbl_timetable
            string query = "SELECT * FROM tbl_timetable";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Tạo một đối tượng adapter để thực hiện truy vấn và điền dữ liệu vào DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                // Tạo một DataTable để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();

                // Chuyền dữ liệu từ cơ sở dữ liệu vào DataTable
                adapter.Fill(dataTable);

                // Liên kết DataTable với DataGridView để hiển thị dữ liệu
                dataGridViewEvents.DataSource = dataTable;
            }
        }
    }

}

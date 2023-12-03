﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cmp;

namespace timetable
{
    public partial class Eventform : Form
    {
        //tạo 1 chuỗi kết nối 
        String connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";

        public Eventform()
        {
            InitializeComponent();
        }

        private void Eventform_Load(object sender, EventArgs e)
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
                txtDate.Text = formattedDate;

                // Load trạng thái của event đã hoàn thành từ database
                LoadCompletionStatus(eventDate);
            }
        }

        private void LoadCompletionStatus(DateTime eventDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // SQL query to select completion status
                string sql = "SELECT IsCompleted FROM tbl_timetable WHERE date = @date";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", eventDate);

                try
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        bool isCompleted = Convert.ToBoolean(result);
                        checkCompleted.Checked = isCompleted;

                        // Update label status
                        UpdateStatusLabel(isCompleted);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading completion status: {ex.Message}");
                }
            }
        }

        private void UpdateStatusLabel(bool isCompleted)
        {
            // Hiển thị màu của checkbox khi được tick
            if (isCompleted)
            {
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Completed";
            }
            else
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Not Completed";
            }
        }

        // Hàm chuyển đổi số ngày thành chữ (ví dụ, "1" thành "1st")
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

        private void btnsave_Click(object sender, EventArgs e)
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
                //Truy vấn SQL để chèn event và checkCompleted vào database
                string sql = "INSERT INTO tbl_timetable(id, date, event, IsCompleted) VALUES (@id, @date, @event, @isCompleted)" + "ON DUPLICATE KEY UPDATE event = @event, IsCompleted = @isCompleted";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", GetEventId(eventDate));
                cmd.Parameters.AddWithValue("@date", eventDate);
                cmd.Parameters.AddWithValue("@event", txtEvent.Text);
                cmd.Parameters.AddWithValue("@isCompleted", checkCompleted.Checked);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved!");
                    
                    // Cập nhập trạng thái
                    UpdateStatusLabel(checkCompleted.Checked);

                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        //Lấy id cho sự kiện được chọn 
        private int GetEventId(DateTime eventDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT id FROM tbl_timetable WHERE date = @date";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@date", eventDate);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }

                return -1;
            }
        }
        private void checkCompleted_CheckedChanged(object sender, EventArgs e)
        {
            bool isCompleted = checkCompleted.Checked;

            // Hiển thị màu cho checkbox khi được tick 
            if (isCompleted)
            { 
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Completed";
            }
            else
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "Not Completed";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
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
    }
}

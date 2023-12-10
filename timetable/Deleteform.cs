using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetable
{
    public partial class DeleteEventform : Form
    {
        // Chuỗi kết nối đến cơ sở dữ liệu MySQL
        String connectionString = "server=localhost;user id=root;database=db_timetable;sslmode=none";

        public DeleteEventform()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi form được tải
        private void Deleteform_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu sự kiện vào DataGridView khi form được tải
            LoadDataIntoDataGridView();
        }

        // Xử lý sự kiện khi nút quay lại được nhấn
        private void btndeleteback_Click(object sender, EventArgs e)
        {
            // Tìm form cha (nếu tồn tại) và ẩn form hiện tại
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

        // Phương thức để lấy ID của sự kiện được chọn từ DataGridView
        private int GetSelectedEventId()
        {
            if (dataGridViewEvents.SelectedRows.Count > 0)
            {
                // Lấy hàng đã chọn
                DataGridViewRow selectedRow = dataGridViewEvents.SelectedRows[0];

                // Lấy giá trị từ cột "id"
                int eventId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                return eventId;
            }

            return -1;
        }

        // Phương thức để xóa một sự kiện khỏi cơ sở dữ liệu dựa trên ID của sự kiện
        private void DeleteEvent(int evenId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Giả sử có một cột có tên 'id' để lưu trữ ngày của sự kiện
                string deleteSql = "DELETE FROM tbl_timetable WHERE id = @eventId";
                MySqlCommand cmd = new MySqlCommand(deleteSql, conn);
                cmd.Parameters.AddWithValue("@eventId", evenId);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show($"Error deleting event: {ex.Message}");
                }
            }
        }

        // Xử lý sự kiện khi nút xóa được nhấn
        private void btndelete_Click(object sender, EventArgs e)
        {
            // Lấy ID của sự kiện được chọn
            int selectedEventId = GetSelectedEventId();

            if (selectedEventId != -1)
            {
                //  Xóa sự kiện được chọn khỏi cơ sở dữ liệu
                DeleteEvent(selectedEventId);

                // Gọi hàm từ Form1 để cập nhật dữ liệu sự kiện vào DataGridView sau khi xóa
                LoadDataIntoDataGridView();
            }

            // Sau khi xóa thành công, gọi phương thức cập nhật trên Form1
            Form1 parentForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (parentForm != null)
            {
                parentForm.RefreshDisplay();
            }
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

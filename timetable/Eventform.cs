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
    public partial class Eventform : Form
    {
        //tạo 1 chuỗi kết nối 
        String connectionString = "server = localhost; user id = root; database = db_timetable; sslmode = none";

        public Eventform()
        {
            InitializeComponent();
        }

        private void Eventform_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
        }
    }
}

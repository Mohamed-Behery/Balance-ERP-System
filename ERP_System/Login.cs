using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCrypt.Net;

namespace ERP_System
{
    public partial class Login : Form
    {
        readonly SqlConnection CONN = new SqlConnection("server=DESKTOP-8THKTFQ;Database=ERP_System;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from users where username= '" + txtUsername.Text + "'and password='" + txtPassword.Text + "'", CONN);
            DataTable users_table = new DataTable();
            adapter.Fill(users_table);
            if (users_table.Rows.Count > 0)
            {
                // string password = textBox2.Text;
                // string hashPassword = BCrypt.Net.BCrypt.HashPassword(password, 13);
                // MessageBox.Show(hashPassword);
                MessageBox.Show("تم تسجيل الدخول بنجاح");
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("لقد أدخلت بيانات خاطئة");
            }
        }

        private void ShowPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !ShowPassCheck.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

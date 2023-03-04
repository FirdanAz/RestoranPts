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

namespace RestoranPts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-VQ92HENQ\SQLEXPRESS;Initial Catalog=db_restoran;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from tb_login where username = '" + TxtUsername.Text + "' and password = '" + TxtPassword.Text + "' ", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 panggil = new Form2();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Yang anda masukkan salah");
            }
        }
    }
}

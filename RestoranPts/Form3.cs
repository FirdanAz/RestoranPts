using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestoranPts
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

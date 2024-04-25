using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            {
                {
                    Application.Exit();
                }
            }
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if ((txtUseName.Text == "DinhNguyen" && txtPw.Text == "20112003") || (txtUseName.Text == "DangMinhNghia" && txtPw.Text == "111")|| (txtUseName.Text == "DucLozz" && txtPw.Text == "222")|| (txtUseName.Text == "TruongFAT" && txtPw.Text == "333"))
            {
                lblError.Visible = false;
                BangDieuKhien ds = new BangDieuKhien();
                this.Hide();
                ds.Show();
            }
            else lblError.Visible = true;
            txtPw.Clear();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

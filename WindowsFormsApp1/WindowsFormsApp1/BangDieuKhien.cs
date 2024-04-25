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
    public partial class BangDieuKhien : Form
    {
        public BangDieuKhien()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BangDieuKhien_Load(object sender, EventArgs e)
        {
            userDatVe1.Visible = false;
            userProfile1.Visible = false;
            userLichTrinh1.Visible = false;
            userThanhToan1.Visible = false;
            userChiTietVeXe1.Visible = false;
            btnDatVe.PerformClick();
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            PnMoving.Left = btnDatVe.Left + 50;
            userDatVe1.Visible= true;
            userDatVe1.BringToFront();  
        }


        private void btnThongTinKH_Click(object sender, EventArgs e)
        {
            PnMoving.Left=btnThongTinKH.Left + 55;
            userProfile1.Visible=true;
            userProfile1.BringToFront();
        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            PnMoving.Left=btnLichTrinh.Left + 60;
            userLichTrinh1.Visible=true;
            userLichTrinh1.BringToFront();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            PnMoving.Left = btnThanhToan.Left + 60;
            userThanhToan1.Visible = true;
            userThanhToan1.BringToFront();
        }

        private void btnChiTietVe_Click(object sender, EventArgs e)
        {
            PnMoving.Left = btnChiTietVe.Left + 60;
            userChiTietVeXe1.Visible = true;
            userChiTietVeXe1.BringToFront();
        }

        private void btnMiniSize_Click(object sender, EventArgs e)
        {

        }
    }
}

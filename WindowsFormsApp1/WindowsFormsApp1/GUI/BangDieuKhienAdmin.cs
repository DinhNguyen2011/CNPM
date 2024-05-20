using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.KiemSoatAmin;

namespace WindowsFormsApp1
{
    public partial class BangDieuKhienAdmin : Form
    {
        public BangDieuKhienAdmin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLTuyenXe.Left + 60;
            userQuanLyTuyenXe1.Visible = true;
            userQuanLyTuyenXe1.BringToFront();
            userQuanLyChuyenXe1.Visible = false;
            userQuanLyNhanVien1.Visible = false;
            userQuanLyKhachHang1.Visible = false;
            userQuanLyXe1.Visible = false;
         //   userQuanLyVeXe1.Visible = false;

        }

        private void BangDieuKhienAdmin_Load(object sender, EventArgs e)
        {
            userQuanLyTuyenXe1.Visible = true;
            userQuanLyChuyenXe1.Visible = false;
            userQuanLyNhanVien1.Visible = false;
            userQuanLyKhachHang1.Visible = false;
            userQuanLyXe1.Visible = false;
          //  userQuanLyVeXe1.Visible = false;
            btnQLTuyenXe.PerformClick();
        }

        private void btnThongTinKH_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLKH.Left + 60;
            userQuanLyKhachHang1.Visible = true;
            userQuanLyKhachHang1.BringToFront();
            userQuanLyTuyenXe1.Visible = false;
            userQuanLyChuyenXe1.Visible = false;
            userQuanLyNhanVien1.Visible = false;
            userQuanLyXe1.Visible = false;
           // userQuanLyVeXe1.Visible = false;
        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLNV.Left + 60;
            userQuanLyNhanVien1.Visible = true;
            userQuanLyNhanVien1.BringToFront();
            userQuanLyTuyenXe1.Visible = false;
            userQuanLyChuyenXe1.Visible = false;
            userQuanLyKhachHang1.Visible = false;
            userQuanLyXe1.Visible = false;
          //  userQuanLyVeXe1.Visible = false;
        }

        private void btnQLXe_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLXe.Left + 60;
            userQuanLyXe1.Visible = true;
            userQuanLyXe1.BringToFront();
            userQuanLyTuyenXe1.Visible = false;
            userQuanLyChuyenXe1.Visible = false;
            userQuanLyNhanVien1.Visible = false;
            userQuanLyKhachHang1.Visible = false;
          //  userQuanLyVeXe1.Visible = false;
        }

        private void userQuanLyXe1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất tài khoản?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            { 
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
            }    
        }

        private void btnMiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnQLCX_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLCX.Left + 60;
            userQuanLyChuyenXe1.Visible = true;
            userQuanLyChuyenXe1.BringToFront();
            userQuanLyTuyenXe1.Visible = false;
            userQuanLyNhanVien1.Visible = false;
            userQuanLyKhachHang1.Visible = false;
            userQuanLyXe1.Visible = false;
          //  userQuanLyVeXe1.Visible = false;
        }

        private void btnQLVeXe_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLVeXe.Left + 60;
          //  userQuanLyVeXe1.Visible = true;
          //  userQuanLyVeXe1.BringToFront();
            userQuanLyChuyenXe1.Visible = false;
            userQuanLyTuyenXe1.Visible = false;
            userQuanLyNhanVien1.Visible = false;
            userQuanLyKhachHang1.Visible = false;
            userQuanLyXe1.Visible = false;
        }
    }
}

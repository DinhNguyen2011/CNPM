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
            Application.Exit();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLBanVe.Left + 60;
            userQuanLyBanVe1.Visible = true;
            userQuanLyBanVe1.BringToFront();
        }

        private void BangDieuKhienAdmin_Load(object sender, EventArgs e)
        {
            userQuanLyBanVe1.Visible =false ;
            userQuanLyNhanVien1.Visible = false;
            userQuanLyKhachHang1.Visible = false ;
            userQuanLyXe1.Visible = false;
            btnQLBanVe.PerformClick();
        }

        private void btnThongTinKH_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLKH.Left + 60;
            userQuanLyKhachHang1.Visible = true;
            userQuanLyKhachHang1.BringToFront();
        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLNV.Left + 60;
            userQuanLyNhanVien1.Visible = true;
            userQuanLyNhanVien1.BringToFront();
        }

        private void btnQLXe_Click(object sender, EventArgs e)
        {
            PnMovingad.Left = btnQLXe.Left + 60;
            userQuanLyXe1.Visible = true;
            userQuanLyXe1.BringToFront();
        }

        private void userQuanLyXe1_Load(object sender, EventArgs e)
        {

        }
    }
}

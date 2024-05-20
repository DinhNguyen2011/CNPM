using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class BangDieuKhien : Form
    {
        private int index = 0;
        private KhachHang user;
        public BangDieuKhien(KhachHang user)
        {
            this.user = user;
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void BangDieuKhien_Load(object sender, EventArgs e)
        {
            userDatVe1.Visible = false;
            userProfile1.Visible = false;
            userLichTrinh1.Visible = false;
            userThanhToan1.Visible = false;
            userChiTietVeXe1.Visible = false;
            lbHello.Text = "Hello, " + user.Tenkh + " !!";
            chonLichTrinh();
        }

        private void resetColorOfTitlePage()
        {
            btnTrangChu.FillColor = Color.RoyalBlue;

            if (index > 0) 
                btnChonVe.FillColor = Color.RoyalBlue;
            else
                btnChonVe.FillColor = Color.Cyan;

            if (index > 1)
                btnThongTinKH.FillColor = Color.RoyalBlue;
            else
                btnThongTinKH.FillColor = Color.Cyan;

            if (index > 2)
                btnThanhToan.FillColor = Color.RoyalBlue;
            else
                btnThanhToan.FillColor = Color.Cyan;

            btnKiemTraVe.FillColor = Color.RoyalBlue;
        }


        private void chonThongTinVe(LichTrinh selected)
        {
            PnMoving.Left = btnChonChuyen.Left + 50;
            if (selected != null ) userDatVe1.LtSelected = selected;
            userDatVe1.setValue();
            userDatVe1.Visible = true;
            userDatVe1.BringToFront();
            btnXacNhanVe.BringToFront();
            resetColorOfTitlePage();
            btnChonVe.FillColor = Color.FromArgb(0, 192, 0);
        }
     

        private void nhapThongTinKhachHang()
        {
            PnMoving.Left = btnThongTinKH.Left + 55;
            userProfile1.Visible = true;
            userProfile1.BringToFront();
            btnXacNhanKH.BringToFront();
            resetColorOfTitlePage();
            btnThongTinKH.FillColor = Color.FromArgb(0, 192, 0);
        }
        
        private void chonLichTrinh()
        {
            PnMoving.Left=btnTrangChu.Left + 60;
            userLichTrinh1.Visible=true;
            userLichTrinh1.BringToFront();
            btnChonChuyen.BringToFront();
            resetColorOfTitlePage();
            btnTrangChu.FillColor = Color.FromArgb(0, 192, 0);
        }
       

        private void thanhToan()
        {
            PnMoving.Left = btnThanhToan.Left + 60;
            userThanhToan1.Visible = true;
            userThanhToan1.BringToFront();
            resetColorOfTitlePage();
            btnThanhToan.FillColor = Color.FromArgb(0, 192, 0);
        }
        private void kiemTraVe()
        {
            PnMoving.Left = btnKiemTraVe.Left + 60;
            userChiTietVeXe1.Visible = true;
            userChiTietVeXe1.BringToFront();
            resetColorOfTitlePage();
            btnKiemTraVe.FillColor = Color.FromArgb(0, 192, 0);
        }
        

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            chonLichTrinh();
        }

        private void btnChonVe_Click(object sender, EventArgs e)
        {
            if (index > 0) chonThongTinVe(null);
        }

        private void btnThongTinKH_Click(object sender, EventArgs e)
        {
            if (index > 1) nhapThongTinKhachHang();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (index > 2) thanhToan();
        }

        private void btnKiemTraVe_Click(object sender, EventArgs e)
        {
            kiemTraVe();
        }
        private void btnChonChuyen_Click(object sender, EventArgs e)
        {
            LichTrinh selected = userLichTrinh1.Selected;
            if (selected != null)
            {
                index++;
                if (MessageBox.Show("Chuyến " + selected.DiemDi + " - " + selected.DiemDen + " vào lúc " + selected.Giodi, "Xác nhận lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    chonThongTinVe(selected);
            }
            else
                MessageBox.Show("Vui lòng chọn chuyến đi !!", "Thông báo");

            
        }
        private void btnXacNhanVe_Click(object sender, EventArgs e)
        {
            index++;
            nhapThongTinKhachHang();
        }

        private void btnXacNhanKH_Click(object sender, EventArgs e)
        {
            index++;
            thanhToan();
        }

        
    }
}

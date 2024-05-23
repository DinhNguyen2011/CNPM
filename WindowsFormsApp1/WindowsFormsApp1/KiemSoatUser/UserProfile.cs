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

namespace WindowsFormsApp1.KiemSoatUser
{
    public partial class UserProfile : UserControl
    {

        //private KhachHang thongTinChuVe;
        //private string ghiChu = "";
        //public UserProfile()
        //{
        //    InitializeComponent();
        //    thongTinChuVe = new KhachHang();
        //    rdbtNam.Checked = true;
        //}

        //public void setValue(KhachHang user)
        //{
        //    thongTinChuVe = user;
        //    txtTen.Text = user.Tenkh;
        //    txtEmail.Text = user.Email;
        //    txtSDT.Text = user.Sdt;
        //    if (user.Ngaysinh != null)
        //        dtpkNgaySinh.Value = user.Ngaysinh.Value;
            
        //}

        //public KhachHang ThongTinChuVe { get => thongTinChuVe;}
        //public string GhiChu { get => ghiChu;}

        //private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void txtDiaChi_Leave(object sender, EventArgs e)
        //{
        //    thongTinChuVe.Diachi = txtDiaChi.Text;
        //}

        //private void txtTen_Leave(object sender, EventArgs e)
        //{
        //    thongTinChuVe.Tenkh = txtTen.Text;
        //}

        //private void txtEmail_Leave(object sender, EventArgs e)
        //{
        //    thongTinChuVe.Email = txtEmail.Text;    
        //}

        //private void txtSDT_Leave(object sender, EventArgs e)
        //{
        //    thongTinChuVe.Sdt = txtSDT.Text;
        //}

        //private void radioButton2_CheckedChanged(object sender, EventArgs e)
        //{
        //    thongTinChuVe.Gioitinh = "Nữ";
        //}


        //private void dtpkNgaySinh_ValueChanged(object sender, EventArgs e)
        //{
        //    thongTinChuVe.Ngaysinh=dtpkNgaySinh.Value;
        //}

        //private void rdbtNam_CheckedChanged(object sender, EventArgs e)
        //{
        //    thongTinChuVe.Gioitinh = "Nam";
        //}

        //private void txtGhichu_Leave(object sender, EventArgs e)
        //{
        //    ghiChu = txtGhichu.Text;
        //}
    }
}

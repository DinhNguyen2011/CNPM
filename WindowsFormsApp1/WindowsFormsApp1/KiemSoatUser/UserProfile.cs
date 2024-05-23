using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.KiemSoatUser
{
    public partial class UserProfile : UserControl
    {

        private KhachHang custumer;
        
        public UserProfile()
        {
            InitializeComponent();
            custumer = new KhachHang();
            rdbtNam.Checked = true;
        }

        public KhachHang Custumer { get => custumer; }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool chuanHoaSDT(string sdt)
        {
            return sdt.StartsWith("0") && sdt.Length == 10;
        }

        private bool chuanHoaEmail(string email)
        {
            email = email.Trim();
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            custumer.Diachi = txtDiaChi.Text;
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {
            custumer.Tenkh = txtTen.Text;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!chuanHoaEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ !!", "Thông báo");
                txtEmail.Focus();
            }    
            else custumer.Email = txtEmail.Text;
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (!chuanHoaSDT(txtSDT.Text))
            {
                MessageBox.Show("SĐT không hợp lệ !!", "Thông báo");
                txtSDT.Focus();
            }    
            else custumer.Sdt = txtSDT.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            custumer.Gioitinh = "Nữ";
        }


        private void dtpkNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            custumer.Ngaysinh = dtpkNgaySinh.Value;
        }

        private void rdbtNam_CheckedChanged(object sender, EventArgs e)
        {
            custumer.Gioitinh = "Nam";
        }

        private void txtGhichu_Leave(object sender, EventArgs e)
        {
            custumer.Ghichu = txtGhichu.Text;
        }
    }
}

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
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class DangKiTaiKhoang : Form
    {
        
        public DangKiTaiKhoang()
        {
            InitializeComponent();
        }
        #region Xử lý phụ
        private bool isValidSoDienThoai(string sdt)
        {
            if (sdt.Length != 10)
                return false;
            if (sdt.StartsWith("0") == false)
                return false;
            foreach (char s in sdt)
            {
                if (s < 48 || s > 57)
                    return false;
            }
            return true;
        }
        public bool isValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
        public bool isValidCCCD(string cccd)
        {
            if (string.IsNullOrEmpty(cccd))
            {
                return false;
            }
            if (cccd.Length != 12)
                return false;
            foreach (char s in cccd)
            {
                if (s < 48 || s > 57)
                    return false;
            }
            return true;
        }
        #endregion

        #region Method
        private bool DangKy(string tennv,string cccd, string sdt, string email, int maloainv, string taikhoan, string matkhau)
        {
            return TaiKhoanDAO.Instance.Register(tennv,cccd, sdt, email,maloainv, taikhoan, matkhau);
        }
        #endregion

        #region Form Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }
        private void btnDkiTK_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
        private void txtTenDK_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string tennv = txtTenNguoiDung.Text;
                string sdt = txtSĐT.Text;
                string email = txtEmail.Text;
                string taikhoan = txtTenDK.Text;
                string matkhau = txtMatKhau.Text;
                string nhaplaimk = txtNhapLaiMK.Text;
                string cccd = txtcmnd.Text;
                if (tennv == "" || sdt == "" || email == "" || taikhoan == "" || matkhau == "" || cccd == "")
                {
                    lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin";
                    lblThongBao.Visible = true;
                    return;
                }
                if (!isValidSoDienThoai(sdt))
                {
                    lblThongBao.Text = "Số điện thoại không hợp lệ. Vui lòng nhập lại";
                    lblThongBao.Visible = true;
                    return;
                }
                if (!isValidEmail(email))
                {
                    lblThongBao.Text = "Địa chỉ email không hợp lệ. Vui lòng nhập lại";
                    lblThongBao.Visible = true;
                    return;
                }
                if (String.Compare(matkhau, nhaplaimk, false) != 0)
                {
                    lblThongBao.Text = "Mật khẩu không giống nhau. Vui lòng nhập lại";
                    lblThongBao.Visible = true;
                    return;
                }
                if (!isValidCCCD(cccd))
                {
                    lblThongBao.Text = "Căn cước công dân không hợp lệ. Vui lòng nhập lại";
                    lblThongBao.Visible = true;
                    return;
                }
                int maloainv = LoaiNVDAO.Instance.getIDOfNVBanVe();
                if (DangKy(tennv,cccd, sdt, email, maloainv, taikhoan, matkhau))
                {
                    lblThongBao.Text = "Đăng ký tài khoản thành công";
                    lblThongBao.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Conversion failed when converting the nvarchar value 'Tên tài khoản đã tồn tại!'"))
                {
                    lblThongBao.Text = "Tên đăng nhập đã tồn tại";
                    lblThongBao.Visible = true;
                }
                else if (ex.Message.StartsWith("Conversion failed when converting the nvarchar value 'Trùng CMND'"))
                {
                    lblThongBao.Text = "Trùng CCCD";
                    lblThongBao.Visible = true;
                }    
                else
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void DangKiTaiKhoang_Load(object sender, EventArgs e)
        {
            guna2Panel1.Location = new Point(
            this.ClientSize.Width / 2 - guna2Panel1.Size.Width / 2,
            this.ClientSize.Height / 2 - guna2Panel1.Size.Height / 2);
            guna2Panel1.Anchor = AnchorStyles.None;
        }



        #endregion

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            BangDieuKhienAdmin bdk = new BangDieuKhienAdmin();
            this.Hide();
            bdk.ShowDialog();
        }
    }
}

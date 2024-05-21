using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region Xử lý phụ

        #endregion

        #region Method
        private bool login(string username, string password)
        {
            return TaiKhoanDAO.Instance.Login(username, password);
        }
        private void checkLogin()
        {
            string username = txtUseName.Text;
            string password = txtPw.Text;
            if (login(username, password))
            {
                if (String.Compare(username, "admin", true) == 0)
                {
                    BangDieuKhienAdmin bdkAdmin = new BangDieuKhienAdmin();
                    this.Hide();
                    bdkAdmin.ShowDialog();
                }
                else
                {
                    DataRow row = DataProvider.Instance.ExcuteQuery("GETKHACHHANG @usenamer", new object[] { username }).Rows[0];
                    KhachHang user = new KhachHang(row);
                    BangDieuKhien bangDieuKhien = new BangDieuKhien(user);
                    this.Hide();
                    bangDieuKhien.ShowDialog();
                }
            }
            else lblError.Visible = true;
            txtPw.Clear();
        }
        #endregion

        #region Form Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }
        private void txtLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }
        private void btnDkiTK_Click(object sender, EventArgs e)
        {
            DangKiTaiKhoang dk = new DangKiTaiKhoang();
            this.Hide();
            dk.Show();
        }
        private void txtPw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin();
            }
        }
        private void txtUseName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkLogin();
            }
        }
        #endregion











    }
}

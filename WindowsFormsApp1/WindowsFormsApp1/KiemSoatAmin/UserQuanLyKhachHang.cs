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

namespace WindowsFormsApp1.KiemSoatAmin
{
    public partial class UserQuanLyKhachHang : UserControl
    {
        private List<KhachHang> listKhachHang;
        private List<TaiKhoan> listTaiKhoan;
        private int index = 0;
        public UserQuanLyKhachHang()
        {
            InitializeComponent();
        }

        #region Xử lý phụ
        private string chuanHoaChuoi(String s)
        {
            s = s.Trim();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && s[i + 1] == ' ')
                {
                    s = s.Remove(i + 1, 1);
                    i--;
                }
            }
            return s;
        }
        #endregion

        #region method
        public void LoadKhachHang()
        {
            dgvTimKH.AutoGenerateColumns = false;
            listKhachHang = new List<KhachHang>();
            btnXoaKH.Enabled = false;
            listKhachHang = KhachHangDAO.Instance.getDSKhachHang();
            dgvTimKH.DataSource = listKhachHang;
            dgvTimKH.Refresh();
        }
        public void LoadTaiKhoan()
        {
            dgvtaikhoan.AutoGenerateColumns = false;
            listTaiKhoan = new List<TaiKhoan>();
            btnXoaKH.Enabled = false;
            listTaiKhoan = TaiKhoanDAO.Instance.getDSTaiKhoan();
            dgvtaikhoan.DataSource = listTaiKhoan;
            dgvtaikhoan.Refresh();
        }
        public void LoadData()
        {
            LoadKhachHang();
            LoadTaiKhoan();
        }
        public void xoa()
        {
            KhachHang kh = listKhachHang[index];
            if (KhachHangDAO.Instance.xoaKhachHang(kh.Makh) > 0)
            {
                LoadKhachHang();
                LoadTaiKhoan();
                MessageBox.Show("Đã xóa khách hàng vừa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void timKhachHang() 
        {
            string tenkh = chuanHoaChuoi(txttimkh.Text);
            List<KhachHang> listFindKhachHang = KhachHangDAO.Instance.timKhachHangTheoTen(tenkh);
            if (listFindKhachHang.Count != 0)
            {
                btnXoaKH.Enabled = true;
                dgvTimKH.DataSource = listFindKhachHang;
                dgvTimKH.Refresh();
                listKhachHang = listFindKhachHang;

                 TaiKhoan tk = null;
                 List<TaiKhoan> listFindAccount = new List<TaiKhoan>();
                 foreach (KhachHang item in listFindKhachHang)
                 {
                     tk = TaiKhoanDAO.Instance.findTaiKhoanByMaKH(item);
                     if (tk != null)
                     {
                         listFindAccount.Add(tk);
                     }
                 }
                 dgvtaikhoan.DataSource = listFindAccount;
                 dgvtaikhoan.Refresh();

            }
            else
                MessageBox.Show("Không tìm thấy khách hàng có tên " + tenkh, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Form Event
        private void UserQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string tenkh = listKhachHang[index].Tenkh;
            int makh = listKhachHang[index].Makh;
            if (MessageBox.Show("Bạn có muốn xóa khách hàng " + tenkh + " có mã khách hàng là " + makh + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                xoa();
            }
        }
        private void dgvTimKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvTimKH.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    btnXoaKH.Enabled = true;
                    index = indexRow;
                    dgvtaikhoan.Rows[index].Selected = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Index was out of range"))
                    MessageBox.Show("Đừng chọn linh tinh bạn nhé!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    throw ex;
            }
        }
        private void dgvtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvtaikhoan.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    btnXoaKH.Enabled = true;
                    index = indexRow;
                    dgvTimKH.Rows[index].Selected = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Index was out of range"))
                    MessageBox.Show("Đừng chọn linh tinh bạn nhé!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    throw ex;
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnproFile_Click(object sender, EventArgs e)
        {

        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnTimKH_Click(object sender, EventArgs e)
        {
            timKhachHang();
        }

        #endregion

    }
}

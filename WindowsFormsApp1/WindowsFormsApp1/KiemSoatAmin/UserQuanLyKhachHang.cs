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
        private int index = -1;
        public UserQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnproFile_Click(object sender, EventArgs e)
        {

        }
        public void LoadKhachHang()
        {
            btnXoaKH.Enabled = false;
            listKhachHang = KhachHangDAO.Instance.getDSKhachHang();
            dgvTimKH.DataSource = listKhachHang;
            dgvTimKH.Refresh();
        }
        public void xoa()
        {
            KhachHang kh = listKhachHang[index];
            if (KhachHangDAO.Instance.xoaKhachHang(kh.Makh) > 0)
            {
                LoadKhachHang();
                MessageBox.Show("Đã xóa khách hàng vừa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UserQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            string tenkh = listKhachHang[index].Tenkh;
            if (MessageBox.Show("Bạn có muốn xóa khách hàng " +tenkh+ "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                }
            }
             catch(Exception ex)
            {
                if (ex.Message.StartsWith("Index was out of range"))
                    MessageBox.Show("Đừng chọn linh tinh bạn nhé!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    throw ex;
            }
        }
    }
}

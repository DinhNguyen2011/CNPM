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

namespace WindowsFormsApp1.KiemSoatAmin
{
    public partial class UserQuanLyKhachHang : UserControl
    {
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
            dgvTimKH.DataSource = KhachHangDAO.Instance.getDSKhachHang();
            dgvTimKH.Refresh();
        }
        private void UserQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
    }
}

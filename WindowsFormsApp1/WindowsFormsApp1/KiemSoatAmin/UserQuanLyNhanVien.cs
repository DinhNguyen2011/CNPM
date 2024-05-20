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
    public partial class UserQuanLyNhanVien : UserControl
    {
        public UserQuanLyNhanVien()
        {
            InitializeComponent();
        }
        public void LoadNhanVien()
        {
            dgvQLNV.DataSource = NhanVienDAO.Instance.getDSNhanVien();
            dgvQLNV.Refresh();
        }

        private void UserQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void btnthemloainv_Click(object sender, EventArgs e)
        {

        }

        private void btnxoaloainv_Click(object sender, EventArgs e)
        {

        }

        private void UserQuanLyNhanVien_Load_1(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

        }
    }
}

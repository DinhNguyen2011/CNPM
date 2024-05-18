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
    public partial class UserQuanLyTuyenXe : UserControl
    {
        public UserQuanLyTuyenXe()
        {
            InitializeComponent();
        }

        private void dgvVeXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void LoadTuyenXe()
        {
            dgvVeXe.DataSource = TuyenXeDAO.Instance.getDSTuyenXe();
            dgvVeXe.Refresh();
        }

        private void UserQuanLyTuyenXe_Load(object sender, EventArgs e)
        {
            LoadTuyenXe();
        }
    }
}

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
    public partial class UserQuanLyTuyenXe : UserControl
    {
        private List<TuyenXe> listTuyenXe;
        private int index = -1;
        public UserQuanLyTuyenXe()
        {
            InitializeComponent();
            
        }

        private void dgvVeXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void LoadTuyenXe()
        {
            btnXoaTuyen.Enabled = false;
            listTuyenXe = TuyenXeDAO.Instance.getDSTuyenXe();
            dgvVeXe.DataSource = listTuyenXe;
            dgvVeXe.Refresh();
        }
        public void themTuyenXe()
        {
            string diemdi = txtdiemdi.Text;
            string diemden = txtdiemden.Text;
            TuyenXe tx = new TuyenXe(diemdi,diemden);
            if (TuyenXeDAO.Instance.themTuyenXe(tx) != 0)
            {
                LoadTuyenXe();
                MessageBox.Show("Thêm tuyến xe mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  

        }
        public void xoaTuyenXe()
        {
            TuyenXe tx = listTuyenXe[index];
            if (TuyenXeDAO.Instance.xoaTuyenxe(tx.Matuyen) != 0)
            {
                LoadTuyenXe();
                MessageBox.Show("Đã xóa tuyến xe vừa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UserQuanLyTuyenXe_Load(object sender, EventArgs e)
        {
            LoadTuyenXe();
        }

        private void btnThemTuyen_Click(object sender, EventArgs e)
        {
            themTuyenXe();
        }

        private void dgvVeXe_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = dgvVeXe.Rows[e.RowIndex].Index;
            if (indexRow > -1)
            {
                btnXoaTuyen.Enabled = true;
                TuyenXe tx = listTuyenXe[indexRow];
                txtdiemdi.Text = tx.Diemdi;
                txtdiemden.Text = tx.Diemden;
                index = indexRow;
            }    
        }

        private void btnXoaTuyen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tuyến xe này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                xoaTuyenXe();
        }
    }
}

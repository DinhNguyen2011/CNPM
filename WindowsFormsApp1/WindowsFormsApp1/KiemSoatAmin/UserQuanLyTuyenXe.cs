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
        public void LoadTuyenXe()
        {
            btnXoaTuyen.Enabled = false;
            listTuyenXe = TuyenXeDAO.Instance.getDSTuyenXe();
            dgvVeXe.DataSource = listTuyenXe;
            dgvVeXe.Refresh();
        }
        public void reset() 
        {
            txtdiemden.Text = string.Empty;
            txtdiemdi.Text = string.Empty;
        }
        public void themTuyenXe()
        {
            string diemdi = txtdiemdi.Text.Trim();
            string diemden = txtdiemden.Text.Trim();
            TuyenXe tx = new TuyenXe(diemdi,diemden);
            if (TuyenXeDAO.Instance.themTuyenXe(tx) > 0)
            {
                LoadTuyenXe();
                reset();
                MessageBox.Show("Thêm tuyến xe mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  

        }
        public void xoaTuyenXe()
        {
            TuyenXe tx = listTuyenXe[index];
            if (TuyenXeDAO.Instance.xoaTuyenxe(tx.Matuyen) > 0)
            {
                LoadTuyenXe();
                reset();
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
        private void btnXoaTuyen_Click(object sender, EventArgs e)
        {
            string diemdi = listTuyenXe[index].Diemdi;
            string diemden = listTuyenXe[index].Diemden;
            if (MessageBox.Show("Bạn có muốn xóa tuyến xe "+diemdi+" - " + diemden+  "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                xoaTuyenXe();
        }
        private void dgvVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Index was out of range"))
                    MessageBox.Show("Đừng chọn linh tinh bạn nhé!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    throw ex;
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = txtdiemdi.Text;
            txtdiemdi.Text = txtdiemden.Text;
            txtdiemden.Text = temp;
        }
    }
}

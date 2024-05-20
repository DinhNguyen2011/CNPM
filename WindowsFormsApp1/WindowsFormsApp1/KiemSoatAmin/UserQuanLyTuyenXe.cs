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
        private int index = 0;
        public UserQuanLyTuyenXe()
        {
            InitializeComponent();
            
        }
        #region xử lý phụ
        public void reset()
        {
            txtdiemden.Text = string.Empty;
            txtdiemdi.Text = string.Empty;
        }
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

        #region Method
        public void LoadTuyenXe()
        {
            btnXoaTuyen.Enabled = false;
            btnThemTuyen.Enabled = true; ;
            listTuyenXe = TuyenXeDAO.Instance.getDSTuyenXe();
            dgvVeXe.DataSource = listTuyenXe;
            dgvVeXe.Refresh();
        }
        public void themTuyenXe()
        {
            string diemdi = chuanHoaChuoi(txtdiemdi.Text);
            string diemden = chuanHoaChuoi(txtdiemden.Text);
            TuyenXe tx = new TuyenXe(diemdi, diemden);
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
        public void timTuyenXe()
        {
            string diemdi = chuanHoaChuoi(txtdiemdi.Text);
            string diemden = chuanHoaChuoi(txtdiemden.Text);
            List<TuyenXe> temp = TuyenXeDAO.Instance.timTuyenXe(diemdi, diemden);
            if (temp.Count > 0)
            {
                btnXoaTuyen.Enabled = false;
                btnThemTuyen.Enabled = false;
                dgvVeXe.DataSource = temp;
                dgvVeXe.Refresh();
                listTuyenXe = temp;
            }
            else
                MessageBox.Show("Không có tuyến xe " + diemdi + " - " + diemden, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Form Event
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
            try
            {
                string diemdi = listTuyenXe[index].Diemdi;
                string diemden = listTuyenXe[index].Diemden;
                if (MessageBox.Show("Bạn có muốn xóa tuyến xe " + diemdi + " - " + diemden + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    xoaTuyenXe();
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Index was out of range. Must be non-negative and less than the size of the collection"))
                    MessageBox.Show("Vui lòng chọn tuyến xe cần xóa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadTuyenXe();
        }

        private void btnTimTuyen_Click(object sender, EventArgs e)
        {
            timTuyenXe();
        }
        #endregion





    }
}

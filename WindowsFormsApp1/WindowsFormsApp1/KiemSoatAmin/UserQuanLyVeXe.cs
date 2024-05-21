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
    public partial class UserQuanLyVeXe : UserControl
    {
        private List<VeXe> listVexe;
        private List<ChiTietVeXe> listChiTietVeXe;
        private int index = 0;
        public UserQuanLyVeXe()
        {
            InitializeComponent();
            dgvChiTietVeXe.AutoGenerateColumns = false;
            dgvVeXe.AutoGenerateColumns = false;
            dtpgioden.Enabled = false;
            dtpgiodi.Enabled = false;
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

        #region Method
        public void LoadData()
        {
            
            btnXoaVeXe.Enabled = false;
            LoadVeXe();
            LoadChiTietVeXe();
        }
        public void LoadVeXe()
        {

            listVexe = VeXeDAO.Instance.getDSVeXe();
            dgvVeXe.DataSource = listVexe;
            dgvVeXe.Refresh();
        }
        public void LoadChiTietVeXe()
        {

            listChiTietVeXe = ChiTietVeXeDAO.Instance.getDSChiTietVeXe();
            dgvChiTietVeXe.DataSource = listChiTietVeXe;
            dgvChiTietVeXe.Refresh();

        }
        public void xoaVe()
        {
            VeXe v = listVexe[index];
            if (VeXeDAO.Instance.xoaVeXe(v.Mave) > 0)
            {
                LoadData();
                MessageBox.Show("Đã xóa khách hàng vừa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void timVe()
        {
            btnXoaVeXe.Enabled = false;
            string tenkh = chuanHoaChuoi(txtTimKH.Text);
            List<VeXe> listFindVeXe = VeXeDAO.Instance.timDSVeXetheoTenKH(tenkh);
            if (listFindVeXe.Count > 0)
            {
                dgvVeXe.DataSource = listFindVeXe;
                dgvVeXe.Refresh();
                listVexe = listFindVeXe;

                List<ChiTietVeXe> listFindChiTietVeXe = new List<ChiTietVeXe>();
                foreach (VeXe item in listFindVeXe)
                {
                    ChiTietVeXe ctvx = null;
                    ctvx = ChiTietVeXeDAO.Instance.TimCTVXBangMaVe(item.Mave);
                    if (ctvx != null)
                    {
                        listFindChiTietVeXe.Add(ctvx);
                    }
                }
                dgvChiTietVeXe.DataSource = listFindChiTietVeXe;
                dgvChiTietVeXe.Refresh();
                listChiTietVeXe = listFindChiTietVeXe;
            }
            else
                MessageBox.Show("Không tìm thấy vé xe của khách hàng có tên " + tenkh, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Form Event

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnXoaVeXe_Click(object sender, EventArgs e)
        {
            string tenkh = KhachHangDAO.Instance.getTenKhachHangByID(listVexe[index].Makh);
            int mave = listVexe[index].Mave;
            if (MessageBox.Show("Bạn có muốn xóa vé xe của khách hàng " + tenkh + " có mã vé xe là " + mave + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                xoaVe();
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimVeXe_Click(object sender, EventArgs e)
        {
            timVe();
        }

        private void dgvChiTietVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvChiTietVeXe.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    ChiTietVeXe ctvx = listChiTietVeXe[indexRow];
                    txtgiave.Text = ctvx.Giave.ToString();
                    txtvitrighe.Text = ctvx.Vitrighe;
                    txttrangthai.Text = ctvx.Trangthai;
                    dtpgiodi.Value = Convert.ToDateTime(ctvx.Giodi);
                    dtpgioden.Value = Convert.ToDateTime(ctvx.Gioden);
                    index = indexRow;

                    btnXoaVeXe.Enabled = true;
                    dgvVeXe.Rows[index].Selected = true;
                    btnXoaVeXe.Enabled = true;
                    VeXe v = listVexe[indexRow];
                    txtTenVe.Text = v.Tenve;
                    txtTenKH.Text = KhachHangDAO.Instance.getTenKhachHangByID(v.Makh);
                    txtghichu.Text = v.Ghichu;
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

        private void dgvVeXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvVeXe.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    btnXoaVeXe.Enabled = true;
                    VeXe v = listVexe[indexRow];
                    txtTenVe.Text = v.Tenve;
                    txtTenKH.Text = KhachHangDAO.Instance.getTenKhachHangByID(v.Makh);
                    txtghichu.Text = v.Ghichu;
                    index = indexRow;

                    dgvChiTietVeXe.Rows[index].Selected = true;
                    ChiTietVeXe ctvx = listChiTietVeXe[indexRow];
                    txtgiave.Text = ctvx.Giave.ToString();
                    txtvitrighe.Text = ctvx.Vitrighe;
                    txttrangthai.Text = ctvx.Trangthai;
                    dtpgiodi.Value = Convert.ToDateTime(ctvx.Giodi);
                    dtpgioden.Value = Convert.ToDateTime(ctvx.Gioden);
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
        private void UserQuanLyVeXe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion


    }
}

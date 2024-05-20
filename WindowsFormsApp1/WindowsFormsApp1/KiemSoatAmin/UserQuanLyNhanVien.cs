using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.KiemSoatAmin
{
    public partial class UserQuanLyNhanVien : UserControl
    {
        private List<NhanVien> listNhanVien;
        private List<LoaiNV> listLoaiNV;
        private int indexNhanVien = -1;
        private int indexLoaiNV = -1;
        public UserQuanLyNhanVien()
        {
            InitializeComponent();
        }

        #region xử lý phụ
        private string chuanHoaChuoi(String s)
        {
            s = s.Trim();
            for (int i = 0; i<s.Length; i++)
            {
                if (s[i] == ' ' && s[i + 1] == ' ')
                {
                    s = s.Remove(i+1,1);
                    i--;
                }
            }    
            return s;
        }
        private bool isValidSoDienThoai(string sdt)
        {
            if (sdt.Length != 10)
                return false;
            if (sdt.StartsWith("0") == false)
                return false;
            foreach (char s in sdt)
            {
                if (s < 48 || s > 57)
                    return false;
            }
            return true;
        }
        public bool isValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
        public bool isValidCCCD(string cccd)
        {
            if (string.IsNullOrEmpty(cccd))
            {
                return false;
            }
            if (cccd.Length != 10)
                return false;
            foreach (char s in cccd)
            {
                if (s < 48 || s > 57)
                    return false;
            }
            return true;
        }
        #endregion
        #region method
        public void LoadNhanVien()
        {
            btnXoaNV.Enabled = false;
            btnSuaNV.Enabled = false;
            txtCCCD.Enabled = true;

            listNhanVien = NhanVienDAO.Instance.getDSNhanVien();
            dgvQLNV.DataSource = listNhanVien;
            dgvQLNV.Refresh();

            cmbloainv.DataSource = LoaiNVDAO.Instance.getDSTenLoaiNV();
        }
        public void LoadLoaiNV()
        {
            btnxoaloainv.Enabled = false;
            listLoaiNV = LoaiNVDAO.Instance.getDSLoaiNV();
            dgvLoaiNV.DataSource = listLoaiNV;
            dgvLoaiNV.Refresh();
        }
        private void themLoaiNV()
        {
            string tenloai = chuanHoaChuoi(txtLoaiNV.Text);
            if (tenloai == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại mới để thêm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                LoaiNV l = new LoaiNV(tenloai);
                if (LoaiNVDAO.Instance.themLoaiNV(l) > 0)
                {
                    LoadLoaiNV();
                    MessageBox.Show("Thêm loại nhân viên mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void xoaLoaiNV()
        {
            LoaiNV l = listLoaiNV[indexLoaiNV];
            if (LoaiNVDAO.Instance.xoaLoaiNV(l.Maloainv) > 0)
            {
                LoadLoaiNV();
                MessageBox.Show("Đã xóa loại nhân viên " + l.Tenloai, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Form Event
        private void UserQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadLoaiNV();
        }
        private void btnthemloainv_Click(object sender, EventArgs e)
        {
            themLoaiNV();
        }

        private void btnxoaloainv_Click(object sender, EventArgs e)
        {
            string tenloai = listLoaiNV[indexLoaiNV].Tenloai;
            if (MessageBox.Show("Bạn có muốn xóa loại nhân viên " + tenloai + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                xoaLoaiNV();
        }

        private void dgvLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvLoaiNV.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    btnxoaloainv.Enabled = true;
                    LoaiNV l = listLoaiNV[indexRow];
                    txtLoaiNV.Text = l.Tenloai;
                    indexLoaiNV = indexRow;
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
        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvQLNV.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    btnXoaNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                    txtCCCD.Enabled = false;

                    NhanVien nv = listNhanVien[indexRow];
                    TxtTenNV.Text = nv.Tennv;
                    txtsdt.Text = nv.Sdt;
                    txtCCCD.Text = nv.CMND;
                    txtemail.Text = nv.Email;

                    indexLoaiNV = indexRow;
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
        private void btnThemNV_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}

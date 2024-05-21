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
            dgvQLNV.AutoGenerateColumns = false;
            dgvLoaiNV.AutoGenerateColumns = false;
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
            if (cccd.Length != 12)
                return false;
            foreach (char s in cccd)
            {
                if (s < 48 || s > 57)
                    return false;
            }
            return true;
        }
        public void reset()
        {
            txtCCCD.Text = txtemail.Text = txtsdt.Text = txttimnv.Text = TxtTenNV.Text = txtLoaiNV.Text = "";
            cmbloainv.SelectedIndex = 0;
            TxtTenNV.Focus();
        }
        #endregion

        #region method
        public void LoadData()
        {
            reset();
            LoadNhanVien();
            LoadLoaiNV();
        }
        public void LoadNhanVien()
        {
            btnThemNV.Enabled = true;
            btnXoaNV.Enabled = false;
            btnSuaNV.Enabled = false;
            txtCCCD.Enabled = true;

            listNhanVien = NhanVienDAO.Instance.getDSNhanVien();
            dgvQLNV.DataSource = listNhanVien;
            dgvQLNV.Refresh();

            cmbloainv.DataSource = LoaiNVDAO.Instance.getDSTenLoaiNV();
        }
        public void themNhanVien()
        {
            string ten = chuanHoaChuoi(TxtTenNV.Text);
            string email = txtemail.Text.Replace(" ", "");
            string sdt = txtsdt.Text.Replace(" ", "");
            string cccd = txtCCCD.Text.Replace(" ", "");
            int maloai = LoaiNVDAO.Instance.getIDByTenloai(cmbloainv.SelectedValue.ToString());
            if (isValidEmail(email) == false)
            {
                MessageBox.Show("Email không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isValidSoDienThoai(sdt) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isValidCCCD(cccd) == false)
            {
                MessageBox.Show("CCCD không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                NhanVien nv = new NhanVien(ten,cccd,sdt,email,maloai);
                if (NhanVienDAO.Instance.themNhanVien(nv) > 0)
                {
                    LoadData();
                    reset();
                    MessageBox.Show("Thêm nhân viên mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void suaNhanVien()
        {
            string ten = chuanHoaChuoi(TxtTenNV.Text);
            string email = txtemail.Text.Replace(" ","");
            string sdt = txtsdt.Text.Replace(" ", "");
            int maloai = LoaiNVDAO.Instance.getIDByTenloai(cmbloainv.SelectedValue.ToString());
            if (isValidEmail(email) == false)
            {
                MessageBox.Show("Email không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isValidSoDienThoai(sdt) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                NhanVien nv = listNhanVien[indexNhanVien];
                nv.Tennv = ten;
                nv.Sdt = sdt;
                nv.Email = email;
                nv.Maloainv = maloai;
                if (NhanVienDAO.Instance.suaNhanVien(nv) > 0)
                {
                    LoadData();
                    MessageBox.Show("Đã sửa thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaNhanVien()
        {
            NhanVien nv = listNhanVien[indexNhanVien];
            if (NhanVienDAO.Instance.xoaNhanVien(nv.Manv) > 0)
            {
                LoadData();
                MessageBox.Show("Đã xóa nhân viên vừa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void timNhanVien() 
        {
            btnThemNV.Enabled = true;
            btnXoaNV.Enabled = false;
            btnSuaNV.Enabled=false;
            string tennv = chuanHoaChuoi(txttimnv.Text);
            List<NhanVien> listFindNhanVien = NhanVienDAO.Instance.timNhanVienTheoTen(tennv);
            if (listFindNhanVien.Count != 0)
            {
                dgvQLNV.DataSource = listFindNhanVien;
                dgvQLNV.Refresh();
                listNhanVien = listFindNhanVien;
            }
            else
                MessageBox.Show("Không tìm thấy nhân viên có tên " + tennv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    LoadData();
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
                    btnThemNV.Enabled = false;
                    txtCCCD.Enabled = false;

                    NhanVien nv = listNhanVien[indexRow];
                    TxtTenNV.Text = nv.Tennv;
                    txtsdt.Text = nv.Sdt;
                    txtCCCD.Text = nv.CMND;
                    txtemail.Text = nv.Email;
                    cmbloainv.Text = LoaiNVDAO.Instance.getTenLoaiByID(nv.Maloainv);

                    indexNhanVien = indexRow;
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
        private void btnThemNV_Click_1(object sender, EventArgs e)
        {
            themNhanVien();
        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnSuaNV_Click_1(object sender, EventArgs e)
        {
            suaNhanVien();
        }
        private void btnXoaNV_Click_1(object sender, EventArgs e)
        {
            string tennv = listNhanVien[indexNhanVien].Tennv;
            int manv = listNhanVien[indexNhanVien].Manv;
            if (MessageBox.Show("Bạn có muốn xóa nhân viên " + tennv + " có mã nhân viên " + manv + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                xoaNhanVien();
            }
        }
        private void btnTimNV_Click(object sender, EventArgs e)
        {
            timNhanVien();
        }

        #endregion


    }
}

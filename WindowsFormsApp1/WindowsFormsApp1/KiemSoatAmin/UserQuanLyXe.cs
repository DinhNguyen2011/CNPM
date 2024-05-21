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
    public partial class UserQuanLyXe : UserControl
    {
        private List<Xe> listXe;
        private int index = -1;
        public UserQuanLyXe()
        {
            InitializeComponent();
        }
        #region Xử lý phụ
        public void reset()
        {
            txtBienSo.Text = txtSoghe.Text = txtTenXe.Text = string.Empty;
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
        private string chuanHoaBienSo(string s)
        {
            s = s.Trim();
            s = s.Replace(" ", "");
            return s;
        }
        #endregion

        #region Method
        public void LoadXe()
        {
            dgvXe.AutoGenerateColumns = false;
            btnXoaXe.Enabled = false;
            btnSuaXe.Enabled = false;
            btnThemXe.Enabled = true;
            txtBienSo.Enabled = true;
            listXe = XeDAO.Instance.getDSXe();
            dgvXe.DataSource = listXe;
            dgvXe.Refresh();
            reset();
        }
        public void themXe()
        {
            string tenxe = chuanHoaChuoi(txtTenXe.Text);
            string bienso = chuanHoaBienSo(txtBienSo.Text);
            if (tenxe == "" || bienso == "" || txtSoghe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int soghe = 0;
            try
            {
                soghe = Convert.ToInt32(txtSoghe.Text);
                Xe x = new Xe(tenxe, bienso, soghe);
                if (XeDAO.Instance.themXe(x) > 0)
                {
                    LoadXe();
                    reset();
                    MessageBox.Show("Thêm xe mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Input string was not in a correct format"))
                    MessageBox.Show("Số ghế phải là kiểu dữ số nguyên", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    throw e;
            }
        }
        public void xoaXe()
        {
            Xe x = listXe[index];
            if (XeDAO.Instance.xoaXe(x.Maxe) > 0)
            {
                LoadXe();
                reset();
                MessageBox.Show("Đã xóa xe vừa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void suaXe()
        {
            string tenxe = txtTenXe.Text.Trim();
            string bienso = txtBienSo.Text.Trim();
            if (tenxe == "" || bienso == "" || txtSoghe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bienso = bienso.Replace(" ", "");
            int soghe = 0;
            try
            {
                soghe = Convert.ToInt32(txtSoghe.Text);
                Xe x = listXe[index];
                x.Tenxe = tenxe;
                x.Soghe = soghe;
                if (XeDAO.Instance.suaXe(x) > 0)
                {
                    LoadXe();
                    reset();
                    MessageBox.Show("Đã sửa thông tin xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Input string was not in a correct format"))
                    MessageBox.Show("Số ghế phải là kiểu dữ số nguyên", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    throw e;
            }
        }
        public void timXe()
        {
            reset();
            btnXoaXe.Enabled = false;
            btnSuaXe.Enabled = false;
            btnThemXe.Enabled = false;
            string bienso = chuanHoaBienSo(txttimxe.Text);
            List<Xe> temp = new List<Xe>();
            temp = XeDAO.Instance.TimXe(bienso);
            if (temp.Count > 0)
            {
                listXe = temp;
                dgvXe.DataSource = listXe;
                dgvXe.Refresh();
            }
            else
                MessageBox.Show("Không có chiếc xe mang biển số " + bienso, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Form Event
        private void UserQuanLyXe_Load(object sender, EventArgs e)
        {
            LoadXe();
        }
        private void btnThemXe_Click(object sender, EventArgs e)
        {
            themXe();
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            suaXe();
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            string tenxe = listXe[index].Tenxe;
            if (MessageBox.Show("Bạn có muốn xóa chiếc xe " + tenxe + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                xoaXe();
        }
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvXe.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    btnXoaXe.Enabled = true;
                    btnSuaXe.Enabled = true;
                    btntimxe.Enabled = false;
                    txtBienSo.Enabled = false;
                    Xe x = listXe[indexRow];
                    txtTenXe.Text = x.Tenxe;
                    txtBienSo.Text = x.Bienso;
                    txtSoghe.Text = x.Soghe.ToString();
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
        private void btntimxe_Click(object sender, EventArgs e)
        {
            timXe();
        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadXe();
        }

        #endregion


    }
}

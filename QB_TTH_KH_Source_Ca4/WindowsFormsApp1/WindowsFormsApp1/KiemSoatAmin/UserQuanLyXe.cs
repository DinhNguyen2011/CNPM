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
        private const int SOLUONGGHE = 24;
        public UserQuanLyXe()
        {
            InitializeComponent();
            dgvXe.AutoGenerateColumns = false;
            txtSoghe.Text = SOLUONGGHE.ToString();
        }
        #region Xử lý phụ
        public void reset()
        {
            txtBienSo.Text = txtTenXe.Text = string.Empty;
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

            btnXoaXe.Enabled = false;
            btnSuaXe.Enabled = false;
            btnThemXe.Enabled = true;
            txtBienSo.ReadOnly = false;
            listXe = XeDAO.Instance.getDSXe();
            dgvXe.DataSource = listXe;
            dgvXe.Refresh();
            reset();
        }
        public void themXe()
        {
            string tenxe = chuanHoaChuoi(txtTenXe.Text);
            string bienso = chuanHoaBienSo(txtBienSo.Text);
            if (tenxe == "" || bienso == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Xe x = new Xe(tenxe, bienso, SOLUONGGHE);
                if (XeDAO.Instance.themXe(x) > 0)
                {
                    LoadXe();
                    reset();
                    MessageBox.Show("Thêm xe mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (tenxe == "")
            {
                MessageBox.Show("Vui lòng nhập tên xe mới", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Xe x = listXe[index];
                x.Tenxe = tenxe;
                if (XeDAO.Instance.suaXe(x) > 0)
                {
                    LoadXe();
                    reset();
                    MessageBox.Show("Đã sửa thông tin xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    btnThemXe.Enabled = false;
                    txtBienSo.ReadOnly = true;
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

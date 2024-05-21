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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.KiemSoatAmin
{
    public partial class UserQuanLyChuyenXe : UserControl
    {
        private List<ChuyenXe> listChuyenXe = new List<ChuyenXe>();
        private int index = 0;
        public UserQuanLyChuyenXe()
        {
            InitializeComponent();
        }

        #region Xử lý phụ
        public void reset()
        {
            txttenchuyen.Text = txtgiave.Text = "";
            dtpgiodi.Value = dtpgioden.Value  = DateTime.Now;
            cmbtaixe.SelectedIndex = 0;
            cmbtuyenxe.SelectedIndex = 0;
            txttenchuyen.Focus();
        }
        public string chuanHoaChuoi(String s)
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
        public void loadChuyenXe()
        {

            dgvChuyenXe.AutoGenerateColumns = false;
            btnXoaChuyen.Enabled = false;
            btnSuaChuyen.Enabled = false;
            btnThemChuyen.Enabled = true;
            cmbtuyenxe.Enabled = true;

            listChuyenXe = ChuyenXeDAO.Instance.getDSChuyenXe();
            dgvChuyenXe.DataSource = listChuyenXe;
            dgvChuyenXe.Refresh();

            cmbtuyenxe.DataSource = TuyenXeDAO.Instance.getDSTenTuyenXe();
            cmbtaixe.DataSource = NhanVienDAO.Instance.DSTaiXe();
            cmbbienso.DataSource = XeDAO.Instance.DSBienSo();
            cmbTimTuyenXe.DataSource = TuyenXeDAO.Instance.getDSTenTuyenXe();

            reset();
        }
        public void themchuyenxe()
        {
            string tenchuyen = chuanHoaChuoi(txttenchuyen.Text);
            if (tenchuyen == "" || txtgiave.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
                {
                    double giave = 0;
                    giave = Convert.ToDouble(txtgiave.Text);

                    string giodi = dtpgiodi.Value.ToString("yyyy-MM-dd HH:mm");
                    string gioden = dtpgioden.Value.ToString("yyyy-MM-dd HH:mm");

                    int mataixe = NhanVienDAO.Instance.getIDByTenNhanVien(cmbtaixe.SelectedValue.ToString());
                    int maxe = XeDAO.Instance.getIDByBienSo(cmbbienso.SelectedValue.ToString());

                    string tentuyenxe = cmbtuyenxe.SelectedValue.ToString();
                    string[] arr = tentuyenxe.Split('-');
                    string diemdi = arr[0].Trim();
                    string diemden = arr[1].Trim();
                    int matuyen = TuyenXeDAO.Instance.getIDByTuyenXe(diemdi, diemden);

                    ChuyenXe c = new ChuyenXe(tenchuyen,giodi,gioden,giave,matuyen,mataixe,maxe);
                    if (ChuyenXeDAO.Instance.themChuyenXe(c) > 0)
                    {
                        loadChuyenXe();
                        MessageBox.Show("Thêm chuyến xe mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Input string was not in a correct format"))
                    MessageBox.Show("Giá vé phải là kiểu dữ liệu số", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void xoaChuyenXe()
        {
            ChuyenXe c = listChuyenXe[index];
            if (ChuyenXeDAO.Instance.xoaChuyenXe(c.Machuyen) > 0)
            {
                loadChuyenXe();
                reset();
                MessageBox.Show("Đã xóa tuyến xe vừa chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void suaChuyenXe()
        {
            txttenchuyen.Text = chuanHoaChuoi(txttenchuyen.Text);
            if (txttenchuyen.Text == "" || txtgiave.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                ChuyenXe c = listChuyenXe[index];
                c.Tenchuyen = txttenchuyen.Text;
                c.Giave = Convert.ToDouble(txtgiave.Text);

                c.Giodi = dtpgiodi.Value.ToString("yyyy-MM-dd HH:mm");
                c.Gioden = dtpgioden.Value.ToString("yyyy-MM-dd HH:mm");

                c.Mataixe = NhanVienDAO.Instance.getIDByTenNhanVien(cmbtaixe.SelectedValue.ToString());
                c.Maxe = XeDAO.Instance.getIDByBienSo(cmbbienso.SelectedValue.ToString());

                if (ChuyenXeDAO.Instance.suaChuyenXe(c) > 0)
                {
                    loadChuyenXe();
                    MessageBox.Show("Đã sửa thông tin chuyến xe.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                if (e.Message.StartsWith("Input string was not in a correct format"))
                    MessageBox.Show("Giá vé phải là kiểu dữ số", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void timTuyenXe()
        {
            btnSuaChuyen.Enabled = false;
            btnXoaChuyen.Enabled = false;
            string tentuyenxe = cmbTimTuyenXe.SelectedValue.ToString();
            string[] arr = tentuyenxe.Split('-');
            string diemdi = arr[0].Trim();
            string diemden = arr[1].Trim();
            int matuyen = TuyenXeDAO.Instance.getIDByTuyenXe(diemdi, diemden);

            string giodi = dtpTimGioDi.Value.ToString("yyyy-MM-dd HH:mm");

            List<ChuyenXe> listFindChuyenXe = ChuyenXeDAO.Instance.Tim_DSChuyenXe_TheoGioDi_TenTuyen(giodi,matuyen);
            if (listFindChuyenXe.Count != 0)
            {
                //btnXoaNV.Enabled = true;
                dgvChuyenXe.DataSource = listFindChuyenXe;
                dgvChuyenXe.Refresh();
                listChuyenXe = listFindChuyenXe;
            }
            else
                MessageBox.Show("Không tìm thấy tuyến xe " + diemdi+"-"+diemden+" khởi hành lúc "+giodi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Form Event
        private void UserQuanLyChuyenXe_Load(object sender, EventArgs e)
        {
            loadChuyenXe();
        }
        private void dgvChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexRow = dgvChuyenXe.Rows[e.RowIndex].Index;
                if (indexRow > -1)
                {
                    btnXoaChuyen.Enabled = true;
                    btnSuaChuyen.Enabled = true;
                    cmbtuyenxe.Enabled = false;
                    btnThemChuyen.Enabled = false;
                    ChuyenXe c = listChuyenXe[indexRow];
                    txttenchuyen.Text = c.Tenchuyen;
                    txtgiave.Text = c.Giave.ToString();
                    dtpgiodi.Value = Convert.ToDateTime(c.Giodi);
                    dtpgioden.Value = Convert.ToDateTime(c.Gioden);
                    cmbtuyenxe.Text = TuyenXeDAO.Instance.getTenTuyenXeByID(c.Matuyen);
                    cmbtaixe.Text = NhanVienDAO.Instance.getTenNVbyID(c.Mataixe);
                    cmbbienso.Text = XeDAO.Instance.getBienSoByID(c.Maxe);

                    index = indexRow;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Index was out of range"))
                    MessageBox.Show("Đừng chọn linh tinh bạn nhé!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnHienthi_Click(object sender, EventArgs e)
        {
            loadChuyenXe();
        }

        private void btnThemChuyen_Click(object sender, EventArgs e)
        {
            themchuyenxe();
        }
        private void btnXoaChuyen_Click(object sender, EventArgs e)
        {
            string tenchuyen = listChuyenXe[index].Tenchuyen;
            int machuyen = listChuyenXe[index].Machuyen;
            if (MessageBox.Show("Bạn có muốn xóa chuyến " + tenchuyen + " có mã chuyến là " + machuyen+ " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                xoaChuyenXe();
        }
        private void btnSuaChuyen_Click(object sender, EventArgs e)
        {
            suaChuyenXe();
        }
        private void btntimchuyen_Click(object sender, EventArgs e)
        {
            timTuyenXe();
        }


        #endregion

        private void cmbtuyenxe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbtaixe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

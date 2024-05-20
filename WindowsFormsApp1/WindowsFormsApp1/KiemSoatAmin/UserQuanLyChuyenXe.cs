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
            txttenchuyen.Text = txtgiave.Text;
            dtpgiodi.Value = dtpgioden.Value = DateTime.Now;
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


            btnXoaChuyen.Enabled = false;
            btnThemChuyen.Enabled = true; ;
            dgvChuyenXe.AutoGenerateColumns = false;

            listChuyenXe = ChuyenXeDAO.Instance.getDSChuyenXe();
            dgvChuyenXe.DataSource = listChuyenXe;
            dgvChuyenXe.Refresh();

            cmbtuyenxe.DataSource = TuyenXeDAO.Instance.getDSTenTuyenXe();
            cmbtaixe.DataSource = NhanVienDAO.Instance.DSTaiXe();

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
            if (DateTime.Compare(dtpgioden.Value,dtpgiodi.Value) > 0)
            {
                try
                {
                    double giave = 0;
                    giave = Convert.ToDouble(txtgiave.Text);

                    string giodi = dtpgiodi.Value.ToString();
                    string gioden = dtpgioden.Value.ToString();

                    int mataixe = NhanVienDAO.Instance.getIDByTenNhanVien(cmbtaixe.SelectedValue.ToString());

                    string tentuyenxe = cmbtuyenxe.SelectedValue.ToString();
                    string[] arr = tentuyenxe.Split('-');
                    string diemdi = arr[0].Trim();
                    string diemden = arr[1].Trim();
                    int matuyen = TuyenXeDAO.Instance.getIDByTuyenXe(diemdi, diemden);

                    ChuyenXe c = new ChuyenXe(tenchuyen,giodi,gioden,giave,matuyen,mataixe);
                    if (ChuyenXeDAO.Instance.themChuyenXe(c) > 0)
                    {
                        loadChuyenXe();
                        MessageBox.Show("Thêm chuyến xe mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
                MessageBox.Show("Thời gian đến không được nhỏ hơn hoặc bằng thời gian đi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    ChuyenXe c = listChuyenXe[indexRow];
                    txttenchuyen.Text = c.Tenchuyen;
                    txtgiave.Text = c.Giave.ToString();
                    dtpgiodi.Value = Convert.ToDateTime(c.Giodi);
                    dtpgioden.Value = Convert.ToDateTime(c.Gioden);
                    cmbtuyenxe.Text = TuyenXeDAO.Instance.getTenTuyenXeByID(c.Matuyen);
                    cmbtaixe.Text = NhanVienDAO.Instance.getTenNVbyID(c.Mataixe);

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

        #endregion

    }
}

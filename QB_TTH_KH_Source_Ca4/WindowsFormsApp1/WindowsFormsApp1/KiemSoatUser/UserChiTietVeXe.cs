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
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1.KiemSoatUser
{


    public partial class UserChiTietVeXe : UserControl
    {

        private VeXeTam veXeTam;
        List<VeXeTam> listVe = new List<VeXeTam>();
        public UserChiTietVeXe()
        {
            InitializeComponent();
        }

        public void setValue()
        {
            
            DataTable data = DataProvider.Instance.ExcuteQuery("GETDSVE_THEOTENSDT");
            foreach (DataRow row in data.Rows)
            {
                int ma = Convert.ToInt32(row["MAVE"]);
                string tenkh = row["TENKH"].ToString().Trim();
                string sdt = row["SDTKH"].ToString().Trim();
                string giodi = row["GIODI"].ToString();
                string tuyen = row["TENVE"].ToString();
                string ghe = row["VITRIGHE"].ToString();
                string xe = row["BIENSO"].ToString();
                string trangthai = row["TRANGTHAI"].ToString();
                listVe.Add(new VeXeTam(ma, tenkh, sdt, giodi, tuyen, ghe, xe, trangthai));
            }
            
            dgvChiTietveXe.DataSource = listVe;
        }

        private void deleleTicket(int ma)
        {
            dgvChiTietveXe.DataSource = new List<VeXeTam>();
            VeXeTam vexe = listVe.FirstOrDefault(vx=>vx.Ma == ma);
            listVe.Remove(vexe);
            DataProvider.Instance.ExcuteNonQuery("HUYVEXE @mave", new object[] {ma});
            dgvChiTietveXe.DataSource = listVe;

        }
        private void dgvChiTietveXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                int ma = Convert.ToInt32(dgvChiTietveXe.Rows[e.RowIndex].Cells[1].Value);
                
                //Hủy vé
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn hủy vé?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        deleleTicket(ma);
                    return;
                }

                string nguoiDat = dgvChiTietveXe.Rows[e.RowIndex].Cells[2].Value.ToString();
                string sdt = dgvChiTietveXe.Rows[e.RowIndex].Cells[3].Value.ToString();
                string giodi = dgvChiTietveXe.Rows[e.RowIndex].Cells[4].Value.ToString();
                string tuyen = dgvChiTietveXe.Rows[e.RowIndex].Cells[5].Value.ToString();
                string ghe = dgvChiTietveXe.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                string xe = dgvChiTietveXe.Rows[e.RowIndex].Cells[7].Value.ToString().Trim();
                string trangthai = dgvChiTietveXe.Rows[e.RowIndex].Cells[8].Value.ToString();
                veXeTam = new VeXeTam(ma, nguoiDat, sdt, giodi, tuyen, ghe, xe, trangthai);
            }

        }

        private void btnChiTietVe_Click(object sender, EventArgs e)
        {
            if (veXeTam == null)
            {
                MessageBox.Show("Vui lòng chọn vé !!", "Thông báo");
                return;
            }

            FormHienThiVe ht = new FormHienThiVe(veXeTam);
            ht.ShowDialog();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            if (txtTenKH.Text=="" || txtSdt.Text=="")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !!", "Thông báo");
                return;
            }

            if (listVe.Count > 0)
            {
                List<VeXeTam> listTimKiem = new List<VeXeTam>();    
                foreach (VeXeTam vexe in listVe)
                {
                    if (vexe.TenKH.ToLower() != txtTenKH.Text.ToLower() && vexe.Sdt!=txtSdt.Text) continue;
                    VeXeTam tam = new VeXeTam(vexe.Ma, vexe.TenKH, vexe.Sdt, vexe.Giodi, vexe.Tuyen, vexe.Ghe, vexe.Xe, vexe.Trangthai);
                    listTimKiem.Add(tam);
                }    
                dgvChiTietveXe.DataSource = listTimKiem;
            }    
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenKH.Text = "";
            txtSdt.Text = "";
            dgvChiTietveXe.DataSource = listVe;
        }
    }

}

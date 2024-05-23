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
        public UserChiTietVeXe()
        {
            InitializeComponent();
        }


        //public void setValue()
        //{
        //    List<VeXeTam> listVe = new List<VeXeTam>();
        //    DataTable data = DataProvider.Instance.ExcuteQuery("TIMTHONGTINVETHEOKHACHHANG @makh", new object[] { user.Makh });
        //    foreach (DataRow row in data.Rows)
        //    {
        //        int ma = Convert.ToInt32(row["MAVE"]);
        //        string giodi = row["GIODI"].ToString();
        //        string tuyen = row["TENVE"].ToString();
        //        string ghe = row["VITRIGHE"].ToString();
        //        string xe = row["BIENSO"].ToString();
        //        string 
        //        listVe.Add(new VeXeTam(ma, nguoiDat, sdt, giodi, tuyen, ghe, xe));
        //    }


        //    dgvChiTietveXe.DataSource = listVe;
        //}

        private void dgvChiTietveXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ma = Convert.ToInt32(dgvChiTietveXe.Rows[e.RowIndex].Cells[0].Value);
                string nguoiDat = dgvChiTietveXe.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sdt = dgvChiTietveXe.Rows[e.RowIndex].Cells[2].Value.ToString();
                string giodi = dgvChiTietveXe.Rows[e.RowIndex].Cells[3].Value.ToString();
                string tuyen = dgvChiTietveXe.Rows[e.RowIndex].Cells[4].Value.ToString();
                string ghe = dgvChiTietveXe.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
                string xe = dgvChiTietveXe.Rows[e.RowIndex].Cells[6].Value.ToString().Trim();
                string trangthai = dgvChiTietveXe.Rows[e.RowIndex].Cells[7].Value.ToString();
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

        }
    }


}

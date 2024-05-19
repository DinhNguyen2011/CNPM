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

namespace WindowsFormsApp1.KiemSoatUser
{
    public partial class UserLichTrinh : UserControl
    {
        private List<LichTrinh> lichTrinhList = null;
        public UserLichTrinh()
        {
            InitializeComponent();
            lichTrinhList = LichTrinhDAO.Instance.getData();
            dgvLichTrinh.DataSource = lichTrinhList;
            cbDiemDi.DataSource = TuyenXeDAO.Instance.getDsDiemDi();
            cbDiemDen.DataSource = TuyenXeDAO.Instance.getDsDiemDen();
            cbDiemDi.SelectedIndex = -1;
            cbDiemDen.SelectedIndex = -1;
        }

        private void btnTimCXe_Click(object sender, EventArgs e)
        {
            String diemdi = cbDiemDi.SelectedValue.ToString();
            String diemden = cbDiemDen.SelectedValue.ToString(); ;
            List<LichTrinh> dsTim = lichTrinhList.FindAll(lt=>lt.DiemDi==diemdi && lt.DiemDen==diemden);
            if (dsTim.Count==0)
                MessageBox.Show(("Không có tuyến " + diemdi + " - " + diemden),"Thông báo");
            else dgvLichTrinh.DataSource = dsTim;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvLichTrinh.DataSource = lichTrinhList;
            cbDiemDi.SelectedIndex = -1;
            cbDiemDen.SelectedIndex = -1;
            cbDiemDen.StartIndex = -1;
            cbDiemDi.StartIndex = -1;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int a= cbDiemDi.SelectedIndex;
            int b= cbDiemDen.SelectedIndex;
            cbDiemDi.SelectedIndex = b;
            cbDiemDen.SelectedIndex = a;
        }
    }
}

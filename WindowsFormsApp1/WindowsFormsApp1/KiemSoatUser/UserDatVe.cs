using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.KiemSoatUser
{
    public partial class btnInc : UserControl
    {

        private LichTrinh ltSelected;
        private int num = 1;

        public LichTrinh LtSelected { get => ltSelected; set => ltSelected = value; }

        public btnInc()
        {
            ltSelected = null;
            InitializeComponent();
            txtSoVe.Text = "1";
        }

        public void setValue()
        {
            if (ltSelected != null)
            {
                txtTuyenXe.Text = ltSelected.DiemDi + " - " + ltSelected.DiemDen;
                txtGioDi.Text = ltSelected.Giodi;
                txtTongTien.Text = (Convert.ToInt16(txtSoVe.Text) * ltSelected.Giatien).ToString()+ " vnđ";
            }
        }
        private void txtSoVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoVe_TextChanged(object sender, EventArgs e)
        {
            if (txtSoVe.Text == "") return;        
            int num = Convert.ToInt32(txtSoVe.Text);
            if (num > 24) num = 24;
            if (num == 0) num = 1;
            txtSoVe.Text = num + "";
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (num < 24)
                num++;
            txtSoVe.Text = num + "";
            txtTongTien.Text = (num *ltSelected.Giatien).ToString() + " vnđ";
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (num >1) num--;
            txtTongTien.Text = (num * ltSelected.Giatien).ToString() + " vnđ";
            txtSoVe.Text = num + "";
        }
    }
}

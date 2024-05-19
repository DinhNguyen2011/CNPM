using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.KiemSoatUser
{
    public partial class btnInc : UserControl
    {
        public btnInc()
        {
            InitializeComponent();
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
            if (txtSoVe.Text == "") return;
            int num = Convert.ToInt32(txtSoVe.Text);
            if (num < 24)
                num++;
            txtSoVe.Text = num + "";
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (txtSoVe.Text == "") return;
            int num = Convert.ToInt32(txtSoVe.Text);
            if (num >1) num--;
            txtSoVe.Text = num + "";
        }
    }
}

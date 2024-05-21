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

    public partial class UserThanhToan : UserControl
    {
        public UserThanhToan()
        {
            InitializeComponent();
        }

        public void setValue(string tenNguoiGui, List<string> dsGhe, string chuyen)
        {
            txtNguoiGui.Text = tenNguoiGui;
            cbNganHang.SelectedIndex = 0;
            dtpkNgayTT.Value = DateTime.Now;
            string text = "";
            foreach (string s in dsGhe)
            {
                if (text != "") text += " - ";
                text += s;
            }
            txtSoGhe.Text = text;
            txtNoidung.Text = chuyen + " + " + text;
        }

        private void cbNganHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNganhang.Text = cbNganHang.SelectedItem.ToString();
        }
    }
}

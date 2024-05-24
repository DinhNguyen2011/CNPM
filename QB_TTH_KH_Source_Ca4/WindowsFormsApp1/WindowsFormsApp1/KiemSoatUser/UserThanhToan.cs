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

        public void setValue(string tenkh, List<String> danhsachghe, string tenchuyen, string gio)
        {
            txtNguoiGui.Text = tenkh;
            cbNganHang.SelectedIndex = 0;
            txtNganhang.Text=cbNganHang.SelectedItem.ToString();
            txtSTK.Text = "6160205071249";
            string text = "";
            foreach (string s in danhsachghe)
                text += s + " - ";
            txtSoGhe.Text = text;
            txtNoidung.Text = tenchuyen + " _ " + gio + " _ " + text;
        }
        private void cbNganHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNganhang.Text = cbNganHang.SelectedItem.ToString();
            int index = cbNganHang.SelectedIndex;
            if (index == 0)
                txtSTK.Text = "6160205071249";
            else if (index == 1)
                txtSTK.Text = "01810036136";
            else
                txtSTK.Text = "003895570009";

        }

    }
}

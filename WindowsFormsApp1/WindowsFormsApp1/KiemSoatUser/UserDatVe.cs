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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1.KiemSoatUser
{
    public partial class btnInc : UserControl
    {

        private LichTrinh ltSelected;
        private List<String> dsGhe;
        private int num = 1;
        private int slVeDaChon = 0;

        public LichTrinh LtSelected {set => ltSelected = value; }
        public List<string> DanhSachGhe { get => dsGhe;}

        public btnInc()
        {
            ltSelected = null;
            dsGhe = new List<String>();
            InitializeComponent();
            txtSoVe.Text = "1";
        }

        public void setValue()
        {
            if (ltSelected != null)
            {
                txtTuyenXe.Text = ltSelected.DiemDi + " - " + ltSelected.DiemDen;
                txtGioDi.Text = ltSelected.Giodi;
                txtTongTien.Text = (num * ltSelected.Giatien).ToString()+ " vnđ";
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
            if (txtSoVe.Text == "")
            {
                num = 1;
                txtTongTien.Text = ltSelected.Giatien.ToString() + " vnđ";
                return;
            } 
                
            int sl = Convert.ToInt32(txtSoVe.Text);
            if (sl < slVeDaChon)
            {
                MessageBox.Show("Vui lòng hủy bớt ghế đã chọn", "Thông báo");
                num = slVeDaChon;
                txtSoVe.Text = num + "";
                txtTongTien.Text = (num * ltSelected.Giatien).ToString() + " vnđ";
                return;
            }
            if (sl > 24) sl = 24;
            if (sl == 0) sl = 1;
            num = sl;
            txtSoVe.Text = sl + "";
            if (ltSelected != null) 
                txtTongTien.Text = (num * ltSelected.Giatien).ToString() + " vnđ";
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
            if (num == 1) return;
            if (slVeDaChon == num )
            {
                MessageBox.Show("Vui lòng hủy bớt vé đã chọn", "Thông báo");
                return;
            }
            num--;
            txtTongTien.Text = (num * ltSelected.Giatien).ToString() + " vnđ";
            txtSoVe.Text = num + "";
        }

        private void txtSoVe_Leave(object sender, EventArgs e)
        {
            if (txtSoVe.Text == "") txtSoVe.Text = "1";
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("A1");
                btnA1.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("A1");
                btnA1.BackColor = Color.Cyan;
            } 
                
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            
            if (btnB1.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("B1");
                btnB1.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("B1");
                btnB1.BackColor = Color.Cyan;
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("C1");
                btnC1.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("C1");
                btnC1.BackColor = Color.Cyan;
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("A2");
                btnA2.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("A2");
                btnA2.BackColor = Color.Cyan;
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("B2");
                btnB2.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("B2");
                btnB2.BackColor = Color.Cyan;
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("C2");
                btnC2.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("C2");
                btnC2.BackColor = Color.Cyan;
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("A3");
                btnA3.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("A3");
                btnA3.BackColor = Color.Cyan;
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("B3");
                btnB3.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("B3");
                btnB3.BackColor = Color.Cyan;
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("C3");
                btnC3.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("C3");
                btnC3.BackColor = Color.Cyan;
            }
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (btnA4.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("A4");
                btnA4.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("A4");
                btnA4.BackColor = Color.Cyan;
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (btnB4.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("B4");
                btnB4.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("B4");
                btnB4.BackColor = Color.Cyan;
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (btnC4.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("C4");
                btnC4.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("C4");
                btnC4.BackColor = Color.Cyan;
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (btnA5.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("A5");
                btnA5.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("A5");
                btnA5.BackColor = Color.Cyan;
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (btnB5.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("B5");
                btnB5.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("B5");
                btnB5.BackColor = Color.Cyan;
            }
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (btnC5.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("C5");
                btnC5.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("C5");
                btnC5.BackColor = Color.Cyan;
            }
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if (btnA6.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("A6");
                btnA6.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("A6");
                btnA6.BackColor = Color.Cyan;
            }
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (btnB6.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("B6");
                btnB6.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("B6");
                btnB6.BackColor = Color.Cyan;
            }
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            if (btnC6.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("C6");
                btnC6.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("C6");
                btnC6.BackColor = Color.Cyan;
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (btnD1.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("D1");
                btnD1.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("D1");
                btnD1.BackColor = Color.Cyan;
            }
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            if (btnD3.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("D3");
                btnD3.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("D3");
                btnD3.BackColor = Color.Cyan;
            }
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            if (btnD5.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("D5");
                btnD5.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("D5");
                btnD5.BackColor = Color.Cyan;
            }
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            if (btnD2.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("D2");
                btnD2.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("D2");
                btnD2.BackColor = Color.Cyan;
            }
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            if (btnD4.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("D4");
                btnD4.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("D4");
                btnD4.BackColor = Color.Cyan;
            }
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            if (btnD6.BackColor == Color.Cyan)
            {
                if (slVeDaChon == num) return;
                slVeDaChon++;
                dsGhe.Add("D6");
                btnD6.BackColor = Color.Crimson;
            }
            else
            {
                slVeDaChon--;
                dsGhe.Remove("D6");
                btnD6.BackColor = Color.Cyan;
            }
        }

        
    }
}

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
    public partial class btnTam : UserControl
    {

        private LichTrinh lichTrinhSelected;
        private List<String> dsGhe;
        private int max = 0;
        private int slVe = 1;
        private int slVeDaChon = 0;

        public LichTrinh LtSelected {set => lichTrinhSelected = value; }
        public List<string> DanhSachGhe { get => dsGhe; set => dsGhe = value; }
        public int SlVeDaChon { get => slVeDaChon;}
        public int SlVe { get => slVe;}
        public int Max {set => max = value; }

        public btnTam()
        {
            lichTrinhSelected = null;
            dsGhe = new List<String>();
            InitializeComponent();
            txtSoVe.Text = "1";
        }

        public void setValue()
        {
            if (lichTrinhSelected != null)
            {
                txtTuyenXe.Text = lichTrinhSelected.DiemDi + " - " + lichTrinhSelected.DiemDen;
                txtGioDi.Text = lichTrinhSelected.Giodi;
                txtTongTien.Text = (slVe * lichTrinhSelected.Giatien).ToString()+ " vnđ";
            }

            //enable ghế
            foreach (string s in dsGhe)
            {
                if (s == "A1")
                {
                    btnA1.Enabled = false;
                    btnA1.BackColor = Color.WhiteSmoke;
                } 
                    
                else if (s == "A2")
                {
                    btnA2.Enabled = false;
                    btnA2.BackColor = Color.WhiteSmoke;
                }
                else if (s == "A3")
                {
                    btnA3.Enabled = false;
                    btnA3.BackColor = Color.WhiteSmoke;
                }
                else if (s == "A4")
                {
                    btnA4.Enabled = false;
                    btnA4.BackColor = Color.WhiteSmoke;
                }
                else if (s == "A5")
                {
                    btnA5.Enabled = false;
                    btnA5.BackColor = Color.WhiteSmoke;
                }
                else if (s == "A6")
                {
                    btnA6.Enabled = false;
                    btnA6.BackColor = Color.WhiteSmoke;
                }

                else if (s == "B1")
                {
                    btnB1.Enabled = false;
                    btnB1.BackColor = Color.WhiteSmoke;
                }
                else if (s == "B2")
                {
                    btnB2.Enabled = false;
                    btnB2.BackColor = Color.WhiteSmoke;
                }
                else if (s == "B3")
                {
                    btnB3.Enabled = false;
                    btnB3.BackColor = Color.WhiteSmoke;
                }
                else if (s == "B4")
                {
                    btnB4.Enabled = false;
                    btnB4.BackColor = Color.WhiteSmoke;
                }
                else if (s == "B5")
                {
                    btnB5.Enabled = false;
                    btnB5.BackColor = Color.WhiteSmoke;
                }
                else if (s == "B6")
                {
                    btnB6.Enabled = false;
                    btnB6.BackColor = Color.WhiteSmoke;
                }

                else if (s == "C1")
                {
                    btnC1.Enabled = false;
                    btnC1.BackColor = Color.WhiteSmoke;
                }
                else if (s == "C2")
                {
                    btnC2.Enabled = false;
                    btnC2.BackColor = Color.WhiteSmoke;
                }
                else if (s == "C3")
                {
                    btnC3.Enabled = false;
                    btnC3.BackColor = Color.WhiteSmoke;
                }
                else if (s == "C4")
                {
                    btnC4.Enabled = false;
                    btnC4.BackColor = Color.WhiteSmoke;
                }
                else if (s == "C5")
                {
                    btnC5.Enabled = false;
                    btnC5.BackColor = Color.WhiteSmoke;
                }
                else if (s == "C6")
                {
                    btnC6.Enabled = false;
                    btnC6.BackColor = Color.WhiteSmoke;
                }

                else if (s == "D1")
                {
                    btnD1.Enabled = false;
                    btnD1.BackColor = Color.WhiteSmoke;
                }
                else if (s == "D2")
                {
                    btnD2.Enabled = false;
                    btnD2.BackColor = Color.WhiteSmoke;
                }
                else if (s == "D3")
                {
                    btnD3.Enabled = false;
                    btnD3.BackColor = Color.WhiteSmoke;
                }
                else if (s == "D4")
                {
                    btnD4.Enabled = false;
                    btnD4.BackColor = Color.WhiteSmoke;
                }
                else if (s == "D5")
                {
                    btnD5.Enabled = false;
                    btnD5.BackColor = Color.WhiteSmoke;
                }
                else if (s == "D6")
                {
                    btnD6.Enabled = false;
                    btnD6.BackColor = Color.WhiteSmoke;
                }

            }


            dsGhe = new List<String>();
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
                slVe = 1;
                txtTongTien.Text = lichTrinhSelected.Giatien.ToString() + " vnđ";
                return;
            } 
                
            int sl = Convert.ToInt32(txtSoVe.Text);
            if (sl > max) sl = max;
            if (sl == 0) sl = 1;
            slVe = sl;
            txtSoVe.Text = sl + "";
            if (lichTrinhSelected!=null)
                txtTongTien.Text = (slVe * lichTrinhSelected.Giatien).ToString() + " vnđ";
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (slVe < max)
                slVe++;
            txtSoVe.Text = slVe + "";
            txtTongTien.Text = (slVe *lichTrinhSelected.Giatien).ToString() + " vnđ";
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (slVe == 1) return;
            if (slVeDaChon == slVe )
            {
                MessageBox.Show("Vui lòng hủy bớt vé đã chọn", "Thông báo");
                return;
            }
            slVe--;
            txtTongTien.Text = (slVe * lichTrinhSelected.Giatien).ToString() + " vnđ";
            txtSoVe.Text = slVe + "";
        }

        private void txtSoVe_Leave(object sender, EventArgs e)
        {
            if (txtSoVe.Text == "")
            {
                txtSoVe.Text = "1";
                slVe = 1;
                txtTongTien.Text = lichTrinhSelected.Giatien.ToString() + " vnđ";
                return;
            }

            int sl = Convert.ToInt32(txtSoVe.Text);
            if (sl < slVeDaChon)
            {
                MessageBox.Show("Vui lòng hủy bớt ghế đã chọn", "Thông báo");
                slVe = slVeDaChon;
                txtSoVe.Text = slVe + "";
                txtTongTien.Text = (slVe * lichTrinhSelected.Giatien).ToString() + " vnđ";
                return;
            }
            if (sl > max) sl = max;
            if (sl == 0) sl = 1;
            slVe = sl;
            txtSoVe.Text = sl + "";
            if (lichTrinhSelected != null)
                txtTongTien.Text = (slVe * lichTrinhSelected.Giatien).ToString() + " vnđ";
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.BackColor == Color.Cyan)
            {
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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
                if (slVeDaChon == slVe) return;
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

        private void btnInc_Click(object sender, EventArgs e)
        {
            btnA1.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.KiemSoatUser;

namespace WindowsFormsApp1.GUI
{
    public partial class FormHienThiVe : Form
    {
        public FormHienThiVe(DTO.VeXeTam veXe)
        {
            InitializeComponent();
            txtMa.Text = veXe.Ma.ToString();
            txtNguoiDat.Text = veXe.TenKH;
            txtSDT.Text = veXe.Sdt;
            txtTuyen.Text = veXe.Tuyen;
            txtGio.Text = veXe.Giodi;
            txtXe.Text = veXe.Xe;
            txtGhe.Text = veXe.Ghe;
            txtTrangthai.Text = veXe.Trangthai;
        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, 850);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, 874));
            bitmap.Save("../../../../Ticket/"+txtMa.Text+".png");
            MessageBox.Show("Xuất vé thành công", "Thông báo");
            return;
        }
    }
}

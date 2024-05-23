using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class BangDieuKhien : Form
    {
        private int index = 0;
        private int tabIndex = 0;
        private NhanVien user;
        private KhachHang custumer;
        private int slVe = 0;
        private List<String> dsGhe = new List<string>();
        private LichTrinh chuyendi = new LichTrinh();
        public BangDieuKhien(NhanVien data)
        {
            this.user = data;
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void BangDieuKhien_Load(object sender, EventArgs e)
        {
            userDatVe1.Visible = false;
            userProfile1.Visible = false;
            userLichTrinh1.Visible = false;
            userThanhToan1.Visible = false;
            userChiTietVeXe1.Visible = false;
            lbHello.Text = "Hello, " + user.Tennv + " !!";
            chonLichTrinh();
            CenterForm();
        }

        private void CenterForm()
        {
            guna2Panel1.Location = new Point(
            ClientSize.Width / 2 - guna2Panel1.Size.Width / 2,
            ClientSize.Height / 2 - guna2Panel1.Size.Height / 2);
            guna2Panel1.Anchor = AnchorStyles.None;
        }

        private void resetColorOfTitlePage()
        {
            btnTrangChu.FillColor = Color.RoyalBlue;

            if (index > 0)
                btnChonVe.FillColor = Color.RoyalBlue;
            else
                btnChonVe.FillColor = Color.Cyan;

            if (index > 1)
                btnThongTinKH.FillColor = Color.RoyalBlue;
            else
                btnThongTinKH.FillColor = Color.Cyan;

            if (index > 2)
                btnThanhToan.FillColor = Color.RoyalBlue;
            else
                btnThanhToan.FillColor = Color.Cyan;

            btnKiemTraVe.FillColor = Color.RoyalBlue;
        }


        private void chonThongTinVe(LichTrinh selected)
        {

            if (selected != null)
            {
                userDatVe1.LtSelected = selected;
                List<String> danhSachGheDaChon = new List<String>();
                DataProvider dtp = new DataProvider();
                DataTable dt = new DataTable();
                string query = "DSGHEDACHON @machuyen";
                dt = dtp.ExcuteQuery(query, new object[] { selected.Ma });
                foreach (DataRow row in dt.Rows)
                    danhSachGheDaChon.Add(row[0].ToString().Trim());
                if (danhSachGheDaChon.Count == 24)
                {
                    MessageBox.Show("Chuyến " + selected.DiemDi + " - " + selected.DiemDen + " vào lúc " + selected.Giodi + " đã hết vé, vui lòng chọn lại !!", "Thông báo");
                    selected = null;
                    return;
                }
                userDatVe1.Max = 24 - danhSachGheDaChon.Count;
                userDatVe1.DanhSachGhe = danhSachGheDaChon;
            }
            tabIndex = 1;
            index = tabIndex;
            PnMoving.Left = btnChonChuyen.Left + 50;
            userDatVe1.setValue();
            userDatVe1.Visible = true;
            userDatVe1.BringToFront();
            btnXacNhanVe.BringToFront();
            resetColorOfTitlePage();
            btnChonVe.FillColor = Color.FromArgb(0, 192, 0);
        }


        private void nhapThongTinKhachHang()
        {
            tabIndex = 2;
            if (index<tabIndex) index = tabIndex;
            PnMoving.Left = btnThongTinKH.Left + 55;
            userProfile1.Visible = true;
            userProfile1.BringToFront();
            btnXacNhanKH.BringToFront();
            resetColorOfTitlePage();
            btnThongTinKH.FillColor = Color.FromArgb(0, 192, 0);
        }

        private void chonLichTrinh()
        {
            tabIndex = 0;
            if (index < tabIndex) index = tabIndex;
            PnMoving.Left = btnTrangChu.Left + 60;
            userLichTrinh1.Visible = true;
            userLichTrinh1.BringToFront();
            btnChonChuyen.BringToFront();
            resetColorOfTitlePage();
            btnTrangChu.FillColor = Color.FromArgb(0, 192, 0);
        }


        private void thanhToan()
        {
            
            tabIndex = 3;
            index = tabIndex;
            PnMoving.Left = btnThanhToan.Left + 60;
            userThanhToan1.Visible = true;
            userThanhToan1.BringToFront();
            btnThanhToan2.BringToFront();
            resetColorOfTitlePage();
            btnThanhToan.FillColor = Color.FromArgb(0, 192, 0);
        }
        private void kiemTraVe()
        {
            tabIndex = 4;
            PnMoving.Left = btnKiemTraVe.Left + 60;
            userChiTietVeXe1.Visible = true;
            userChiTietVeXe1.BringToFront();
            resetColorOfTitlePage();
            btnKiemTraVe.FillColor = Color.FromArgb(0, 192, 0);
        }

        
        private void LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (tabIndex > 0 && tabIndex != 4)
            {
                if (MessageBox.Show("Bạn sẽ phải bắt đầu lại từ bước này?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    return;
            }
            chonLichTrinh();
        }

        private void btnChonVe_Click(object sender, EventArgs e)
        {
            if (index < 1) return;
            if (tabIndex == 4) chonThongTinVe(null);
            else if (tabIndex > 1)
            {
                if (MessageBox.Show("Bạn sẽ phải bắt đầu lại từ bước này?", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    chonThongTinVe(null);
            }
        }

        private void btnThongTinKH_Click(object sender, EventArgs e)
        {
            if (index < 2) return;
            nhapThongTinKhachHang();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (index < 3) return;
            thanhToan();
       
        }

        private void btnKiemTraVe_Click(object sender, EventArgs e)
        {
            kiemTraVe();
        }
        private void btnChonChuyen_Click(object sender, EventArgs e)
        {

            LichTrinh selected = userLichTrinh1.Selected;

            if (selected != null)
            {
                if (MessageBox.Show("Chuyến " + selected.DiemDi + " - " + selected.DiemDen + " vào lúc " + selected.Giodi, "Xác nhận lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    chuyendi = selected;
                    chonThongTinVe(selected);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn chuyến đi !!", "Thông báo");


        }
        private void btnXacNhanVe_Click(object sender, EventArgs e)
        {
            int soVe = userDatVe1.SlVe;
            int soVeDaChon = userDatVe1.SlVeDaChon;
            if (soVe == soVeDaChon)
            {
                slVe = soVe;
                dsGhe = userDatVe1.DanhSachGhe;
                dsGhe.Sort();
                nhapThongTinKhachHang();
            }
            else MessageBox.Show("Vui lòng chọn thêm " + (soVe - soVeDaChon) + " ghế !!", "Thông báo");

        }

        private void btnXacNhanKH_Click(object sender, EventArgs e)
        {
            custumer = userProfile1.Custumer;
            if (custumer.Tenkh=="" || custumer.Ghichu=="")
                MessageBox.Show("Hãy điền đầy đủ thông tin tối thiếu (tên, liên lạc, ghi chú) !!", "Thông báo");
            else
            {
                userThanhToan1.setValue(custumer.Tenkh, dsGhe, chuyendi.DiemDi+" - "+chuyendi.DiemDen,chuyendi.Giodi);
                thanhToan();
                
            }
        }

        private void btnThanhToan2_Click(object sender, EventArgs e)
        {
            DataProvider dtp = new DataProvider();
            string tenve = chuyendi.DiemDi + " - " + chuyendi.DiemDen;
            foreach (string ghe in dsGhe)
            {
                string query = "THEMVE @tenve , @ghichu , @tenkh , @sdtkh , @machuyen , @manv , @ghe  , @trangthai ";
                dtp.ExcuteQuery(query, new object[] { tenve, custumer.Ghichu, custumer.Tenkh, custumer.Sdt ,chuyendi.Ma, user.Manv, ghe, "Đã thanh toán" });
            }
            MessageBox.Show("Đã thêm vé thành công !!", "Thông báo");
            this.Close();
            BangDieuKhien newForm = new BangDieuKhien(user);
            newForm.ShowDialog();
            
        }
    }
}

namespace WindowsFormsApp1
{
    partial class BangDieuKhien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDieuKhien));
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMiniSize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTinKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnKiemTraVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.btnChonChuyen = new Guna.UI2.WinForms.Guna2Button();
            this.PnMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXacNhanKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhanVe = new Guna.UI2.WinForms.Guna2Button();
            this.userLichTrinh1 = new WindowsFormsApp1.KiemSoatUser.UserLichTrinh();
            this.userProfile1 = new WindowsFormsApp1.KiemSoatUser.UserProfile();
            this.userChiTietVeXe1 = new WindowsFormsApp1.KiemSoatUser.UserChiTietVeXe();
            this.userThanhToan1 = new WindowsFormsApp1.KiemSoatUser.UserThanhToan();
            this.userDatVe1 = new WindowsFormsApp1.KiemSoatUser.btnInc();
            this.guna2ElipseDatVe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseProfile = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseTimKiem = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseThanhToan = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseCTVeXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(2061, 336);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiniSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiniSize.FillColor = System.Drawing.Color.White;
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiniSize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMiniSize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniSize.Image")));
            this.btnMiniSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMiniSize.Location = new System.Drawing.Point(2003, 336);
            this.btnMiniSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(45, 48);
            this.btnMiniSize.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChonVe);
            this.panel1.Controls.Add(this.btnThongTinKH);
            this.panel1.Controls.Add(this.btnKiemTraVe);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnTrangChu);
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(556, 336);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1362, 110);
            this.panel1.TabIndex = 2;
            // 
            // btnChonVe
            // 
            this.btnChonVe.BorderRadius = 18;
            this.btnChonVe.BorderThickness = 2;
            this.btnChonVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChonVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonVe.FillColor = System.Drawing.Color.Cyan;
            this.btnChonVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonVe.ForeColor = System.Drawing.Color.White;
            this.btnChonVe.Location = new System.Drawing.Point(300, 20);
            this.btnChonVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonVe.Name = "btnChonVe";
            this.btnChonVe.Size = new System.Drawing.Size(230, 69);
            this.btnChonVe.TabIndex = 5;
            this.btnChonVe.Text = "Chọn vé";
            this.btnChonVe.Click += new System.EventHandler(this.btnChonVe_Click);
            // 
            // btnThongTinKH
            // 
            this.btnThongTinKH.BorderRadius = 18;
            this.btnThongTinKH.BorderThickness = 2;
            this.btnThongTinKH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTinKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTinKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTinKH.FillColor = System.Drawing.Color.Cyan;
            this.btnThongTinKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinKH.ForeColor = System.Drawing.Color.White;
            this.btnThongTinKH.Location = new System.Drawing.Point(566, 20);
            this.btnThongTinKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongTinKH.Name = "btnThongTinKH";
            this.btnThongTinKH.Size = new System.Drawing.Size(230, 69);
            this.btnThongTinKH.TabIndex = 4;
            this.btnThongTinKH.Text = "Điền thông tin";
            this.btnThongTinKH.Click += new System.EventHandler(this.btnThongTinKH_Click);
            // 
            // btnKiemTraVe
            // 
            this.btnKiemTraVe.BorderRadius = 18;
            this.btnKiemTraVe.BorderThickness = 2;
            this.btnKiemTraVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKiemTraVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKiemTraVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKiemTraVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKiemTraVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKiemTraVe.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnKiemTraVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTraVe.ForeColor = System.Drawing.Color.White;
            this.btnKiemTraVe.Location = new System.Drawing.Point(1097, 20);
            this.btnKiemTraVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKiemTraVe.Name = "btnKiemTraVe";
            this.btnKiemTraVe.Size = new System.Drawing.Size(230, 69);
            this.btnKiemTraVe.TabIndex = 3;
            this.btnKiemTraVe.Text = "Kiểm tra vé";
            this.btnKiemTraVe.Click += new System.EventHandler(this.btnKiemTraVe_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 18;
            this.btnThanhToan.BorderThickness = 2;
            this.btnThanhToan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.Cyan;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(831, 20);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(230, 69);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BorderRadius = 18;
            this.btnTrangChu.BorderThickness = 2;
            this.btnTrangChu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangChu.FillColor = System.Drawing.Color.Cyan;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.White;
            this.btnTrangChu.Location = new System.Drawing.Point(35, 20);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(230, 69);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnChonChuyen
            // 
            this.btnChonChuyen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChonChuyen.BorderRadius = 18;
            this.btnChonChuyen.BorderThickness = 2;
            this.btnChonChuyen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChonChuyen.CustomBorderColor = System.Drawing.Color.White;
            this.btnChonChuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChonChuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChonChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChonChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChonChuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChonChuyen.FocusedColor = System.Drawing.Color.White;
            this.btnChonChuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnChonChuyen.ForeColor = System.Drawing.Color.Black;
            this.btnChonChuyen.Location = new System.Drawing.Point(1361, 644);
            this.btnChonChuyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonChuyen.Name = "btnChonChuyen";
            this.btnChonChuyen.Size = new System.Drawing.Size(227, 69);
            this.btnChonChuyen.TabIndex = 5;
            this.btnChonChuyen.Text = "Chọn chuyến";
            this.btnChonChuyen.Click += new System.EventHandler(this.btnChonChuyen_Click);
            // 
            // PnMoving
            // 
            this.PnMoving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PnMoving.Location = new System.Drawing.Point(486, 479);
            this.PnMoving.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnMoving.Name = "PnMoving";
            this.PnMoving.Size = new System.Drawing.Size(225, 11);
            this.PnMoving.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXacNhanKH);
            this.panel2.Controls.Add(this.btnXacNhanVe);
            this.panel2.Controls.Add(this.userLichTrinh1);
            this.panel2.Controls.Add(this.userProfile1);
            this.panel2.Controls.Add(this.userChiTietVeXe1);
            this.panel2.Controls.Add(this.userThanhToan1);
            this.panel2.Controls.Add(this.btnChonChuyen);
            this.panel2.Controls.Add(this.userDatVe1);
            this.panel2.Location = new System.Drawing.Point(448, 499);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1658, 869);
            this.panel2.TabIndex = 3;
            // 
            // btnXacNhanKH
            // 
            this.btnXacNhanKH.BorderRadius = 18;
            this.btnXacNhanKH.BorderThickness = 2;
            this.btnXacNhanKH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnXacNhanKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhanKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhanKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXacNhanKH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanKH.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhanKH.Location = new System.Drawing.Point(1112, 710);
            this.btnXacNhanKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXacNhanKH.Name = "btnXacNhanKH";
            this.btnXacNhanKH.Size = new System.Drawing.Size(270, 69);
            this.btnXacNhanKH.TabIndex = 6;
            this.btnXacNhanKH.Text = "Xác nhận";
            this.btnXacNhanKH.Click += new System.EventHandler(this.btnXacNhanKH_Click);
            // 
            // btnXacNhanVe
            // 
            this.btnXacNhanVe.BorderRadius = 18;
            this.btnXacNhanVe.BorderThickness = 2;
            this.btnXacNhanVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnXacNhanVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhanVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhanVe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXacNhanVe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanVe.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhanVe.Location = new System.Drawing.Point(1316, 69);
            this.btnXacNhanVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXacNhanVe.Name = "btnXacNhanVe";
            this.btnXacNhanVe.Size = new System.Drawing.Size(270, 69);
            this.btnXacNhanVe.TabIndex = 5;
            this.btnXacNhanVe.Text = "Đặt vé";
            this.btnXacNhanVe.Click += new System.EventHandler(this.btnXacNhanVe_Click);
            // 
            // userLichTrinh1
            // 
            this.userLichTrinh1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userLichTrinh1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userLichTrinh1.Location = new System.Drawing.Point(22, 22);
            this.userLichTrinh1.Margin = new System.Windows.Forms.Padding(0);
            this.userLichTrinh1.Name = "userLichTrinh1";
            this.userLichTrinh1.Size = new System.Drawing.Size(1597, 820);
            this.userLichTrinh1.TabIndex = 2;
            // 
            // userProfile1
            // 
            this.userProfile1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userProfile1.Location = new System.Drawing.Point(22, 22);
            this.userProfile1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userProfile1.Name = "userProfile1";
            this.userProfile1.Size = new System.Drawing.Size(1600, 820);
            this.userProfile1.TabIndex = 1;
            // 
            // userChiTietVeXe1
            // 
            this.userChiTietVeXe1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userChiTietVeXe1.Location = new System.Drawing.Point(22, 22);
            this.userChiTietVeXe1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userChiTietVeXe1.Name = "userChiTietVeXe1";
            this.userChiTietVeXe1.Size = new System.Drawing.Size(1600, 820);
            this.userChiTietVeXe1.TabIndex = 4;
            // 
            // userThanhToan1
            // 
            this.userThanhToan1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userThanhToan1.Location = new System.Drawing.Point(22, 22);
            this.userThanhToan1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userThanhToan1.Name = "userThanhToan1";
            this.userThanhToan1.Size = new System.Drawing.Size(1600, 820);
            this.userThanhToan1.TabIndex = 3;
            // 
            // userDatVe1
            // 
            this.userDatVe1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userDatVe1.Location = new System.Drawing.Point(22, 22);
            this.userDatVe1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userDatVe1.Name = "userDatVe1";
            this.userDatVe1.Size = new System.Drawing.Size(1600, 800);
            this.userDatVe1.TabIndex = 0;
            // 
            // guna2ElipseDatVe
            // 
            this.guna2ElipseDatVe.TargetControl = this;
            // 
            // guna2ElipseProfile
            // 
            this.guna2ElipseProfile.TargetControl = this;
            // 
            // guna2ElipseTimKiem
            // 
            this.guna2ElipseTimKiem.TargetControl = this;
            // 
            // guna2ElipseThanhToan
            // 
            this.guna2ElipseThanhToan.TargetControl = this;
            // 
            // guna2ElipseCTVeXe
            // 
            this.guna2ElipseCTVeXe.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(448, 336);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(70, 63);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // BangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2586, 1626);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.PnMoving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BangDieuKhien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt vé xe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BangDieuKhien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMiniSize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnChonChuyen;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnKiemTraVe;
        private Guna.UI2.WinForms.Guna2Button btnThongTinKH;
        private Guna.UI2.WinForms.Guna2Panel PnMoving;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseDatVe;
        private KiemSoatUser.btnInc userDatVe1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseProfile;
        private KiemSoatUser.UserProfile userProfile1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseTimKiem;
        private KiemSoatUser.UserLichTrinh userLichTrinh1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseThanhToan;
        private KiemSoatUser.UserThanhToan userThanhToan1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseCTVeXe;
        private KiemSoatUser.UserChiTietVeXe userChiTietVeXe1;
        private Guna.UI2.WinForms.Guna2Button btnXacNhanVe;
        private Guna.UI2.WinForms.Guna2Button btnXacNhanKH;
        private Guna.UI2.WinForms.Guna2Button btnChonVe;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        // private KiemSoatUser.UserChiTietVeXe userCTVeXe1;
    }
}
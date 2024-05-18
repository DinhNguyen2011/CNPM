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
            this.btnThongTinKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTietVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichTrinh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatVe = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userLichTrinh1 = new WindowsFormsApp1.KiemSoatUser.UserLichTrinh();
            this.userProfile1 = new WindowsFormsApp1.KiemSoatUser.UserProfile();
            this.userChiTietVeXe1 = new WindowsFormsApp1.KiemSoatUser.UserChiTietVeXe();
            this.userThanhToan1 = new WindowsFormsApp1.KiemSoatUser.UserThanhToan();
            this.userDatVe1 = new WindowsFormsApp1.KiemSoatUser.UserDatVe();
            this.guna2ElipseDatVe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseProfile = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseTimKiem = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseThanhToan = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ElipseCTVeXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LogOut = new Guna.UI2.WinForms.Guna2Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
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
            this.btnClose.FillColor = System.Drawing.SystemColors.Control;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(2034, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 57);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiniSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiniSize.FillColor = System.Drawing.SystemColors.Control;
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiniSize.ForeColor = System.Drawing.Color.White;
            this.btnMiniSize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniSize.Image")));
            this.btnMiniSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMiniSize.Location = new System.Drawing.Point(1960, 7);
            this.btnMiniSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(66, 57);
            this.btnMiniSize.TabIndex = 1;
            this.btnMiniSize.Click += new System.EventHandler(this.btnMiniSize_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnThongTinKH);
            this.panel1.Controls.Add(this.btnChiTietVe);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnLichTrinh);
            this.panel1.Controls.Add(this.btnDatVe);
            this.panel1.Location = new System.Drawing.Point(180, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1746, 198);
            this.panel1.TabIndex = 2;
            // 
            // btnThongTinKH
            // 
            this.btnThongTinKH.BorderRadius = 18;
            this.btnThongTinKH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTinKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTinKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTinKH.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnThongTinKH.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinKH.ForeColor = System.Drawing.Color.Black;
            this.btnThongTinKH.Location = new System.Drawing.Point(743, 45);
            this.btnThongTinKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongTinKH.Name = "btnThongTinKH";
            this.btnThongTinKH.Size = new System.Drawing.Size(255, 102);
            this.btnThongTinKH.TabIndex = 4;
            this.btnThongTinKH.Text = "Thông tin hành khách";
            this.btnThongTinKH.Click += new System.EventHandler(this.btnThongTinKH_Click);
            // 
            // btnChiTietVe
            // 
            this.btnChiTietVe.BorderRadius = 18;
            this.btnChiTietVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChiTietVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTietVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTietVe.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnChiTietVe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietVe.ForeColor = System.Drawing.Color.Black;
            this.btnChiTietVe.Location = new System.Drawing.Point(1401, 45);
            this.btnChiTietVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChiTietVe.Name = "btnChiTietVe";
            this.btnChiTietVe.Size = new System.Drawing.Size(255, 102);
            this.btnChiTietVe.TabIndex = 3;
            this.btnChiTietVe.Text = "Chi Tiết Vé Xe";
            this.btnChiTietVe.Click += new System.EventHandler(this.btnChiTietVe_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 18;
            this.btnThanhToan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(1077, 45);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(255, 102);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLichTrinh
            // 
            this.btnLichTrinh.BorderRadius = 18;
            this.btnLichTrinh.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLichTrinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichTrinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichTrinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichTrinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichTrinh.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnLichTrinh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichTrinh.ForeColor = System.Drawing.Color.Black;
            this.btnLichTrinh.Location = new System.Drawing.Point(84, 45);
            this.btnLichTrinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLichTrinh.Name = "btnLichTrinh";
            this.btnLichTrinh.Size = new System.Drawing.Size(255, 102);
            this.btnLichTrinh.TabIndex = 1;
            this.btnLichTrinh.Text = "Lịch trình";
            this.btnLichTrinh.Click += new System.EventHandler(this.btnLichTrinh_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BorderRadius = 18;
            this.btnDatVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDatVe.CustomBorderColor = System.Drawing.Color.White;
            this.btnDatVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatVe.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDatVe.FocusedColor = System.Drawing.Color.White;
            this.btnDatVe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.ForeColor = System.Drawing.Color.Black;
            this.btnDatVe.Location = new System.Drawing.Point(409, 45);
            this.btnDatVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(255, 102);
            this.btnDatVe.TabIndex = 0;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.userLichTrinh1);
            this.panel2.Controls.Add(this.userProfile1);
            this.panel2.Controls.Add(this.userChiTietVeXe1);
            this.panel2.Controls.Add(this.userThanhToan1);
            this.panel2.Controls.Add(this.userDatVe1);
            this.panel2.Location = new System.Drawing.Point(55, 295);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1999, 892);
            this.panel2.TabIndex = 3;
            // 
            // userLichTrinh1
            // 
            this.userLichTrinh1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userLichTrinh1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userLichTrinh1.Location = new System.Drawing.Point(55, 53);
            this.userLichTrinh1.Margin = new System.Windows.Forms.Padding(0);
            this.userLichTrinh1.Name = "userLichTrinh1";
            this.userLichTrinh1.Size = new System.Drawing.Size(1900, 800);
            this.userLichTrinh1.TabIndex = 2;
            // 
            // userProfile1
            // 
            this.userProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userProfile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userProfile1.Location = new System.Drawing.Point(55, 53);
            this.userProfile1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userProfile1.Name = "userProfile1";
            this.userProfile1.Size = new System.Drawing.Size(1900, 700);
            this.userProfile1.TabIndex = 1;
            // 
            // userChiTietVeXe1
            // 
            this.userChiTietVeXe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userChiTietVeXe1.Location = new System.Drawing.Point(55, 53);
            this.userChiTietVeXe1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userChiTietVeXe1.Name = "userChiTietVeXe1";
            this.userChiTietVeXe1.Size = new System.Drawing.Size(1900, 700);
            this.userChiTietVeXe1.TabIndex = 4;
            this.userChiTietVeXe1.Load += new System.EventHandler(this.userChiTietVeXe1_Load);
            // 
            // userThanhToan1
            // 
            this.userThanhToan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userThanhToan1.Location = new System.Drawing.Point(56, 53);
            this.userThanhToan1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userThanhToan1.Name = "userThanhToan1";
            this.userThanhToan1.Size = new System.Drawing.Size(1900, 800);
            this.userThanhToan1.TabIndex = 3;
            // 
            // userDatVe1
            // 
            this.userDatVe1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userDatVe1.Location = new System.Drawing.Point(55, 53);
            this.userDatVe1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.userDatVe1.Name = "userDatVe1";
            this.userDatVe1.Size = new System.Drawing.Size(1900, 800);
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
            // LogOut
            // 
            this.LogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOut.FillColor = System.Drawing.SystemColors.Control;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.LogOut.Location = new System.Drawing.Point(13, 7);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(66, 57);
            this.LogOut.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1868, 288);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 5;
            // 
            // BangDieuKhien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(2109, 1212);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BangDieuKhien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BangDieuKhien";
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
        private Guna.UI2.WinForms.Guna2Button btnDatVe;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnLichTrinh;
        private Guna.UI2.WinForms.Guna2Button btnChiTietVe;
        private Guna.UI2.WinForms.Guna2Button btnThongTinKH;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseDatVe;
        private KiemSoatUser.UserDatVe userDatVe1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseProfile;
        private KiemSoatUser.UserProfile userProfile1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseTimKiem;
        private KiemSoatUser.UserLichTrinh userLichTrinh1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseThanhToan;
        private KiemSoatUser.UserThanhToan userThanhToan1;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseCTVeXe;
        private KiemSoatUser.UserChiTietVeXe userChiTietVeXe1;
        private Guna.UI2.WinForms.Guna2Button LogOut;
        private System.Windows.Forms.WebBrowser webBrowser1;
        // private KiemSoatUser.UserChiTietVeXe userCTVeXe1;
    }
}
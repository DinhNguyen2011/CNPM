namespace WindowsFormsApp1
{
    partial class BangDieuKhienAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDieuKhienAdmin));
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMiniSize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLVeXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLCX = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLTuyenXe = new Guna.UI2.WinForms.Guna2Button();
            this.PnMovingad = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userQuanLyNhanVien1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyNhanVien();
            this.userQuanLyKhachHang1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyKhachHang();
            this.userQuanLyTuyenXe2 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyTuyenXe();
            this.userQuanLyChuyenXe1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyChuyenXe();
            this.userQuanLyTuyenXe1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyTuyenXe();
            this.userQuanLyXe1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyXe();
            this.guna2QLadmin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2QLKH = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2QLNV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2QLXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2QLChuyenXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2QLTuyenxe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(2107, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 58);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.BorderRadius = 10;
            this.btnMiniSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiniSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiniSize.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiniSize.ForeColor = System.Drawing.Color.White;
            this.btnMiniSize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniSize.Image")));
            this.btnMiniSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMiniSize.Location = new System.Drawing.Point(2034, 11);
            this.btnMiniSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(66, 58);
            this.btnMiniSize.TabIndex = 2;
            this.btnMiniSize.Click += new System.EventHandler(this.btnMiniSize_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnQLVeXe);
            this.panel1.Controls.Add(this.btnQLCX);
            this.panel1.Controls.Add(this.btnQLKH);
            this.panel1.Controls.Add(this.btnQLXe);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Controls.Add(this.btnQLTuyenXe);
            this.panel1.Location = new System.Drawing.Point(78, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 198);
            this.panel1.TabIndex = 3;
            // 
            // btnQLVeXe
            // 
            this.btnQLVeXe.BorderRadius = 18;
            this.btnQLVeXe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLVeXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLVeXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLVeXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLVeXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLVeXe.FillColor = System.Drawing.Color.Yellow;
            this.btnQLVeXe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLVeXe.ForeColor = System.Drawing.Color.Black;
            this.btnQLVeXe.Location = new System.Drawing.Point(1600, 24);
            this.btnQLVeXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLVeXe.Name = "btnQLVeXe";
            this.btnQLVeXe.Size = new System.Drawing.Size(255, 139);
            this.btnQLVeXe.TabIndex = 6;
            this.btnQLVeXe.Text = "Quản Lý Vé Xe";
            // 
            // btnQLCX
            // 
            this.btnQLCX.BorderRadius = 18;
            this.btnQLCX.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLCX.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLCX.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLCX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLCX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLCX.FillColor = System.Drawing.Color.Yellow;
            this.btnQLCX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCX.ForeColor = System.Drawing.Color.Black;
            this.btnQLCX.Location = new System.Drawing.Point(362, 24);
            this.btnQLCX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLCX.Name = "btnQLCX";
            this.btnQLCX.Size = new System.Drawing.Size(255, 139);
            this.btnQLCX.TabIndex = 5;
            this.btnQLCX.Text = "Quản lý chuyến xe";
            this.btnQLCX.Click += new System.EventHandler(this.btnQLCX_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.BorderRadius = 18;
            this.btnQLKH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLKH.FillColor = System.Drawing.Color.Yellow;
            this.btnQLKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.Black;
            this.btnQLKH.Location = new System.Drawing.Point(672, 24);
            this.btnQLKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(255, 139);
            this.btnQLKH.TabIndex = 4;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.Click += new System.EventHandler(this.btnThongTinKH_Click);
            // 
            // btnQLXe
            // 
            this.btnQLXe.BorderRadius = 18;
            this.btnQLXe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLXe.FillColor = System.Drawing.Color.Yellow;
            this.btnQLXe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLXe.ForeColor = System.Drawing.Color.Black;
            this.btnQLXe.Location = new System.Drawing.Point(986, 24);
            this.btnQLXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLXe.Name = "btnQLXe";
            this.btnQLXe.Size = new System.Drawing.Size(255, 139);
            this.btnQLXe.TabIndex = 2;
            this.btnQLXe.Text = "Quản lý xe";
            this.btnQLXe.Click += new System.EventHandler(this.btnQLXe_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.BorderRadius = 18;
            this.btnQLNV.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLNV.FillColor = System.Drawing.Color.Yellow;
            this.btnQLNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.Black;
            this.btnQLNV.Location = new System.Drawing.Point(1295, 24);
            this.btnQLNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(255, 139);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.Click += new System.EventHandler(this.btnLichTrinh_Click);
            // 
            // btnQLTuyenXe
            // 
            this.btnQLTuyenXe.BorderRadius = 18;
            this.btnQLTuyenXe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLTuyenXe.CustomBorderColor = System.Drawing.Color.White;
            this.btnQLTuyenXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLTuyenXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLTuyenXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLTuyenXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLTuyenXe.FillColor = System.Drawing.Color.Yellow;
            this.btnQLTuyenXe.FocusedColor = System.Drawing.Color.White;
            this.btnQLTuyenXe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTuyenXe.ForeColor = System.Drawing.Color.Black;
            this.btnQLTuyenXe.Location = new System.Drawing.Point(56, 22);
            this.btnQLTuyenXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQLTuyenXe.Name = "btnQLTuyenXe";
            this.btnQLTuyenXe.Size = new System.Drawing.Size(255, 139);
            this.btnQLTuyenXe.TabIndex = 0;
            this.btnQLTuyenXe.Text = "Quản lý tuyến xe";
            this.btnQLTuyenXe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // PnMovingad
            // 
            this.PnMovingad.BackColor = System.Drawing.Color.White;
            this.PnMovingad.Location = new System.Drawing.Point(153, 212);
            this.PnMovingad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnMovingad.Name = "PnMovingad";
            this.PnMovingad.Size = new System.Drawing.Size(225, 11);
            this.PnMovingad.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userQuanLyNhanVien1);
            this.panel2.Controls.Add(this.userQuanLyKhachHang1);
            this.panel2.Controls.Add(this.userQuanLyTuyenXe2);
            this.panel2.Controls.Add(this.userQuanLyChuyenXe1);
            this.panel2.Controls.Add(this.userQuanLyTuyenXe1);
            this.panel2.Controls.Add(this.userQuanLyXe1);
            this.panel2.Location = new System.Drawing.Point(78, 240);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2164, 968);
            this.panel2.TabIndex = 7;
            // 
            // userQuanLyNhanVien1
            // 
            this.userQuanLyNhanVien1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userQuanLyNhanVien1.Location = new System.Drawing.Point(-1, 21);
            this.userQuanLyNhanVien1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userQuanLyNhanVien1.Name = "userQuanLyNhanVien1";
            this.userQuanLyNhanVien1.Size = new System.Drawing.Size(2051, 925);
            this.userQuanLyNhanVien1.TabIndex = 2;
            // 
            // userQuanLyKhachHang1
            // 
            this.userQuanLyKhachHang1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userQuanLyKhachHang1.Location = new System.Drawing.Point(-1, 21);
            this.userQuanLyKhachHang1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userQuanLyKhachHang1.Name = "userQuanLyKhachHang1";
            this.userQuanLyKhachHang1.Size = new System.Drawing.Size(2051, 825);
            this.userQuanLyKhachHang1.TabIndex = 1;
            // 
            // userQuanLyTuyenXe2
            // 
            this.userQuanLyTuyenXe2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userQuanLyTuyenXe2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userQuanLyTuyenXe2.Location = new System.Drawing.Point(-1, 21);
            this.userQuanLyTuyenXe2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userQuanLyTuyenXe2.Name = "userQuanLyTuyenXe2";
            this.userQuanLyTuyenXe2.Size = new System.Drawing.Size(2050, 764);
            this.userQuanLyTuyenXe2.TabIndex = 5;
            // 
            // userQuanLyChuyenXe1
            // 
            this.userQuanLyChuyenXe1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userQuanLyChuyenXe1.Location = new System.Drawing.Point(-1, 21);
            this.userQuanLyChuyenXe1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userQuanLyChuyenXe1.Name = "userQuanLyChuyenXe1";
            this.userQuanLyChuyenXe1.Size = new System.Drawing.Size(2051, 765);
            this.userQuanLyChuyenXe1.TabIndex = 6;
            // 
            // userQuanLyTuyenXe1
            // 
            this.userQuanLyTuyenXe1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userQuanLyTuyenXe1.Location = new System.Drawing.Point(-1, 21);
            this.userQuanLyTuyenXe1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userQuanLyTuyenXe1.Name = "userQuanLyTuyenXe1";
            this.userQuanLyTuyenXe1.Size = new System.Drawing.Size(2051, 765);
            this.userQuanLyTuyenXe1.TabIndex = 4;
            // 
            // userQuanLyXe1
            // 
            this.userQuanLyXe1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userQuanLyXe1.Location = new System.Drawing.Point(-1, 21);
            this.userQuanLyXe1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userQuanLyXe1.Name = "userQuanLyXe1";
            this.userQuanLyXe1.Size = new System.Drawing.Size(2051, 765);
            this.userQuanLyXe1.TabIndex = 3;
            this.userQuanLyXe1.Load += new System.EventHandler(this.userQuanLyXe1_Load);
            // 
            // guna2QLadmin
            // 
            this.guna2QLadmin.TargetControl = this;
            // 
            // guna2QLKH
            // 
            this.guna2QLKH.TargetControl = this;
            // 
            // guna2QLNV
            // 
            this.guna2QLNV.TargetControl = this;
            // 
            // guna2QLXe
            // 
            this.guna2QLXe.TargetControl = this;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BorderRadius = 10;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(2107, 78);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(66, 58);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guna2QLChuyenXe
            // 
            this.guna2QLChuyenXe.TargetControl = this;
            // 
            // guna2QLTuyenxe
            // 
            this.guna2QLTuyenxe.TargetControl = this;
            // 
            // BangDieuKhienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(2185, 1212);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnMovingad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BangDieuKhienAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BangDieuKhienAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BangDieuKhienAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMiniSize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnQLKH;
        private Guna.UI2.WinForms.Guna2Button btnQLXe;
        private Guna.UI2.WinForms.Guna2Button btnQLNV;
        private Guna.UI2.WinForms.Guna2Button btnQLTuyenXe;
        private Guna.UI2.WinForms.Guna2Panel PnMovingad;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLadmin;
        private KiemSoatAmin.UserQuanLyTuyenXe userQuanLyBanVe1;
        private KiemSoatAmin.UserQuanLyKhachHang userQuanLyKhachHang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLKH;
        private KiemSoatAmin.UserQuanLyNhanVien userQuanLyNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLNV;
        private KiemSoatAmin.UserQuanLyXe userQuanLyXe1;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLXe;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnQLCX;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLChuyenXe;
        private KiemSoatAmin.UserQuanLyTuyenXe userQuanLyTuyenXe1;
        private KiemSoatAmin.UserQuanLyTuyenXe userQuanLyTuyenXe2;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLTuyenxe;
        private KiemSoatAmin.UserQuanLyChuyenXe userQuanLyChuyenXe1;
        private Guna.UI2.WinForms.Guna2Button btnQLVeXe;    }
}
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
            this.btnQLKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLNV = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLBanVe = new Guna.UI2.WinForms.Guna2Button();
            this.PnMovingad = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2QLadmin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2QLKH = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2QLNV = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2QLXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userQuanLyXe1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyXe();
            this.userQuanLyNhanVien1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyNhanVien();
            this.userQuanLyKhachHang1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyKhachHang();
            this.userQuanLyBanVe1 = new WindowsFormsApp1.KiemSoatAmin.UserQuanLyBanVe();
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
            this.btnClose.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(2, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiniSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiniSize.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiniSize.ForeColor = System.Drawing.Color.White;
            this.btnMiniSize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniSize.Image")));
            this.btnMiniSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMiniSize.Location = new System.Drawing.Point(2, 43);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(44, 37);
            this.btnMiniSize.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnQLKH);
            this.panel1.Controls.Add(this.btnQLXe);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Controls.Add(this.btnQLBanVe);
            this.panel1.Location = new System.Drawing.Point(52, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 130);
            this.panel1.TabIndex = 3;
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
            this.btnQLKH.Location = new System.Drawing.Point(342, 12);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(170, 90);
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
            this.btnQLXe.Location = new System.Drawing.Point(625, 13);
            this.btnQLXe.Name = "btnQLXe";
            this.btnQLXe.Size = new System.Drawing.Size(170, 90);
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
            this.btnQLNV.Location = new System.Drawing.Point(906, 13);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(170, 90);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản Lý Nhân Viên";
            this.btnQLNV.Click += new System.EventHandler(this.btnLichTrinh_Click);
            // 
            // btnQLBanVe
            // 
            this.btnQLBanVe.BorderRadius = 18;
            this.btnQLBanVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnQLBanVe.CustomBorderColor = System.Drawing.Color.White;
            this.btnQLBanVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLBanVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLBanVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLBanVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLBanVe.FillColor = System.Drawing.Color.Yellow;
            this.btnQLBanVe.FocusedColor = System.Drawing.Color.White;
            this.btnQLBanVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBanVe.ForeColor = System.Drawing.Color.Black;
            this.btnQLBanVe.Location = new System.Drawing.Point(48, 12);
            this.btnQLBanVe.Name = "btnQLBanVe";
            this.btnQLBanVe.Size = new System.Drawing.Size(170, 90);
            this.btnQLBanVe.TabIndex = 0;
            this.btnQLBanVe.Text = "Quản lý bán vé";
            this.btnQLBanVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // PnMovingad
            // 
            this.PnMovingad.BackColor = System.Drawing.Color.White;
            this.PnMovingad.Location = new System.Drawing.Point(112, 136);
            this.PnMovingad.Name = "PnMovingad";
            this.PnMovingad.Size = new System.Drawing.Size(150, 7);
            this.PnMovingad.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userQuanLyXe1);
            this.panel2.Controls.Add(this.userQuanLyNhanVien1);
            this.panel2.Controls.Add(this.userQuanLyKhachHang1);
            this.panel2.Controls.Add(this.userQuanLyBanVe1);
            this.panel2.Location = new System.Drawing.Point(52, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 600);
            this.panel2.TabIndex = 7;
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
            // userQuanLyXe1
            // 
            this.userQuanLyXe1.BackColor = System.Drawing.Color.Silver;
            this.userQuanLyXe1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userQuanLyXe1.Location = new System.Drawing.Point(2, 2);
            this.userQuanLyXe1.Name = "userQuanLyXe1";
            this.userQuanLyXe1.Size = new System.Drawing.Size(1370, 500);
            this.userQuanLyXe1.TabIndex = 3;
            this.userQuanLyXe1.Load += new System.EventHandler(this.userQuanLyXe1_Load);
            // 
            // userQuanLyNhanVien1
            // 
            this.userQuanLyNhanVien1.BackColor = System.Drawing.Color.DarkGray;
            this.userQuanLyNhanVien1.Location = new System.Drawing.Point(1, 3);
            this.userQuanLyNhanVien1.Name = "userQuanLyNhanVien1";
            this.userQuanLyNhanVien1.Size = new System.Drawing.Size(1370, 500);
            this.userQuanLyNhanVien1.TabIndex = 2;
            // 
            // userQuanLyKhachHang1
            // 
            this.userQuanLyKhachHang1.BackColor = System.Drawing.Color.DarkGray;
            this.userQuanLyKhachHang1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userQuanLyKhachHang1.Location = new System.Drawing.Point(1, 2);
            this.userQuanLyKhachHang1.Name = "userQuanLyKhachHang1";
            this.userQuanLyKhachHang1.Size = new System.Drawing.Size(1370, 500);
            this.userQuanLyKhachHang1.TabIndex = 1;
            // 
            // userQuanLyBanVe1
            // 
            this.userQuanLyBanVe1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.userQuanLyBanVe1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userQuanLyBanVe1.Location = new System.Drawing.Point(0, 0);
            this.userQuanLyBanVe1.Name = "userQuanLyBanVe1";
            this.userQuanLyBanVe1.Size = new System.Drawing.Size(1370, 500);
            this.userQuanLyBanVe1.TabIndex = 0;
            // 
            // BangDieuKhienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnMovingad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BangDieuKhienAdmin";
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
        private Guna.UI2.WinForms.Guna2Button btnQLBanVe;
        private Guna.UI2.WinForms.Guna2Panel PnMovingad;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLadmin;
        private KiemSoatAmin.UserQuanLyBanVe userQuanLyBanVe1;
        private KiemSoatAmin.UserQuanLyKhachHang userQuanLyKhachHang1;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLKH;
        private KiemSoatAmin.UserQuanLyNhanVien userQuanLyNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLNV;
        private KiemSoatAmin.UserQuanLyXe userQuanLyXe1;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLXe;
    }
}
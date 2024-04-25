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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDieuKhienAdmin));
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnMiniSize = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongTinKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnChiTietVe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichTrinh = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatVe = new Guna.UI2.WinForms.Guna2Button();
            this.PnMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnThongTinKH);
            this.panel1.Controls.Add(this.btnChiTietVe);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.btnLichTrinh);
            this.panel1.Controls.Add(this.btnDatVe);
            this.panel1.Location = new System.Drawing.Point(52, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 130);
            this.panel1.TabIndex = 3;
            // 
            // btnThongTinKH
            // 
            this.btnThongTinKH.BorderRadius = 18;
            this.btnThongTinKH.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongTinKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTinKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTinKH.FillColor = System.Drawing.Color.Yellow;
            this.btnThongTinKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinKH.ForeColor = System.Drawing.Color.Black;
            this.btnThongTinKH.Location = new System.Drawing.Point(272, 12);
            this.btnThongTinKH.Name = "btnThongTinKH";
            this.btnThongTinKH.Size = new System.Drawing.Size(170, 90);
            this.btnThongTinKH.TabIndex = 4;
            this.btnThongTinKH.Text = "Quản lý khách hàng";
            // 
            // btnChiTietVe
            // 
            this.btnChiTietVe.BorderRadius = 18;
            this.btnChiTietVe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChiTietVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChiTietVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTietVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChiTietVe.FillColor = System.Drawing.Color.Yellow;
            this.btnChiTietVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietVe.ForeColor = System.Drawing.Color.Black;
            this.btnChiTietVe.Location = new System.Drawing.Point(960, 12);
            this.btnChiTietVe.Name = "btnChiTietVe";
            this.btnChiTietVe.Size = new System.Drawing.Size(170, 90);
            this.btnChiTietVe.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderRadius = 18;
            this.btnThanhToan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.Yellow;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Location = new System.Drawing.Point(505, 12);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(170, 90);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Quản lý xe";
            // 
            // btnLichTrinh
            // 
            this.btnLichTrinh.BorderRadius = 18;
            this.btnLichTrinh.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLichTrinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichTrinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichTrinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichTrinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichTrinh.FillColor = System.Drawing.Color.Yellow;
            this.btnLichTrinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichTrinh.ForeColor = System.Drawing.Color.Black;
            this.btnLichTrinh.Location = new System.Drawing.Point(736, 12);
            this.btnLichTrinh.Name = "btnLichTrinh";
            this.btnLichTrinh.Size = new System.Drawing.Size(170, 90);
            this.btnLichTrinh.TabIndex = 1;
            this.btnLichTrinh.Text = "Quản Lý Nhân Viên";
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
            this.btnDatVe.FillColor = System.Drawing.Color.Yellow;
            this.btnDatVe.FocusedColor = System.Drawing.Color.White;
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.ForeColor = System.Drawing.Color.Black;
            this.btnDatVe.Location = new System.Drawing.Point(48, 12);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(170, 90);
            this.btnDatVe.TabIndex = 0;
            this.btnDatVe.Text = "Quản lý bán vé";
            // 
            // PnMoving
            // 
            this.PnMoving.BackColor = System.Drawing.Color.White;
            this.PnMoving.Location = new System.Drawing.Point(112, 136);
            this.PnMoving.Name = "PnMoving";
            this.PnMoving.Size = new System.Drawing.Size(150, 7);
            this.PnMoving.TabIndex = 6;
            // 
            // BangDieuKhienAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PnMoving);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BangDieuKhienAdmin";
            this.Text = "BangDieuKhienAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMiniSize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnThongTinKH;
        private Guna.UI2.WinForms.Guna2Button btnChiTietVe;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnLichTrinh;
        private Guna.UI2.WinForms.Guna2Button btnDatVe;
        private Guna.UI2.WinForms.Guna2Panel PnMoving;
    }
}
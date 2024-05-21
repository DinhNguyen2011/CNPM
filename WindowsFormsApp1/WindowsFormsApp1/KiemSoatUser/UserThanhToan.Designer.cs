namespace WindowsFormsApp1.KiemSoatUser
{
    partial class UserThanhToan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserThanhToan));
            this.txtNguoiGui = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpkNgayTT = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbNganHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoGhe = new System.Windows.Forms.RichTextBox();
            this.txtNganhang = new System.Windows.Forms.Label();
            this.txtChinhanh = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.Label();
            this.txtNguoinhan = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNguoiGui
            // 
            this.txtNguoiGui.BorderColor = System.Drawing.Color.Black;
            this.txtNguoiGui.BorderRadius = 20;
            this.txtNguoiGui.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNguoiGui.DefaultText = "";
            this.txtNguoiGui.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNguoiGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNguoiGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNguoiGui.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNguoiGui.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNguoiGui.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiGui.ForeColor = System.Drawing.Color.Black;
            this.txtNguoiGui.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNguoiGui.Location = new System.Drawing.Point(375, 236);
            this.txtNguoiGui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNguoiGui.Name = "txtNguoiGui";
            this.txtNguoiGui.PasswordChar = '\0';
            this.txtNguoiGui.PlaceholderText = "Nhập tên người gửi..";
            this.txtNguoiGui.ReadOnly = true;
            this.txtNguoiGui.SelectedText = "";
            this.txtNguoiGui.Size = new System.Drawing.Size(423, 72);
            this.txtNguoiGui.TabIndex = 7;
            this.txtNguoiGui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpkNgayTT
            // 
            this.dtpkNgayTT.BorderRadius = 20;
            this.dtpkNgayTT.Checked = true;
            this.dtpkNgayTT.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayTT.FillColor = System.Drawing.Color.Aqua;
            this.dtpkNgayTT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayTT.Location = new System.Drawing.Point(375, 487);
            this.dtpkNgayTT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkNgayTT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNgayTT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNgayTT.Name = "dtpkNgayTT";
            this.dtpkNgayTT.Size = new System.Drawing.Size(423, 72);
            this.dtpkNgayTT.TabIndex = 31;
            this.dtpkNgayTT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpkNgayTT.Value = new System.DateTime(2024, 4, 1, 21, 53, 1, 386);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cbNganHang
            // 
            this.cbNganHang.BackColor = System.Drawing.Color.Transparent;
            this.cbNganHang.BorderColor = System.Drawing.Color.Black;
            this.cbNganHang.BorderRadius = 18;
            this.cbNganHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNganHang.DropDownHeight = 300;
            this.cbNganHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNganHang.DropDownWidth = 100;
            this.cbNganHang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNganHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNganHang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNganHang.ForeColor = System.Drawing.Color.Black;
            this.cbNganHang.IntegralHeight = false;
            this.cbNganHang.ItemHeight = 40;
            this.cbNganHang.Items.AddRange(new object[] {
            "Agribank",
            "Vietcombank",
            "Sacombank"});
            this.cbNganHang.Location = new System.Drawing.Point(375, 362);
            this.cbNganHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNganHang.Name = "cbNganHang";
            this.cbNganHang.Size = new System.Drawing.Size(423, 46);
            this.cbNganHang.TabIndex = 34;
            this.cbNganHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbNganHang.SelectedIndexChanged += new System.EventHandler(this.cbNganHang_SelectedIndexChanged);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 18;
            this.guna2Button5.BorderThickness = 2;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Empty;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageSize = new System.Drawing.Size(250, 55);
            this.guna2Button5.Location = new System.Drawing.Point(72, 37);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(454, 115);
            this.guna2Button5.TabIndex = 41;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 18;
            this.guna2Button2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(21, 236);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(306, 72);
            this.guna2Button2.TabIndex = 42;
            this.guna2Button2.Text = "Họ và tên";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(21, 362);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(306, 72);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "Ngân hàng";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 18;
            this.guna2Button3.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(21, 487);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(306, 72);
            this.guna2Button3.TabIndex = 44;
            this.guna2Button3.Text = " Ngày thanh toán";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.White;
            this.guna2Button4.BorderRadius = 18;
            this.guna2Button4.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(21, 614);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(306, 72);
            this.guna2Button4.TabIndex = 45;
            this.guna2Button4.Text = "Số ghế";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderColor = System.Drawing.Color.White;
            this.guna2Button6.BorderRadius = 18;
            this.guna2Button6.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(1050, 54);
            this.guna2Button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(378, 55);
            this.guna2Button6.TabIndex = 46;
            this.guna2Button6.Text = " Nội dung chuyển khoản";
            this.guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(896, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 63);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ngân hàng :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(895, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 72);
            this.label2.TabIndex = 48;
            this.label2.Text = "Số tài khoản :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(896, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 69);
            this.label3.TabIndex = 49;
            this.label3.Text = "Chi nhánh :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(896, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 72);
            this.label4.TabIndex = 50;
            this.label4.Text = "Người nhận :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(896, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 72);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nội dung :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoGhe
            // 
            this.txtSoGhe.BackColor = System.Drawing.Color.White;
            this.txtSoGhe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoGhe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoGhe.ForeColor = System.Drawing.Color.Black;
            this.txtSoGhe.Location = new System.Drawing.Point(375, 612);
            this.txtSoGhe.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoGhe.Name = "txtSoGhe";
            this.txtSoGhe.ReadOnly = true;
            this.txtSoGhe.Size = new System.Drawing.Size(423, 169);
            this.txtSoGhe.TabIndex = 52;
            this.txtSoGhe.Text = "";
            // 
            // txtNganhang
            // 
            this.txtNganhang.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNganhang.ForeColor = System.Drawing.Color.Indigo;
            this.txtNganhang.Location = new System.Drawing.Point(1090, 177);
            this.txtNganhang.Name = "txtNganhang";
            this.txtNganhang.Size = new System.Drawing.Size(459, 63);
            this.txtNganhang.TabIndex = 53;
            this.txtNganhang.Text = "BIDV";
            this.txtNganhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChinhanh
            // 
            this.txtChinhanh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChinhanh.ForeColor = System.Drawing.Color.Indigo;
            this.txtChinhanh.Location = new System.Drawing.Point(1090, 250);
            this.txtChinhanh.Name = "txtChinhanh";
            this.txtChinhanh.Size = new System.Drawing.Size(459, 63);
            this.txtChinhanh.TabIndex = 54;
            this.txtChinhanh.Text = "ĐẠI HỌC CÔNG NGHỆ SÀI GÒN";
            this.txtChinhanh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSTK
            // 
            this.txtSTK.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSTK.ForeColor = System.Drawing.Color.Indigo;
            this.txtSTK.Location = new System.Drawing.Point(1090, 327);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(459, 63);
            this.txtSTK.TabIndex = 54;
            this.txtSTK.Text = "5311107852";
            this.txtSTK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNguoinhan
            // 
            this.txtNguoinhan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoinhan.ForeColor = System.Drawing.Color.Indigo;
            this.txtNguoinhan.Location = new System.Drawing.Point(1090, 416);
            this.txtNguoinhan.Name = "txtNguoinhan";
            this.txtNguoinhan.Size = new System.Drawing.Size(459, 73);
            this.txtNguoinhan.TabIndex = 54;
            this.txtNguoinhan.Text = "Công ty Cổ phần Vận tải xuyên quốc gia QB-TTH-KH";
            this.txtNguoinhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoidung
            // 
            this.txtNoidung.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoidung.ForeColor = System.Drawing.Color.Indigo;
            this.txtNoidung.Location = new System.Drawing.Point(1064, 518);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(499, 194);
            this.txtNoidung.TabIndex = 54;
            this.txtNoidung.Text = resources.GetString("txtNoidung.Text");
            this.txtNoidung.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.txtNguoinhan);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.txtChinhanh);
            this.Controls.Add(this.txtNganhang);
            this.Controls.Add(this.txtSoGhe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.cbNganHang);
            this.Controls.Add(this.dtpkNgayTT);
            this.Controls.Add(this.txtNguoiGui);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserThanhToan";
            this.Size = new System.Drawing.Size(1600, 820);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtNguoiGui;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgayTT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cbNganHang;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtSoGhe;
        private System.Windows.Forms.Label txtNguoinhan;
        private System.Windows.Forms.Label txtSTK;
        private System.Windows.Forms.Label txtChinhanh;
        private System.Windows.Forms.Label txtNganhang;
        private System.Windows.Forms.Label txtNoidung;
    }
}

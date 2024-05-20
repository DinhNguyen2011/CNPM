namespace WindowsFormsApp1.KiemSoatUser
{
    partial class UserLichTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLichTrinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimCXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnConvert = new Guna.UI2.WinForms.Guna2Button();
            this.dgvLichTrinh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbDiemDi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDiemDen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpkNgayDi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimCXe
            // 
            this.btnTimCXe.BackColor = System.Drawing.Color.Transparent;
            this.btnTimCXe.BorderRadius = 18;
            this.btnTimCXe.BorderThickness = 2;
            this.btnTimCXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimCXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimCXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimCXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimCXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTimCXe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimCXe.ForeColor = System.Drawing.Color.Black;
            this.btnTimCXe.Location = new System.Drawing.Point(1338, 448);
            this.btnTimCXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimCXe.Name = "btnTimCXe";
            this.btnTimCXe.Size = new System.Drawing.Size(227, 69);
            this.btnTimCXe.TabIndex = 26;
            this.btnTimCXe.Text = "Tìm chuyến xe";
            this.btnTimCXe.Click += new System.EventHandler(this.btnTimCXe_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BorderRadius = 20;
            this.btnConvert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvert.FillColor = System.Drawing.SystemColors.Window;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Image = ((System.Drawing.Image)(resources.GetObject("btnConvert.Image")));
            this.btnConvert.ImageSize = new System.Drawing.Size(45, 40);
            this.btnConvert.Location = new System.Drawing.Point(526, 264);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(121, 66);
            this.btnConvert.TabIndex = 29;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // dgvLichTrinh
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLichTrinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichTrinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichTrinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichTrinh.ColumnHeadersHeight = 50;
            this.dgvLichTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLichTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyen,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichTrinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichTrinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichTrinh.Location = new System.Drawing.Point(65, 356);
            this.dgvLichTrinh.Margin = new System.Windows.Forms.Padding(0);
            this.dgvLichTrinh.Name = "dgvLichTrinh";
            this.dgvLichTrinh.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichTrinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLichTrinh.RowHeadersVisible = false;
            this.dgvLichTrinh.RowHeadersWidth = 62;
            this.dgvLichTrinh.RowTemplate.Height = 35;
            this.dgvLichTrinh.Size = new System.Drawing.Size(1236, 449);
            this.dgvLichTrinh.TabIndex = 30;
            this.dgvLichTrinh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichTrinh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLichTrinh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLichTrinh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLichTrinh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLichTrinh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichTrinh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichTrinh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLichTrinh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLichTrinh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLichTrinh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLichTrinh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLichTrinh.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvLichTrinh.ThemeStyle.ReadOnly = true;
            this.dgvLichTrinh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLichTrinh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLichTrinh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLichTrinh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichTrinh.ThemeStyle.RowsStyle.Height = 35;
            this.dgvLichTrinh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLichTrinh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLichTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichTrinh_CellClick);
            // 
            // cbDiemDi
            // 
            this.cbDiemDi.BackColor = System.Drawing.Color.Transparent;
            this.cbDiemDi.BorderRadius = 15;
            this.cbDiemDi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDiemDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemDi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDiemDi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDiemDi.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbDiemDi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemDi.ForeColor = System.Drawing.Color.Black;
            this.cbDiemDi.ItemHeight = 40;
            this.cbDiemDi.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C"});
            this.cbDiemDi.Location = new System.Drawing.Point(109, 264);
            this.cbDiemDi.Margin = new System.Windows.Forms.Padding(0);
            this.cbDiemDi.Name = "cbDiemDi";
            this.cbDiemDi.Size = new System.Drawing.Size(349, 46);
            this.cbDiemDi.TabIndex = 31;
            this.cbDiemDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDiemDen
            // 
            this.cbDiemDen.BackColor = System.Drawing.Color.Transparent;
            this.cbDiemDen.BorderRadius = 15;
            this.cbDiemDen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDiemDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiemDen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDiemDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDiemDen.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbDiemDen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiemDen.ForeColor = System.Drawing.Color.Black;
            this.cbDiemDen.ItemHeight = 40;
            this.cbDiemDen.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C"});
            this.cbDiemDen.Location = new System.Drawing.Point(715, 264);
            this.cbDiemDen.Margin = new System.Windows.Forms.Padding(0);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(349, 46);
            this.cbDiemDen.TabIndex = 32;
            this.cbDiemDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpkNgayDi
            // 
            this.dtpkNgayDi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtpkNgayDi.BorderRadius = 20;
            this.dtpkNgayDi.Checked = true;
            this.dtpkNgayDi.CustomFormat = "";
            this.dtpkNgayDi.FillColor = System.Drawing.Color.Aqua;
            this.dtpkNgayDi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayDi.Location = new System.Drawing.Point(1265, 264);
            this.dtpkNgayDi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkNgayDi.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpkNgayDi.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtpkNgayDi.Name = "dtpkNgayDi";
            this.dtpkNgayDi.Size = new System.Drawing.Size(304, 66);
            this.dtpkNgayDi.TabIndex = 35;
            this.dtpkNgayDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpkNgayDi.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
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
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(201, 183);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(148, 58);
            this.guna2Button2.TabIndex = 36;
            this.guna2Button2.Text = "Điểm đi";
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
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(804, 183);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(157, 58);
            this.guna2Button3.TabIndex = 37;
            this.guna2Button3.Text = "Điểm đến";
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
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(1339, 183);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(159, 58);
            this.guna2Button4.TabIndex = 38;
            this.guna2Button4.Text = "Ngày đi";
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
            this.guna2Button5.ImageSize = new System.Drawing.Size(300, 60);
            this.guna2Button5.Location = new System.Drawing.Point(86, 36);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(575, 100);
            this.guna2Button5.TabIndex = 41;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1100, 249);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 77);
            this.btnRefresh.TabIndex = 42;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Giatien";
            this.Column5.FillWeight = 162.9268F;
            this.Column5.HeaderText = "Giá tiền";
            this.Column5.MinimumWidth = 100;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diemden";
            this.Column4.FillWeight = 102.5338F;
            this.Column4.HeaderText = "Điểm đến";
            this.Column4.MinimumWidth = 140;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Diemdi";
            this.Column3.FillWeight = 88.45177F;
            this.Column3.HeaderText = "Điểm đi";
            this.Column3.MinimumWidth = 140;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gioden";
            this.Column2.FillWeight = 96.96277F;
            this.Column2.HeaderText = "Giờ đến";
            this.Column2.MinimumWidth = 190;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Giodi";
            this.Column1.FillWeight = 80.94294F;
            this.Column1.HeaderText = "Giờ di";
            this.Column1.MinimumWidth = 190;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // MaChuyen
            // 
            this.MaChuyen.DataPropertyName = "Ma";
            this.MaChuyen.FillWeight = 68.18181F;
            this.MaChuyen.HeaderText = "Mã";
            this.MaChuyen.MinimumWidth = 20;
            this.MaChuyen.Name = "MaChuyen";
            this.MaChuyen.ReadOnly = true;
            // 
            // UserLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.dtpkNgayDi);
            this.Controls.Add(this.cbDiemDen);
            this.Controls.Add(this.cbDiemDi);
            this.Controls.Add(this.dgvLichTrinh);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnTimCXe);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserLichTrinh";
            this.Size = new System.Drawing.Size(1600, 820);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichTrinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimCXe;
        private Guna.UI2.WinForms.Guna2Button btnConvert;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLichTrinh;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiemDen;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiemDi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNgayDi;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.Label btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

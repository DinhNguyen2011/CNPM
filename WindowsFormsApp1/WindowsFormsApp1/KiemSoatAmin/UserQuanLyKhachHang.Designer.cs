namespace WindowsFormsApp1.KiemSoatAmin
{
    partial class UserQuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTimKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnXoaKH = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvtaikhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnHienthi = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimKH
            // 
            this.dgvTimKH.AllowUserToAddRows = false;
            this.dgvTimKH.AllowUserToDeleteRows = false;
            this.dgvTimKH.AllowUserToResizeColumns = false;
            this.dgvTimKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvTimKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTimKH.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTimKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvTimKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTimKH.ColumnHeadersHeight = 35;
            this.dgvTimKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAKH,
            this.TENKH,
            this.NGAYSINH,
            this.SDT,
            this.EMAIL});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimKH.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTimKH.GridColor = System.Drawing.Color.Gray;
            this.dgvTimKH.Location = new System.Drawing.Point(40, 129);
            this.dgvTimKH.MultiSelect = false;
            this.dgvTimKH.Name = "dgvTimKH";
            this.dgvTimKH.ReadOnly = true;
            this.dgvTimKH.RowHeadersVisible = false;
            this.dgvTimKH.RowHeadersWidth = 51;
            this.dgvTimKH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTimKH.RowTemplate.Height = 30;
            this.dgvTimKH.Size = new System.Drawing.Size(778, 274);
            this.dgvTimKH.TabIndex = 35;
            this.dgvTimKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTimKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTimKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTimKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTimKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTimKH.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvTimKH.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvTimKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTimKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTimKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTimKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTimKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTimKH.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvTimKH.ThemeStyle.ReadOnly = true;
            this.dgvTimKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTimKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTimKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTimKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTimKH.ThemeStyle.RowsStyle.Height = 30;
            this.dgvTimKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTimKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTimKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimKH_CellClick);
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã khách hàng";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // TENKH
            // 
            this.TENKH.DataPropertyName = "TENKH";
            this.TENKH.HeaderText = "Tên khách hàng";
            this.TENKH.MinimumWidth = 6;
            this.TENKH.Name = "TENKH";
            this.TENKH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaKH.BorderRadius = 18;
            this.btnXoaKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKH.Location = new System.Drawing.Point(208, 450);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(154, 45);
            this.btnXoaKH.TabIndex = 49;
            this.btnXoaKH.Text = "Xóa khách hàng và tài khoản";
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 43);
            this.label1.TabIndex = 50;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG / TÀI KHOẢN";
            // 
            // dgvtaikhoan
            // 
            this.dgvtaikhoan.AllowUserToAddRows = false;
            this.dgvtaikhoan.AllowUserToDeleteRows = false;
            this.dgvtaikhoan.AllowUserToResizeColumns = false;
            this.dgvtaikhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvtaikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtaikhoan.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvtaikhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvtaikhoan.ColumnHeadersHeight = 35;
            this.dgvtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtaikhoan.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvtaikhoan.GridColor = System.Drawing.Color.Gray;
            this.dgvtaikhoan.Location = new System.Drawing.Point(884, 129);
            this.dgvtaikhoan.MultiSelect = false;
            this.dgvtaikhoan.Name = "dgvtaikhoan";
            this.dgvtaikhoan.ReadOnly = true;
            this.dgvtaikhoan.RowHeadersVisible = false;
            this.dgvtaikhoan.RowHeadersWidth = 51;
            this.dgvtaikhoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvtaikhoan.RowTemplate.Height = 30;
            this.dgvtaikhoan.Size = new System.Drawing.Size(436, 274);
            this.dgvtaikhoan.TabIndex = 51;
            this.dgvtaikhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvtaikhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvtaikhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvtaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvtaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvtaikhoan.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvtaikhoan.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvtaikhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvtaikhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvtaikhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvtaikhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvtaikhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvtaikhoan.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvtaikhoan.ThemeStyle.ReadOnly = true;
            this.dgvtaikhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvtaikhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvtaikhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvtaikhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvtaikhoan.ThemeStyle.RowsStyle.Height = 30;
            this.dgvtaikhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvtaikhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MATK";
            this.Column1.HeaderText = "Mã tài khoản";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ACCOUNT";
            this.Column2.HeaderText = "Tên tài khoản";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MAKH";
            this.Column4.HeaderText = "Mã khách hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txttimkh
            // 
            this.txttimkh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkh.DefaultText = "";
            this.txttimkh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimkh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimkh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkh.Location = new System.Drawing.Point(959, 74);
            this.txttimkh.Margin = new System.Windows.Forms.Padding(2);
            this.txttimkh.Name = "txttimkh";
            this.txttimkh.PasswordChar = '\0';
            this.txttimkh.PlaceholderText = "Nhập tên KH";
            this.txttimkh.SelectedText = "";
            this.txttimkh.Size = new System.Drawing.Size(198, 41);
            this.txttimkh.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(956, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tìm tên khách hàng";
            // 
            // btnTimKH
            // 
            this.btnTimKH.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimKH.BorderRadius = 18;
            this.btnTimKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTimKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKH.ForeColor = System.Drawing.Color.Black;
            this.btnTimKH.Location = new System.Drawing.Point(1189, 70);
            this.btnTimKH.Name = "btnTimKH";
            this.btnTimKH.Size = new System.Drawing.Size(130, 45);
            this.btnTimKH.TabIndex = 54;
            this.btnTimKH.Text = "Tìm";
            this.btnTimKH.Click += new System.EventHandler(this.btnTimKH_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.BackColor = System.Drawing.Color.Transparent;
            this.btnHienthi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHienthi.BorderRadius = 18;
            this.btnHienthi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienthi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienthi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienthi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienthi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHienthi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienthi.ForeColor = System.Drawing.Color.Black;
            this.btnHienthi.Location = new System.Drawing.Point(474, 450);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(177, 45);
            this.btnHienthi.TabIndex = 55;
            this.btnHienthi.Text = "Hiển thị toàn bộ";
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // UserQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnTimKH);
            this.Controls.Add(this.txttimkh);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvtaikhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.dgvTimKH);
            this.Name = "UserQuanLyKhachHang";
            this.Size = new System.Drawing.Size(1367, 536);
            this.Load += new System.EventHandler(this.UserQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvTimKH;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnXoaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvtaikhoan;
        private Guna.UI2.WinForms.Guna2Button btnTimKH;
        private Guna.UI2.WinForms.Guna2TextBox txttimkh;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnHienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

namespace WindowsFormsApp1.KiemSoatAmin
{
    partial class UserQuanLyXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserQuanLyXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2QLXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnXoaXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemXe = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoghe = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSuaXe = new Guna.UI2.WinForms.Guna2Button();
            this.txtBienSo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btntimxe = new Guna.UI2.WinForms.Guna2Button();
            this.btnHienthi = new Guna.UI2.WinForms.Guna2Button();
            this.txttimxe = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dgvXe
            // 
            this.dgvXe.AllowUserToAddRows = false;
            this.dgvXe.AllowUserToDeleteRows = false;
            this.dgvXe.AllowUserToResizeColumns = false;
            this.dgvXe.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvXe.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.dgvXe, "dgvXe");
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXe.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvXe.GridColor = System.Drawing.Color.Gray;
            this.dgvXe.MultiSelect = false;
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.ReadOnly = true;
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvXe.RowTemplate.Height = 30;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvXe.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.dgvXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvXe.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvXe.ThemeStyle.ReadOnly = true;
            this.dgvXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvXe.ThemeStyle.RowsStyle.Height = 30;
            this.dgvXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAXE";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENXE";
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BIENSO";
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SOGHE";
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // guna2QLXe
            // 
            this.guna2QLXe.BorderRadius = 30;
            this.guna2QLXe.TargetControl = this;
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoaXe.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaXe.BorderRadius = 18;
            this.btnXoaXe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnXoaXe.CustomBorderColor = System.Drawing.Color.White;
            this.btnXoaXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaXe.FocusedColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnXoaXe, "btnXoaXe");
            this.btnXoaXe.ForeColor = System.Drawing.Color.Black;
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThemXe.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemXe.BorderRadius = 18;
            this.btnThemXe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnThemXe.CustomBorderColor = System.Drawing.Color.White;
            this.btnThemXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemXe.FocusedColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnThemXe, "btnThemXe");
            this.btnThemXe.ForeColor = System.Drawing.Color.Black;
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenXe.DefaultText = "24";
            this.txtTenXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtTenXe, "txtTenXe");
            this.txtTenXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.PasswordChar = '\0';
            this.txtTenXe.PlaceholderText = "Nhập tên xe";
            this.txtTenXe.SelectedText = "";
            // 
            // txtSoghe
            // 
            this.txtSoghe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoghe.DefaultText = "";
            this.txtSoghe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoghe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoghe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoghe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoghe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtSoghe, "txtSoghe");
            this.txtSoghe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoghe.Name = "txtSoghe";
            this.txtSoghe.PasswordChar = '\0';
            this.txtSoghe.PlaceholderText = "Nhập số ghê";
            this.txtSoghe.ReadOnly = true;
            this.txtSoghe.SelectedText = "";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuaXe.BorderColor = System.Drawing.Color.Transparent;
            this.btnSuaXe.BorderRadius = 18;
            this.btnSuaXe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSuaXe.CustomBorderColor = System.Drawing.Color.White;
            this.btnSuaXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaXe.FocusedColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSuaXe, "btnSuaXe");
            this.btnSuaXe.ForeColor = System.Drawing.Color.Black;
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Click += new System.EventHandler(this.btnSuaXe_Click);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBienSo.DefaultText = "";
            this.txtBienSo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBienSo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBienSo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBienSo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBienSo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txtBienSo, "txtBienSo");
            this.txtBienSo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.PasswordChar = '\0';
            this.txtBienSo.PlaceholderText = "Nhập biển số";
            this.txtBienSo.SelectedText = "";
            // 
            // btntimxe
            // 
            this.btntimxe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btntimxe.BorderColor = System.Drawing.Color.Transparent;
            this.btntimxe.BorderRadius = 18;
            this.btntimxe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btntimxe.CustomBorderColor = System.Drawing.Color.White;
            this.btntimxe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntimxe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntimxe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntimxe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntimxe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntimxe.FocusedColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btntimxe, "btntimxe");
            this.btntimxe.ForeColor = System.Drawing.Color.Black;
            this.btntimxe.Name = "btntimxe";
            this.btntimxe.Click += new System.EventHandler(this.btntimxe_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnHienthi, "btnHienthi");
            this.btnHienthi.BorderRadius = 18;
            this.btnHienthi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienthi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienthi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienthi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienthi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHienthi.ForeColor = System.Drawing.Color.Black;
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // txttimxe
            // 
            this.txttimxe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimxe.DefaultText = "";
            this.txttimxe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimxe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimxe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimxe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimxe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.txttimxe, "txttimxe");
            this.txttimxe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimxe.Name = "txttimxe";
            this.txttimxe.PasswordChar = '\0';
            this.txttimxe.PlaceholderText = "Nhập biển số";
            this.txttimxe.SelectedText = "";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // UserQuanLyXe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txttimxe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btntimxe);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.btnSuaXe);
            this.Controls.Add(this.txtSoghe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemXe);
            this.Controls.Add(this.btnXoaXe);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserQuanLyXe";
            this.Load += new System.EventHandler(this.UserQuanLyXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvXe;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLXe;
        private Guna.UI2.WinForms.Guna2Button btnXoaXe;
        private Guna.UI2.WinForms.Guna2Button btnThemXe;
        private Guna.UI2.WinForms.Guna2TextBox txtSoghe;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenXe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSuaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2TextBox txtBienSo;
        private Guna.UI2.WinForms.Guna2Button btntimxe;
        private Guna.UI2.WinForms.Guna2Button btnHienthi;
        private Guna.UI2.WinForms.Guna2TextBox txttimxe;
        private System.Windows.Forms.Label label5;
    }
}

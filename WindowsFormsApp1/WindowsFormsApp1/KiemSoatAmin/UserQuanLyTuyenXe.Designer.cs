namespace WindowsFormsApp1.KiemSoatAmin
{
    partial class UserQuanLyTuyenXe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserQuanLyTuyenXe));
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvVeXe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSwap = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaTuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimTuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemTuyen = new Guna.UI2.WinForms.Guna2Button();
            this.guna2QLTuyenXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtdiemdi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdiemden = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ TUYẾN XE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1139, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Điểm đến";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(880, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Điểm Đi";
            // 
            // dgvVeXe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVeXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVeXe.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvVeXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvVeXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVeXe.ColumnHeadersHeight = 35;
            this.dgvVeXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVeXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVeXe.GridColor = System.Drawing.Color.DarkGray;
            this.dgvVeXe.Location = new System.Drawing.Point(40, 137);
            this.dgvVeXe.Name = "dgvVeXe";
            this.dgvVeXe.RowHeadersVisible = false;
            this.dgvVeXe.RowHeadersWidth = 51;
            this.dgvVeXe.RowTemplate.Height = 30;
            this.dgvVeXe.Size = new System.Drawing.Size(815, 296);
            this.dgvVeXe.TabIndex = 39;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVeXe.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvVeXe.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dgvVeXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVeXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVeXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVeXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVeXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVeXe.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvVeXe.ThemeStyle.ReadOnly = false;
            this.dgvVeXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVeXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVeXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVeXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVeXe.ThemeStyle.RowsStyle.Height = 30;
            this.dgvVeXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVeXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVeXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeXe_CellContentClick);
            this.dgvVeXe.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeXe_RowEnter);
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MATUYEN";
            this.Column12.HeaderText = "Mã tuyến xe";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "DIEMDI";
            this.Column13.HeaderText = "Điểm đi";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "DIEMDEN";
            this.Column14.HeaderText = "Điểm đến";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            // 
            // btnSwap
            // 
            this.btnSwap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnSwap.BorderRadius = 20;
            this.btnSwap.BorderThickness = 1;
            this.btnSwap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwap.FillColor = System.Drawing.SystemColors.Window;
            this.btnSwap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSwap.ForeColor = System.Drawing.Color.White;
            this.btnSwap.Image = ((System.Drawing.Image)(resources.GetObject("btnSwap.Image")));
            this.btnSwap.ImageSize = new System.Drawing.Size(45, 40);
            this.btnSwap.Location = new System.Drawing.Point(1086, 212);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(53, 36);
            this.btnSwap.TabIndex = 40;
            // 
            // btnXoaTuyen
            // 
            this.btnXoaTuyen.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoaTuyen.BorderRadius = 18;
            this.btnXoaTuyen.BorderThickness = 1;
            this.btnXoaTuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaTuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTuyen.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTuyen.Location = new System.Drawing.Point(1208, 356);
            this.btnXoaTuyen.Name = "btnXoaTuyen";
            this.btnXoaTuyen.Size = new System.Drawing.Size(132, 45);
            this.btnXoaTuyen.TabIndex = 45;
            this.btnXoaTuyen.Text = "Xóa";
            this.btnXoaTuyen.Click += new System.EventHandler(this.btnXoaTuyen_Click);
            // 
            // btnTimTuyen
            // 
            this.btnTimTuyen.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimTuyen.BorderRadius = 18;
            this.btnTimTuyen.BorderThickness = 1;
            this.btnTimTuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimTuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimTuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTimTuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTuyen.ForeColor = System.Drawing.Color.Black;
            this.btnTimTuyen.Location = new System.Drawing.Point(1046, 356);
            this.btnTimTuyen.Name = "btnTimTuyen";
            this.btnTimTuyen.Size = new System.Drawing.Size(132, 45);
            this.btnTimTuyen.TabIndex = 46;
            this.btnTimTuyen.Text = "Tìm";
            // 
            // btnThemTuyen
            // 
            this.btnThemTuyen.BorderColor = System.Drawing.Color.Transparent;
            this.btnThemTuyen.BorderRadius = 18;
            this.btnThemTuyen.BorderThickness = 1;
            this.btnThemTuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemTuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuyen.ForeColor = System.Drawing.Color.Black;
            this.btnThemTuyen.Location = new System.Drawing.Point(883, 356);
            this.btnThemTuyen.Name = "btnThemTuyen";
            this.btnThemTuyen.Size = new System.Drawing.Size(132, 45);
            this.btnThemTuyen.TabIndex = 47;
            this.btnThemTuyen.Text = "Thêm";
            this.btnThemTuyen.Click += new System.EventHandler(this.btnThemTuyen_Click);
            // 
            // guna2QLTuyenXe
            // 
            this.guna2QLTuyenXe.BorderRadius = 30;
            this.guna2QLTuyenXe.TargetControl = this;
            // 
            // txtdiemdi
            // 
            this.txtdiemdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiemdi.DefaultText = "";
            this.txtdiemdi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiemdi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiemdi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemdi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemdi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdiemdi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemdi.Location = new System.Drawing.Point(883, 212);
            this.txtdiemdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdiemdi.Name = "txtdiemdi";
            this.txtdiemdi.PasswordChar = '\0';
            this.txtdiemdi.PlaceholderText = "";
            this.txtdiemdi.SelectedText = "";
            this.txtdiemdi.Size = new System.Drawing.Size(198, 41);
            this.txtdiemdi.TabIndex = 0;
            // 
            // txtdiemden
            // 
            this.txtdiemden.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiemden.DefaultText = "";
            this.txtdiemden.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiemden.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiemden.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemden.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemden.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemden.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdiemden.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemden.Location = new System.Drawing.Point(1142, 212);
            this.txtdiemden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdiemden.Name = "txtdiemden";
            this.txtdiemden.PasswordChar = '\0';
            this.txtdiemden.PlaceholderText = "";
            this.txtdiemden.SelectedText = "";
            this.txtdiemden.Size = new System.Drawing.Size(198, 41);
            this.txtdiemden.TabIndex = 48;
            // 
            // UserQuanLyTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.txtdiemden);
            this.Controls.Add(this.txtdiemdi);
            this.Controls.Add(this.btnThemTuyen);
            this.Controls.Add(this.btnTimTuyen);
            this.Controls.Add(this.btnXoaTuyen);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.dgvVeXe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "UserQuanLyTuyenXe";
            this.Size = new System.Drawing.Size(1367, 497);
            this.Load += new System.EventHandler(this.UserQuanLyTuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVeXe;
        private Guna.UI2.WinForms.Guna2Button btnSwap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private Guna.UI2.WinForms.Guna2Button btnThemTuyen;
        private Guna.UI2.WinForms.Guna2Button btnTimTuyen;
        private Guna.UI2.WinForms.Guna2Button btnXoaTuyen;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLTuyenXe;
        private Guna.UI2.WinForms.Guna2TextBox txtdiemden;
        private Guna.UI2.WinForms.Guna2TextBox txtdiemdi;
    }
}

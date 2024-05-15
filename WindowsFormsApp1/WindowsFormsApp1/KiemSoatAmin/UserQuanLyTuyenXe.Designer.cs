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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserQuanLyTuyenXe));
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvVeXe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSwap = new Guna.UI2.WinForms.Guna2Button();
            this.cbDiemDi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbDiemDen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSuaTuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaTuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimTuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemTuyen = new Guna.UI2.WinForms.Guna2Button();
            this.guna2QLTuyenXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý tuyến xe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1067, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Điểm đến";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(797, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Điểm Đi";
            // 
            // dgvVeXe
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvVeXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVeXe.ColumnHeadersHeight = 28;
            this.dgvVeXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVeXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeXe.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVeXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVeXe.Location = new System.Drawing.Point(86, 77);
            this.dgvVeXe.Name = "dgvVeXe";
            this.dgvVeXe.RowHeadersVisible = false;
            this.dgvVeXe.Size = new System.Drawing.Size(697, 290);
            this.dgvVeXe.TabIndex = 39;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVeXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVeXe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVeXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVeXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVeXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVeXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVeXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVeXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVeXe.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvVeXe.ThemeStyle.ReadOnly = false;
            this.dgvVeXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVeXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVeXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVeXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVeXe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvVeXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVeXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Mã tuyến xe";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Điểm đi";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Điểm đến";
            this.Column14.Name = "Column14";
            // 
            // btnSwap
            // 
            this.btnSwap.BorderRadius = 20;
            this.btnSwap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwap.FillColor = System.Drawing.SystemColors.Window;
            this.btnSwap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSwap.ForeColor = System.Drawing.Color.White;
            this.btnSwap.Image = ((System.Drawing.Image)(resources.GetObject("btnSwap.Image")));
            this.btnSwap.ImageSize = new System.Drawing.Size(45, 40);
            this.btnSwap.Location = new System.Drawing.Point(994, 109);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(53, 36);
            this.btnSwap.TabIndex = 40;
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
            this.cbDiemDi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDiemDi.ForeColor = System.Drawing.Color.Black;
            this.cbDiemDi.ItemHeight = 30;
            this.cbDiemDi.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C"});
            this.cbDiemDi.Location = new System.Drawing.Point(803, 109);
            this.cbDiemDi.Name = "cbDiemDi";
            this.cbDiemDi.Size = new System.Drawing.Size(185, 36);
            this.cbDiemDi.TabIndex = 41;
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
            this.cbDiemDen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbDiemDen.ForeColor = System.Drawing.Color.Black;
            this.cbDiemDen.ItemHeight = 30;
            this.cbDiemDen.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C"});
            this.cbDiemDen.Location = new System.Drawing.Point(1053, 109);
            this.cbDiemDen.Name = "cbDiemDen";
            this.cbDiemDen.Size = new System.Drawing.Size(182, 36);
            this.cbDiemDen.TabIndex = 42;
            // 
            // btnSuaTuyen
            // 
            this.btnSuaTuyen.BorderRadius = 18;
            this.btnSuaTuyen.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSuaTuyen.BorderThickness = 1;
            this.btnSuaTuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaTuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaTuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaTuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaTuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTuyen.ForeColor = System.Drawing.Color.Black;
            this.btnSuaTuyen.Location = new System.Drawing.Point(803, 264);
            this.btnSuaTuyen.Name = "btnSuaTuyen";
            this.btnSuaTuyen.Size = new System.Drawing.Size(154, 45);
            this.btnSuaTuyen.TabIndex = 44;
            this.btnSuaTuyen.Text = "Sửa";
            // 
            // btnXoaTuyen
            // 
            this.btnXoaTuyen.BorderRadius = 18;
            this.btnXoaTuyen.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnXoaTuyen.BorderThickness = 1;
            this.btnXoaTuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaTuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTuyen.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTuyen.Location = new System.Drawing.Point(1015, 264);
            this.btnXoaTuyen.Name = "btnXoaTuyen";
            this.btnXoaTuyen.Size = new System.Drawing.Size(154, 45);
            this.btnXoaTuyen.TabIndex = 45;
            this.btnXoaTuyen.Text = "Xóa";
            // 
            // btnTimTuyen
            // 
            this.btnTimTuyen.BorderRadius = 18;
            this.btnTimTuyen.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnTimTuyen.BorderThickness = 1;
            this.btnTimTuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimTuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimTuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimTuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTimTuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTuyen.ForeColor = System.Drawing.Color.Black;
            this.btnTimTuyen.Location = new System.Drawing.Point(803, 185);
            this.btnTimTuyen.Name = "btnTimTuyen";
            this.btnTimTuyen.Size = new System.Drawing.Size(154, 45);
            this.btnTimTuyen.TabIndex = 46;
            this.btnTimTuyen.Text = "Tìm";
            // 
            // btnThemTuyen
            // 
            this.btnThemTuyen.BorderRadius = 18;
            this.btnThemTuyen.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnThemTuyen.BorderThickness = 1;
            this.btnThemTuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemTuyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuyen.ForeColor = System.Drawing.Color.Black;
            this.btnThemTuyen.Location = new System.Drawing.Point(1015, 185);
            this.btnThemTuyen.Name = "btnThemTuyen";
            this.btnThemTuyen.Size = new System.Drawing.Size(154, 45);
            this.btnThemTuyen.TabIndex = 47;
            this.btnThemTuyen.Text = "Thêm";
            // 
            // guna2QLTuyenXe
            // 
            this.guna2QLTuyenXe.BorderRadius = 30;
            this.guna2QLTuyenXe.TargetControl = this;
            // 
            // UserQuanLyTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnThemTuyen);
            this.Controls.Add(this.btnTimTuyen);
            this.Controls.Add(this.btnXoaTuyen);
            this.Controls.Add(this.btnSuaTuyen);
            this.Controls.Add(this.cbDiemDen);
            this.Controls.Add(this.cbDiemDi);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.dgvVeXe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "UserQuanLyTuyenXe";
            this.Size = new System.Drawing.Size(1370, 450);
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
        private Guna.UI2.WinForms.Guna2ComboBox cbDiemDen;
        private Guna.UI2.WinForms.Guna2ComboBox cbDiemDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private Guna.UI2.WinForms.Guna2Button btnThemTuyen;
        private Guna.UI2.WinForms.Guna2Button btnTimTuyen;
        private Guna.UI2.WinForms.Guna2Button btnXoaTuyen;
        private Guna.UI2.WinForms.Guna2Button btnSuaTuyen;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLTuyenXe;
    }
}

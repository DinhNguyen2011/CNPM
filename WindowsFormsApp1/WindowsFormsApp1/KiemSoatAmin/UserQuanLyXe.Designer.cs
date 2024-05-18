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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cbSoXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2QLXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnXoaXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemXe = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenXe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoghe = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSuaXe = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1149, 387);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Biển số xe";
            // 
            // dgvXe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXe.ColumnHeadersHeight = 15;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvXe.Location = new System.Drawing.Point(53, 169);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.Size = new System.Drawing.Size(1048, 324);
            this.dgvXe.TabIndex = 29;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXe.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvXe.ThemeStyle.ReadOnly = false;
            this.dgvXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvXe.ThemeStyle.RowsStyle.Height = 22;
            this.dgvXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cbSoXe
            // 
            this.cbSoXe.BackColor = System.Drawing.Color.Transparent;
            this.cbSoXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoXe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoXe.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.cbSoXe.ForeColor = System.Drawing.Color.Black;
            this.cbSoXe.ItemHeight = 30;
            this.cbSoXe.Items.AddRange(new object[] {
            "--Tất cả xe--",
            "59C-12345",
            "70A-12452",
            "50B-12134",
            "68G-13414",
            "72H-12141",
            "88C-24124",
            "51B-14364",
            "36E-13141",
            "60A-12312",
            "62B-11463"});
            this.cbSoXe.Location = new System.Drawing.Point(1149, 411);
            this.cbSoXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSoXe.Name = "cbSoXe";
            this.cbSoXe.Size = new System.Drawing.Size(240, 36);
            this.cbSoXe.TabIndex = 30;
            // 
            // guna2QLXe
            // 
            this.guna2QLXe.BorderRadius = 30;
            this.guna2QLXe.TargetControl = this;
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXoaXe.BorderColor = System.Drawing.Color.MintCream;
            this.btnXoaXe.BorderRadius = 18;
            this.btnXoaXe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnXoaXe.BorderThickness = 1;
            this.btnXoaXe.CustomBorderColor = System.Drawing.Color.White;
            this.btnXoaXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnXoaXe.FocusedColor = System.Drawing.Color.Transparent;
            this.btnXoaXe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnXoaXe.ForeColor = System.Drawing.Color.Black;
            this.btnXoaXe.Location = new System.Drawing.Point(1488, 420);
            this.btnXoaXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(179, 55);
            this.btnXoaXe.TabIndex = 31;
            this.btnXoaXe.Text = "Xóa ";
            // 
            // btnThemXe
            // 
            this.btnThemXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThemXe.BorderColor = System.Drawing.Color.MintCream;
            this.btnThemXe.BorderRadius = 18;
            this.btnThemXe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnThemXe.BorderThickness = 1;
            this.btnThemXe.CustomBorderColor = System.Drawing.Color.White;
            this.btnThemXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThemXe.FocusedColor = System.Drawing.Color.Transparent;
            this.btnThemXe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThemXe.ForeColor = System.Drawing.Color.Black;
            this.btnThemXe.Location = new System.Drawing.Point(1488, 195);
            this.btnThemXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(179, 55);
            this.btnThemXe.TabIndex = 32;
            this.btnThemXe.Text = "Thêm";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã xe";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên xe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Biển số xe";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số ghế";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1149, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tên xe";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenXe.DefaultText = "";
            this.txtTenXe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenXe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenXe.Location = new System.Drawing.Point(1149, 195);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.PasswordChar = '\0';
            this.txtTenXe.PlaceholderText = "";
            this.txtTenXe.SelectedText = "";
            this.txtTenXe.Size = new System.Drawing.Size(240, 36);
            this.txtTenXe.TabIndex = 34;
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
            this.txtSoghe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoghe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoghe.Location = new System.Drawing.Point(1149, 305);
            this.txtSoghe.Name = "txtSoghe";
            this.txtSoghe.PasswordChar = '\0';
            this.txtSoghe.PlaceholderText = "";
            this.txtSoghe.SelectedText = "";
            this.txtSoghe.Size = new System.Drawing.Size(240, 36);
            this.txtSoghe.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1149, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Số ghế";
            // 
            // btnSuaXe
            // 
            this.btnSuaXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuaXe.BorderColor = System.Drawing.Color.MintCream;
            this.btnSuaXe.BorderRadius = 18;
            this.btnSuaXe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnSuaXe.BorderThickness = 1;
            this.btnSuaXe.CustomBorderColor = System.Drawing.Color.White;
            this.btnSuaXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSuaXe.FocusedColor = System.Drawing.Color.Transparent;
            this.btnSuaXe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSuaXe.ForeColor = System.Drawing.Color.Black;
            this.btnSuaXe.Location = new System.Drawing.Point(1488, 305);
            this.btnSuaXe.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaXe.Name = "btnSuaXe";
            this.btnSuaXe.Size = new System.Drawing.Size(179, 55);
            this.btnSuaXe.TabIndex = 37;
            this.btnSuaXe.Text = "Sửa";
            // 
            // UserQuanLyXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnSuaXe);
            this.Controls.Add(this.txtSoghe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemXe);
            this.Controls.Add(this.btnXoaXe);
            this.Controls.Add(this.cbSoXe);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserQuanLyXe";
            this.Size = new System.Drawing.Size(1821, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvXe;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoXe;
        private Guna.UI2.WinForms.Guna2Elipse guna2QLXe;
        private Guna.UI2.WinForms.Guna2Button btnXoaXe;
        private Guna.UI2.WinForms.Guna2Button btnThemXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2TextBox txtSoghe;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenXe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSuaXe;
    }
}

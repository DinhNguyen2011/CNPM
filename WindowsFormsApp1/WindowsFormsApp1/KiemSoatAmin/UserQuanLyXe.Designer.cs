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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvXe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSoXe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2QLXe = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnXoaXe = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemXe = new Guna.UI2.WinForms.Guna2Button();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXe.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvXe, "dgvXe");
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvXe.GridColor = System.Drawing.Color.DarkGray;
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowTemplate.Height = 30;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvXe.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.dgvXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXe.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvXe.ThemeStyle.ReadOnly = false;
            this.dgvXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvXe.ThemeStyle.RowsStyle.Height = 30;
            this.dgvXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            resources.ApplyResources(this.Column3, "Column3");
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            resources.ApplyResources(this.Column4, "Column4");
            this.Column4.Name = "Column4";
            // 
            // cbSoXe
            // 
            this.cbSoXe.BackColor = System.Drawing.Color.Transparent;
            this.cbSoXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoXe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoXe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.cbSoXe, "cbSoXe");
            this.cbSoXe.ForeColor = System.Drawing.Color.Black;
            this.cbSoXe.Items.AddRange(new object[] {
            resources.GetString("cbSoXe.Items"),
            resources.GetString("cbSoXe.Items1"),
            resources.GetString("cbSoXe.Items2"),
            resources.GetString("cbSoXe.Items3"),
            resources.GetString("cbSoXe.Items4"),
            resources.GetString("cbSoXe.Items5"),
            resources.GetString("cbSoXe.Items6"),
            resources.GetString("cbSoXe.Items7"),
            resources.GetString("cbSoXe.Items8"),
            resources.GetString("cbSoXe.Items9"),
            resources.GetString("cbSoXe.Items10")});
            this.cbSoXe.Name = "cbSoXe";
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
            this.btnXoaXe.BorderThickness = 1;
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
            // 
            // btnThemXe
            // 
            this.btnThemXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThemXe.BorderColor = System.Drawing.Color.Transparent;
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
            resources.ApplyResources(this.btnThemXe, "btnThemXe");
            this.btnThemXe.ForeColor = System.Drawing.Color.Black;
            this.btnThemXe.Name = "btnThemXe";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            resources.ApplyResources(this.txtTenXe, "txtTenXe");
            this.txtTenXe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.PasswordChar = '\0';
            this.txtTenXe.PlaceholderText = "";
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
            this.txtSoghe.PlaceholderText = "";
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
            this.btnSuaXe.BorderThickness = 1;
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
            // 
            // UserQuanLyXe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "UserQuanLyXe";
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
        private Guna.UI2.WinForms.Guna2TextBox txtSoghe;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtTenXe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSuaXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

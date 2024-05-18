using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDkiTK = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPw = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.guna2Button5);
            this.guna2Panel1.Controls.Add(this.btnDkiTK);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.lblError);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.txtPw);
            this.guna2Panel1.Controls.Add(this.txtUseName);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btnClose);
<<<<<<< Updated upstream
            this.guna2Panel1.Location = new System.Drawing.Point(530, 314);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1209, 667);
=======
            this.guna2Panel1.Location = new System.Drawing.Point(195, 110);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1360, 880);
>>>>>>> Stashed changes
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnDkiTK
            // 
            this.btnDkiTK.AutoRoundedCorners = true;
            this.btnDkiTK.BorderRadius = 20;
            this.btnDkiTK.BorderThickness = 1;
            this.btnDkiTK.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDkiTK.DefaultAutoSize = true;
            this.btnDkiTK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDkiTK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDkiTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDkiTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDkiTK.FillColor = System.Drawing.Color.White;
            this.btnDkiTK.FocusedColor = System.Drawing.Color.Transparent;
            this.btnDkiTK.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btnDkiTK.ForeColor = System.Drawing.Color.Black;
<<<<<<< Updated upstream
            this.btnDkiTK.Location = new System.Drawing.Point(785, 563);
            this.btnDkiTK.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnDkiTK.Location = new System.Drawing.Point(883, 745);
            this.btnDkiTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> Stashed changes
            this.btnDkiTK.Name = "btnDkiTK";
            this.btnDkiTK.Size = new System.Drawing.Size(196, 42);
            this.btnDkiTK.TabIndex = 12;
            this.btnDkiTK.Text = "Đăng ký ngay";
            this.btnDkiTK.Click += new System.EventHandler(this.btnDkiTK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< Updated upstream
            this.label2.Location = new System.Drawing.Point(538, 571);
=======
            this.label2.Location = new System.Drawing.Point(605, 755);
>>>>>>> Stashed changes
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chưa có tài khoản ?";
            // 
<<<<<<< Updated upstream
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(166, 76);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(719, 59);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Cùng bạn trên mọi nẻo đường ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(77, 18);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(480, 66);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "QB_TTH_KH ";
            // 
=======
>>>>>>> Stashed changes
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
<<<<<<< Updated upstream
            this.label3.Location = new System.Drawing.Point(276, 622);
=======
            this.label3.Location = new System.Drawing.Point(290, 819);
>>>>>>> Stashed changes
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(706, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Bạn sẽ chấp nhận các điều khoản của chúng tôi khi đăng nhập";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
<<<<<<< Updated upstream
            this.lblError.Location = new System.Drawing.Point(690, 447);
=======
            this.lblError.Location = new System.Drawing.Point(776, 591);
>>>>>>> Stashed changes
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(277, 22);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "*Tên đăng nhập hoặc mật khẩu sai";
            this.lblError.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 18;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
<<<<<<< Updated upstream
            this.btnLogin.Location = new System.Drawing.Point(646, 489);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btnLogin.Location = new System.Drawing.Point(727, 636);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> Stashed changes
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(308, 55);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login ";
            this.btnLogin.Click += new System.EventHandler(this.txtLogin_Click);
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.Color.White;
            this.txtPw.BorderColor = System.Drawing.Color.Black;
            this.txtPw.BorderRadius = 18;
            this.txtPw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPw.DefaultText = "";
            this.txtPw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPw.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.ForeColor = System.Drawing.Color.Black;
            this.txtPw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPw.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPw.IconLeft")));
            this.txtPw.IconLeftSize = new System.Drawing.Size(40, 40);
<<<<<<< Updated upstream
            this.txtPw.Location = new System.Drawing.Point(596, 366);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4);
=======
            this.txtPw.Location = new System.Drawing.Point(671, 499);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> Stashed changes
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.PlaceholderText = "Enter Password";
            this.txtPw.SelectedText = "";
            this.txtPw.Size = new System.Drawing.Size(400, 62);
            this.txtPw.TabIndex = 4;
            // 
            // txtUseName
            // 
            this.txtUseName.BackColor = System.Drawing.Color.White;
            this.txtUseName.BorderColor = System.Drawing.Color.Black;
            this.txtUseName.BorderRadius = 18;
            this.txtUseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUseName.DefaultText = "";
            this.txtUseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUseName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUseName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUseName.ForeColor = System.Drawing.Color.Black;
            this.txtUseName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUseName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUseName.IconLeft")));
            this.txtUseName.IconLeftSize = new System.Drawing.Size(40, 20);
<<<<<<< Updated upstream
            this.txtUseName.Location = new System.Drawing.Point(596, 264);
            this.txtUseName.Margin = new System.Windows.Forms.Padding(4);
=======
            this.txtUseName.Location = new System.Drawing.Point(671, 371);
            this.txtUseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
>>>>>>> Stashed changes
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.PasswordChar = '\0';
            this.txtUseName.PlaceholderText = "Enter User Name";
            this.txtUseName.SelectedText = "";
            this.txtUseName.Size = new System.Drawing.Size(400, 62);
            this.txtUseName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< Updated upstream
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use Login ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(132, 207);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(345, 278);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
=======
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(741, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = "Use Login ";
            // 
>>>>>>> Stashed changes
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
<<<<<<< Updated upstream
            this.btnClose.Location = new System.Drawing.Point(1149, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(56, 44);
=======
            this.btnClose.Location = new System.Drawing.Point(1278, 22);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(56, 47);
>>>>>>> Stashed changes
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 50;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(177, 325);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(332, 321);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 18;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Empty;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageSize = new System.Drawing.Size(500, 100);
            this.guna2Button5.Location = new System.Drawing.Point(76, 54);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(760, 146);
            this.guna2Button5.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1726, 882);
=======
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1840, 1090);
>>>>>>> Stashed changes
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private Guna.UI2.WinForms.Guna2TextBox txtUseName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPw;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnDkiTK;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}


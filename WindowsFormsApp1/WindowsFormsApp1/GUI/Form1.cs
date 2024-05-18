using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            {
                {
                    Application.Exit();
                }
            }
        }
        private bool login(string username, string password)
        {
            return TaiKhoanDAO.Instance.Login(username, password);
        }
        private void txtLogin_Click(object sender, EventArgs e)
        {

            string username = txtUseName.Text;
            string password = txtPw.Text;
            if (login(username, password))
            {
                if (username == "admin")
                {
                    //lblError.Visible = false;
                    BangDieuKhienAdmin bdkAdmin = new BangDieuKhienAdmin();
                    this.Hide();
                    bdkAdmin.ShowDialog();
                }
                else
                {
                    BangDieuKhien bangDieuKhien = new BangDieuKhien();
                    this.Hide();
                    bangDieuKhien.ShowDialog();
                }    
            }
            else lblError.Visible = true;
            txtPw.Clear();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDkiTK_Click(object sender, EventArgs e)
        {
            DangKiTaiKhoang dk=new DangKiTaiKhoang();   
            this.Hide();
            dk.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("intwf");
        }
    }
}

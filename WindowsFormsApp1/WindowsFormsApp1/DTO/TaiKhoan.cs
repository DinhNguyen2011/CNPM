using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class TaiKhoan
    {
        private int maTK;
        private string account;
        private string password;
        private int maKH;

        public int MaTK { get => maTK; set => maTK = value; }
        public string Account { get => account; set => account = value; }
        public string Password { get => password; set => password = value; }
        public int MaKH { get => maKH; set => maKH = value; }

        public TaiKhoan(int maTK, string account, string password, int maKH)
        {
            this.MaTK = maTK;
            this.Account = account;
            this.Password = password;
            this.MaKH = maKH;
        }
        public TaiKhoan() { }
        public TaiKhoan(DataRow row)
        {
            this.MaTK = (int)row["maTK"];
            this.Account = row["account"].ToString();
            this.Password = row["password"].ToString();
            this.MaKH = (int)row["maKH"];
        }

    }
}

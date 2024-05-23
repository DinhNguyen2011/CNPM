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
        private int manv;

        public int MaTK { get => maTK; set => maTK = value; }
        public string Account { get => account; set => account = value; }
        public int Manv { get => manv; set => manv = value; }

        public TaiKhoan(int maTK, string account, int manv)
        {
            this.MaTK = maTK;
            this.Account = account;
            this.Manv = manv;
        }

        public TaiKhoan(string account, int manv)
        {
            this.account = account;
            this.manv = manv;
        }

        public TaiKhoan() { }
        public TaiKhoan(DataRow row)
        {
            this.MaTK = (int)row["maTK"];
            this.Account = row["account"].ToString();
            this.manv = (int)row["manv"];
        }

    }
}

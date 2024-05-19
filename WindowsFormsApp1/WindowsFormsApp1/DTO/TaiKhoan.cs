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
        private int maKH;

        public int MaTK { get => maTK; set => maTK = value; }
        public string Account { get => account; set => account = value; }
        public int MaKH { get => maKH; set => maKH = value; }

        public TaiKhoan(int maTK, string account, int maKH)
        {
            this.MaTK = maTK;
            this.Account = account;
            this.MaKH = maKH;
        }

        public TaiKhoan(string account, int maKH)
        {
            this.account = account;
            this.maKH = maKH;
        }

        public TaiKhoan() { }
        public TaiKhoan(DataRow row)
        {
            this.MaTK = (int)row["maTK"];
            this.Account = row["account"].ToString();
            this.MaKH = (int)row["maKH"];
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class KhachHang
    {
        private int makh;
        private string tenkh;
        private DateTime? ngaysinh;
        private string sdt;
        private string email;

        public int Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }

        public KhachHang(int makh, string tenkh, DateTime? ngaysinh, string sdt, string email)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.email = email;
        }
        public KhachHang(DataRow row)
        {
            this.makh = (int)row["makh"];
            this.tenkh = row["tenkh"].ToString();
            this.ngaysinh = (DateTime?)row["ngaysinh"];
            this.sdt = row["sdt"].ToString();
            this.email = row["email"].ToString();
        }
        public KhachHang()
        {
        }
    }
}

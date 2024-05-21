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
        private string gioitinh;
        private string diachi;

        public int Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }

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
            this.sdt = row["sdt"].ToString().Trim();
            this.email = row["email"].ToString();
        }
        public KhachHang()
        {
            this.makh = 0;
            this.tenkh = "";
            this.ngaysinh = null;
            this.sdt = "";
            this.email = "";
            this.diachi = "";
            this.gioitinh = "Nam";
        }
    }
}

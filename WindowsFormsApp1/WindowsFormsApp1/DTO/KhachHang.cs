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
        private string tenkh;
        private DateTime? ngaysinh;
        private string sdt;
        private string email;
        private string gioitinh;
        private string diachi;
        private string ghichu;

        public string Tenkh { get => tenkh; set => tenkh = value; }
        public DateTime? Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        public KhachHang(string tenkh, DateTime? ngaysinh, string sdt, string email)
        {
            this.tenkh = tenkh;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.email = email;
            
        }
      
        public KhachHang()
        {
            this.tenkh = "";
            this.ngaysinh = null;
            this.sdt = "";
            this.email = "";
            this.diachi = "";
            this.gioitinh = "Nam";
            this.ghichu = "";
        }
    }
}

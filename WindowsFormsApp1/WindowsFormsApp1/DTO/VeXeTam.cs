using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class VeXeTam
    {
        private int ma;
        private string tenkh;
        private string sdt;
        private string giodi;
        private string tuyen;
        private string ghe;
        private string xe;
        private string trangthai;

        public VeXeTam(int ma, string tenkh, string sdt, string giodi, string tuyen, string ghe, string xe, string trangthai)
        {
            this.ma = ma;
            this.tenkh = tenkh;
            this.sdt = sdt;
            this.giodi = giodi;
            this.tuyen = tuyen;
            this.ghe = ghe;
            this.xe = xe;
            this.trangthai = trangthai;
        }

        public int Ma { get => ma; set => ma = value; }
        public string TenKH { get => tenkh; set => tenkh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Giodi { get => giodi; set => giodi = value; }
        public string Tuyen { get => tuyen; set => tuyen = value; }
        public string Ghe { get => ghe; set => ghe = value; }
        public string Xe { get => xe; set => xe = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}

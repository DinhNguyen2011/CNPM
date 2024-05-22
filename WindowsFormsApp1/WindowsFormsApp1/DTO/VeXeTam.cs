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
        private string nguoiDat;
        private string sdt;
        private string giodi;
        private string tuyen;
        private string ghe;
        private string xe;

        public VeXeTam(int ma, string nguoiDat, string sdt, string giodi, string tuyen, string ghe, string xe)
        {
            this.ma = ma;
            this.nguoiDat = nguoiDat;
            this.sdt = sdt;
            this.giodi = giodi;
            this.tuyen = tuyen;
            this.ghe = ghe;
            this.xe = xe;
        }

        public int Ma { get => ma; set => ma = value; }
        public string NguoiDat { get => nguoiDat; set => nguoiDat = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Giodi { get => giodi; set => giodi = value; }
        public string Tuyen { get => tuyen; set => tuyen = value; }
        public string Ghe { get => ghe; set => ghe = value; }
        public string Xe { get => xe; set => xe = value; }
    }
}

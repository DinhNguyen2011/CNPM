using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class VeXe
    {
        private int mave;
        private string tenve;
        private string ghichu;
        private int mactvx;
        private int machuyen;
        private int makh;

        public int Mave { get => mave; set => mave = value; }
        public string Tenve { get => tenve; set => tenve = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public int Mactvx { get => mactvx; set => mactvx = value; }
        public int Machuyen { get => machuyen; set => machuyen = value; }
        public int Makh { get => makh; set => makh = value; }

        public VeXe(int mave, string tenve, string ghichu, int mactvx, int machuyen, int makh)
        {
            this.mave = mave;
            this.tenve = tenve;
            this.ghichu = ghichu;
            this.mactvx = mactvx;
            this.machuyen = machuyen;
            this.makh = makh;
        }

        public VeXe(string tenve, string ghichu, int mactvx, int machuyen, int makh)
        {
            this.tenve = tenve;
            this.ghichu = ghichu;
            this.mactvx = mactvx;
            this.machuyen = machuyen;
            this.makh = makh;
        }

        public VeXe()
        {
        }
        public VeXe(DataRow row)
        {
            this.mave = (int)row["mave"];
            this.tenve = row["tenve"].ToString();
            this.ghichu = row["ghichu"].ToString(); ;
            this.mave = (int)row["mactvx"];
            this.machuyen = (int)row["machuyen"];
            this.makh = (int)row["makh"];
        }
    }
}

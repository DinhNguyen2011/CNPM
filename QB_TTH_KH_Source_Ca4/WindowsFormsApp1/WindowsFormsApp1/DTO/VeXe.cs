using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.DTO
{
    public class VeXe
    {
        private int mave;
        private string tenve;
        private string ghichu;
        private string tenkh;
        private string sdtkh;
        private int mactvx;
        private int machuyen;
        private int manv;

        public int Mave { get => mave; set => mave = value; }
        public string Tenve { get => tenve; set => tenve = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Sdtkh { get => sdtkh; set => sdtkh = value; }
        public int Mactvx { get => mactvx; set => mactvx = value; }
        public int Machuyen { get => machuyen; set => machuyen = value; }
        public int Manv { get => manv; set => manv = value; }
        public string TenNV { get => NhanVienDAO.Instance.getTenNVbyID(Manv); }

        public VeXe(int mave, string tenve, string ghichu, string tenkh, string sdtkh, int mactvx, int machuyen, int manv)
        {
            this.mave = mave;
            this.tenve = tenve;
            this.ghichu = ghichu;
            this.tenkh = tenkh;
            this.sdtkh = sdtkh;
            this.mactvx = mactvx;
            this.machuyen = machuyen;
            this.manv = manv;
        }

        public VeXe(string tenve, string ghichu, string tenkh, string sdtkh, int mactvx, int machuyen, int manv)
        {
            this.tenve = tenve;
            this.ghichu = ghichu;
            this.tenkh = tenkh;
            this.sdtkh = sdtkh;
            this.mactvx = mactvx;
            this.machuyen = machuyen;
            this.manv = manv;
        }

        public VeXe()
        {

        }
        public VeXe(DataRow row)
        {
            this.mave = (int)row["mave"];
            this.tenve = row["tenve"].ToString();
            this.ghichu = row["ghichu"].ToString();
            this.tenkh = row["tenkh"].ToString();
            this.sdtkh = row["sdtkh"].ToString();
            this.mactvx = (int)row["mactvx"];
            this.machuyen = (int)row["machuyen"];
            this.manv = (int)row["manv"];
        }
    }
}

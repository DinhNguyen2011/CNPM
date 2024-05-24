using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class ChiTietVeXe
    {
        private int mactvx;
        private string giodi;
        private string gioden;
        private string vitrighe;
        private double giave;
        private string trangthai;
        private int maxe;
        private int mave;

        public int Mactvx { get => mactvx; set => mactvx = value; }
        public string Giodi { get => giodi; set => giodi = value; }
        public string Gioden { get => gioden; set => gioden = value; }
        public string Vitrighe { get => vitrighe; set => vitrighe = value; }
        public double Giave { get => giave; set => giave = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Maxe { get => maxe; set => maxe = value; }
        public int Mave { get => mave; set => mave = value; }

        public ChiTietVeXe(int mactvx, string giodi, string gioden, string vitrighe, double giave, string trangthai, int maxe, int mave)
        {
            this.mactvx = mactvx;
            this.giodi = giodi;
            this.gioden = gioden;
            this.vitrighe = vitrighe;
            this.giave = giave;
            this.trangthai = trangthai;
            this.maxe = maxe;
            this.mave = mave;
        }

        public ChiTietVeXe(string giodi, string gioden, string vitrighe, double giave, string trangthai, int maxe, int mave)
        {
            this.giodi = giodi;
            this.gioden = gioden;
            this.vitrighe = vitrighe;
            this.giave = giave;
            this.trangthai = trangthai;
            this.maxe = maxe;
            this.mave = mave;
        }

        public ChiTietVeXe()
        {
        }
        public ChiTietVeXe(DataRow row)
        {
            this.mactvx = (int)row["mactvx"];
            this.giodi = row["giodi"].ToString();
            this.gioden = row["gioden"].ToString();
            this.vitrighe = row["vitrighe"].ToString();
            this.giave = Convert.ToDouble(row["giave"]);
            this.trangthai = row["trangthai"].ToString();
            this.maxe = (int)row["maxe"];
            this.mave = (int)row["mave"];
        }
    }
}

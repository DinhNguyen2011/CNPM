using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class Xe
    {
        private int maxe;
        private string tenxe;
        private string bienso;
        private int soghe;

        public Xe(int maxe, string tenxe, string bienso, int soghe)
        {
            this.maxe = maxe;
            this.tenxe = tenxe;
            this.bienso = bienso;
            this.soghe = soghe;
        }

        public Xe(string tenxe, string bienso, int soghe)
        {
            this.tenxe = tenxe;
            this.bienso = bienso;
            this.soghe = soghe;
        }

        public Xe()
        {
            this.tenxe = "";
            this.bienso = "";
            this.soghe = 0;
        }
        public Xe(DataRow row)
        {
            this.maxe = (int)row["maxe"];
            this.tenxe = row["tenxe"].ToString();
            this.bienso = row["bienso"].ToString();
            this.soghe = (int)row["soghe"];
        }


        public int Maxe { get => maxe; set => maxe = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public string Bienso { get => bienso; set => bienso = value; }
        public int Soghe { get => soghe; set => soghe = value; }
    }
}

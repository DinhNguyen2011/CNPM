using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class TuyenXe
    {
        private int matuyen;
        private string diemdi;
        private string diemden;

        public int Matuyen { get => matuyen; set => matuyen = value; }
        public string Diemdi { get => diemdi; set => diemdi = value; }
        public string Diemden { get => diemden; set => diemden = value; }
        public TuyenXe() { }

        public TuyenXe(int matuyen, string diemdi, string diemden)
        {
            this.matuyen = matuyen;
            this.diemdi = diemdi;
            this.diemden = diemden;
        }
        public TuyenXe(DataRow row)
        {
            this.matuyen = (int)row["matuyen"];
            this.diemdi = row["diemdi"].ToString();
            this.diemden = row["diemden"].ToString();
        }

        public TuyenXe(string diemdi, string diemden)
        {
            this.diemdi = diemdi;
            this.diemden = diemden;
        }
    }
}

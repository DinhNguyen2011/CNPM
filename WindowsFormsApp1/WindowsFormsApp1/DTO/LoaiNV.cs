using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class LoaiNV
    {
        private int maloainv;
        private string tenloai;

        public int Maloainv { get => maloainv; set => maloainv = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }

        public LoaiNV(int maloainv, string tenloai)
        {
            this.maloainv = maloainv;
            this.tenloai = tenloai;
        }

        public LoaiNV()
        {
        }

        public LoaiNV(string tenloai)
        {
            this.tenloai = tenloai;
        }
        public LoaiNV(DataRow row)
        {
            this.maloainv = (int)row["maloainv"];
            this.tenloai = row["tenloai"].ToString();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class LichTrinh
    {
        private int m_ma;
        private DateTime? m_giodi;
        private DateTime? m_gioden; 
        private string m_diemdi;
        private string m_diemden;
        private double? m_giatien;

        public LichTrinh()
        {
            m_ma = 0;
            m_diemdi = "";
            m_diemden = "";
        }

        public LichTrinh(int ma, DateTime? giodi, DateTime? gioden, string diemdi, string diemden, double? giatien)
        {
            m_ma = ma;
            m_giodi = giodi;
            m_gioden = gioden;
            m_diemdi = diemdi;
            m_diemden = diemden;
            m_giatien = giatien;
        }

        public int Ma { get => m_ma; set => m_ma = value; }
        public string DiemDi { get => m_diemdi; set => m_diemdi = value; }
        public string DiemDen { get => m_diemden; set => m_diemden = value; }
        public DateTime? Giodi { get => m_giodi; set => m_giodi = value; }
        public DateTime? Gioden { get => m_gioden; set => m_gioden = value; }
        public double? Giatien { get => m_giatien; set => m_giatien = value; }
    }
}

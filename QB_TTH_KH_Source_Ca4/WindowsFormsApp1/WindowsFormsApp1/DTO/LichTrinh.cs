using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public class LichTrinh
    {
        private int m_ma;
        private String m_giodi;
        private String m_gioden; 
        private string m_diemdi;
        private string m_diemden;
        private double? m_giatien;

        public LichTrinh()
        {
            m_ma = 0;
            m_diemdi = "";
            m_diemden = "";
        }

        public LichTrinh(DataRow row)
        {
            m_ma = Convert.ToInt32(row["MACHUYEN"]);
            m_giodi =row["GIODI"].ToString();
            m_gioden = row["GIODEN"].ToString();
            m_diemdi = row["DIEMDI"].ToString();
            m_diemden = row["DIEMDEN"].ToString();
            m_giatien = Convert.ToDouble(row["GIAVE"]);
        }

        public int Ma { get => m_ma; set => m_ma = value; }
        public string DiemDi { get => m_diemdi; set => m_diemdi = value; }
        public string DiemDen { get => m_diemden; set => m_diemden = value; }
        public String Giodi { get => m_giodi; set => m_giodi = value; }
        public String Gioden { get => m_gioden; set => m_gioden = value; }
        public double? Giatien { get => m_giatien; set => m_giatien = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    internal class LichTrinhDAO
    {
        private static LichTrinhDAO instance;
        public LichTrinhDAO() { }

        public static LichTrinhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichTrinhDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public List<LichTrinh> getData()
        {
            string query = "dslichtrinh";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            List<LichTrinh> list = new List<LichTrinh>();
            foreach (DataRow row in data.Rows)
            {
                int ma = Convert.ToInt32(row["MACHUYEN"]);
                DateTime? giodi = Convert.ToDateTime(row["GIODI"]);
                DateTime? gioden = Convert.ToDateTime(row["GIODEN"]);
                string diemdi = row["DIEMDI"].ToString();
                string diemden = row["DIEMDEN"].ToString();
                double giatien = Convert.ToDouble(row["GIAVE"]);
                list.Add(new LichTrinh(ma,giodi, gioden, diemdi,diemden , giatien));
            }
            return list;
        }
    }
}

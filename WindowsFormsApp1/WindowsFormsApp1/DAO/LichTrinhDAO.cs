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
                list.Add(new LichTrinh(row));
            return list;
        }
    }
}

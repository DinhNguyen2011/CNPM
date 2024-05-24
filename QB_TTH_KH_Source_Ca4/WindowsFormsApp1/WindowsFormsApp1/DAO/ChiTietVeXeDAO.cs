using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class ChiTietVeXeDAO
    {
        private static ChiTietVeXeDAO instance;

        public ChiTietVeXeDAO()
        {
        }
        public static ChiTietVeXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChiTietVeXeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public List<ChiTietVeXe> getDSChiTietVeXe()
        {
            List<ChiTietVeXe> list = new List<ChiTietVeXe>();
            string query = "DSCHITIETVEXE";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
             foreach (DataRow item in result.Rows)
            {
                ChiTietVeXe ctvx = new ChiTietVeXe(item);
                list.Add(ctvx);
            }
            return list;
        }
        public ChiTietVeXe TimCTVXBangMaVe(int mave)
        {
            ChiTietVeXe ctvx = null;
            string query = "TimCTVXBangMaVe @mave";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { mave });
            ctvx = new ChiTietVeXe(result.Rows[0]);
            return ctvx;
        }
    }
}

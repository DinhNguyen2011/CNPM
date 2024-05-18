using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class TuyenXeDAO
    {
        private static TuyenXeDAO instance;

        public TuyenXeDAO()
        {
        }
        public static TuyenXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TuyenXeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getDSTuyenXe()
        {
            string query = "DSTUYENXE";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result;
        }
    }
}

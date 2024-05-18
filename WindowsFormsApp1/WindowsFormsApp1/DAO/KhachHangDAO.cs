using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public KhachHangDAO()
        {
        }
        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getDSKhachHang()
        {
            string query = "DSKHACHHANG";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result;
        }
    }
}

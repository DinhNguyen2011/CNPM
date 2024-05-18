using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public NhanVienDAO()
        {
        }
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable getDSNhanVien()
        {
            string query = "DSNHANVIEN";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            return result;
        }
    }
}

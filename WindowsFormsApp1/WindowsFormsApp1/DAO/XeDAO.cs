using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class XeDAO
    {
        private static XeDAO instance;

        public XeDAO()
        {
        }
        public static XeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public List<Xe> getDSXe()
        {
            List<Xe> list = new List<Xe>();
            string query = "DSXE";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                Xe x = new Xe(item);
                list.Add(x);
            }
            return list;
        }
        public int themXe(Xe x)
        {
            int result = 0;
            try
            {
                string query = "THEMXE @tenxe , @bienso , @soghe";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { x.Tenxe, x.Bienso, x.Soghe });
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Trùng biển số xe, không thể thêm' "))
                    MessageBox.Show("Trùng biển số xe, không thể thêm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    throw e;
            }
            return result;
        }
        public int xoaXe(int ma)
        {
            int result = 0;
            try
            {
                string query = "XOAXE @ma";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            }
            catch (SqlException e)
            {
                throw e;
            }
            return result;
        }
        public int suaXe(Xe x) 
        {
            int result = 0;
            try
            {
                string query = "SUATHONGTINXE @maxe , @tenxe , @soghe";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { x.Maxe, x.Tenxe, x.Soghe });
            }
            catch (SqlException e)
            {
                throw e;
            }
            return result;
        }
    }
}

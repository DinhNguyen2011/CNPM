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
                string query = "THEMXE @tenxe , @bienso";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { x.Tenxe, x.Bienso});
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Trùng biển số xe, không thể thêm' "))
                    MessageBox.Show("Trùng biển số xe, không thể thêm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Xe đang hoạt động'"))
                    MessageBox.Show("Xe đang hoạt động", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public int suaXe(Xe x) 
        {
            int result = 0;
            try
            {
                string query = "SUATHONGTINXE @maxe , @tenxe";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { x.Maxe, x.Tenxe});
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Xe đang hoạt động'"))
                    MessageBox.Show("Xe đang hoạt động", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public List<string> DSBienSo()
        {
            List<string> list = new List<string>();
            string query = "select BIENSO from XE";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                string bienso = item["bienso"].ToString();
                list.Add(bienso);
            }
            return list;
        }
        public List<Xe> TimXe(string bienso)
        {
            List<Xe> list = new List<Xe>();
            string query = "TIMXE '" + bienso + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                Xe x = new Xe(item);
                list.Add(x);
            }
            return list;
        }
        public string getBienSoByID(int ma)
        {
            string bienso = "";
            string query = "select BIENSO  from xe where MAXE = " + ma;
            bienso = DataProvider.Instance.ExcuteScalar(query).ToString();
            return bienso;
        }
        public int getIDByBienSo(string bienso)
        {
            int maxe = -1;
            string query = "select MAXE  from xe where BIENSO = N'" + bienso+"'";
            maxe = (int)DataProvider.Instance.ExcuteScalar(query);
            return maxe;
        }
    }
}

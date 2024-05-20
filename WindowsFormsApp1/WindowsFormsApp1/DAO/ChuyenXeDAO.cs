using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class ChuyenXeDAO
    {
        private static ChuyenXeDAO instance;

        public ChuyenXeDAO()
        {

        }
        public static ChuyenXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChuyenXeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public List<ChuyenXe> getDSChuyenXe()
        {
            List<ChuyenXe> list = new List<ChuyenXe>();
            string query = "DSCHUYENXE";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                ChuyenXe c = new ChuyenXe(item);
                list.Add(c);
            }
            return list;
        }
        public int themChuyenXe(ChuyenXe c)
        {
            int result = 0;
            try
            {
                string query = "THEMCHUYENXE @tenchuyen , @giodi , @gioden , @giave , @mataixe , @matuyen";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { c.Tenchuyen, c.Giodi, c.Gioden, c.Giave, c.Mataixe, c.Matuyen });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}

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
                string query = "THEMCHUYENXE @tenchuyen , @giodi , @gioden , @giave , @mataixe , @matuyen , @maxe";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { c.Tenchuyen, c.Giodi, c.Gioden, c.Giave, c.Mataixe, c.Matuyen, c.Maxe });
            }
            catch (Exception e)
            {
                if(e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Giờ đi không hợp lệ' "))
                {
                    MessageBox.Show("Giờ đi không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Giờ đến không được bé hơn hoặc bằng giờ đi'"))
                {
                    MessageBox.Show("Thời gian đến không được nhỏ hơn hoặc bằng thời gian đi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Chuyến đã tồn tại' "))
                {
                    MessageBox.Show("Chuyến xe đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    //throw e;
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public int xoaChuyenXe(int ma)
        {
            int result = 0;
            try
            {
                string query = "XOACHUYENXE @ma";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Không thể xóa! Chuyến xe đã được đặt vé'"))
                {
                    MessageBox.Show("Không thể xóa! Chuyến xe đã được đặt vé", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public int suaChuyenXe(ChuyenXe c)
        {
            int result = 0;
            try
            {
                string query = "SUATHONGTINCHUYENXE @machuyen , @tenchuyen , @giodi , @gioden , @giave , @mataixe , @maxe";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { c.Machuyen, c.Tenchuyen, c.Giodi, c.Gioden, c.Giave, c.Mataixe, c.Maxe });
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Giờ đi không hợp lệ'"))
                {
                    MessageBox.Show("Giờ đi không hợp lệ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Giờ đến không được bé hơn hoặc bằng giờ đi'"))
                {
                    MessageBox.Show("Thời gian đến không được nhỏ hơn hoặc bằng thời gian đi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public List<ChuyenXe> Tim_DSChuyenXe_TheoGioDi_TenTuyen(string giodi, int matuyen)
        {
            List<ChuyenXe> list = new List<ChuyenXe>();
            string query = "select * from CHUYENXE where GIODI = '"+giodi+"' and MATUYEN = " +matuyen;
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                ChuyenXe c = new ChuyenXe(item);
                list.Add(c);
            }
            return list;
        }
    }
}

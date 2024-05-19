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
    public class LoaiNVDAO
    {
        private static LoaiNVDAO instance;
        public LoaiNVDAO()
        {
        }
        public static LoaiNVDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiNVDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public List<LoaiNV> getDSLoaiNV()
        {
            List<LoaiNV> list = new List<LoaiNV>();
            string query = "DSLOAINV";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                LoaiNV l = new LoaiNV(item);
                list.Add(l);
            }
            return list;
        }
        public int themLoaiNV(LoaiNV l)
        {
            int result = 0;
            try
            {
                string query = "THEMLOAINV @tenloai";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {l.Tenloai});
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Trùng loại nv' "))
                    MessageBox.Show("Đã có loại nhân viên này, không thể thêm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    throw e;
            }
            return result;
        }
        public int xoaLoaiNV(int ma)
        {
            int result = 0;
            try
            {
                string query = "XOALOAINV @ma";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Tồn tại nv thuộc loại cần xóa' "))
                    MessageBox.Show("Tồn tại nhân viên thuộc loại này, không thể xóa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    throw e;
            }
            return result;
        }
    }
}

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
        public List<KhachHang> getDSKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "DSKHACHHANG";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                KhachHang kh = new KhachHang(item);
                list.Add(kh);
            }
            return list;
        }
        public int xoaKhachHang(int ma)
        {
            int result = 0;
            try
            {
                string query = "XOAKHACHHANG @ma";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            }
            catch (SqlException e)
            {
                throw e;
            }
            return result;
        }
        public List<KhachHang> timKhachHangTheoTen(string tenkh)
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "TIMKHACHHANGTHEOTEN N'" + tenkh +"'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                KhachHang kh = new KhachHang(item);
                list.Add(kh);
            }
            return list;
        }
    }
}

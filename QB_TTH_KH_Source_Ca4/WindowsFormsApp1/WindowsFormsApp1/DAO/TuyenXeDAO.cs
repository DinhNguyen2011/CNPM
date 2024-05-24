using Guna.UI2.WinForms;
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
        public List<TuyenXe> getDSTuyenXe()
        {
            List<TuyenXe> list = new List<TuyenXe>();
            string query = "DSTUYENXE";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                TuyenXe tx = new TuyenXe(item);
                list.Add(tx);
            }
            return list;
        }
        public int themTuyenXe(TuyenXe tx)
        {
            int result = 0;
            try
            {
                string query = "THEMTUYENXE @diemdi , @diemden";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { tx.Diemdi, tx.Diemden });
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Tuyến xe đã tồn tại!' "))
                    MessageBox.Show("Tuyến xe đã tồn tại", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public int xoaTuyenxe(int ma)
        {
            int result = 0;
            try
            {
                string query = "XOATUYENXE @ma";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Tuyến xe đang có chuyến hoạt động'"))
                    MessageBox.Show("Tuyến xe đang có chuyến hoạt động", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public List<String> getDsDiemDi()
        {
            List<String> list = new List<String>();
            DataTable data = DataProvider.Instance.ExcuteQuery("dsdiemdi");
            foreach (DataRow row in data.Rows) 
            {
                list.Add(row["diemdi"] + "");
            }
            return list;
        }

        public List<String> getDsDiemDen()
        {
            List<String> list = new List<String>();
            DataTable data = DataProvider.Instance.ExcuteQuery("dsdiemden");
            foreach (DataRow row in data.Rows)
            {
                list.Add(row["diemden"] + "");
            }
            return list;
        }
        public List<TuyenXe> timTuyenXe(string diemdi, string diemden)
        {
            List<TuyenXe> list = new List<TuyenXe>();
            string query = "TIMTUYENXE N'" + diemdi + "', N'" + diemden + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                TuyenXe t = new TuyenXe(item);
                list.Add(t);
            }
            return list;
        }
        public List<string> getDSTenTuyenXe()
        {
            List<string> listTenTuyen = new List<string>();
            List<TuyenXe> list = getDSTuyenXe();
            foreach (var item in list)
            {
                string tentuyen = item.Diemdi + "-" + item.Diemden;
                listTenTuyen.Add(tentuyen);
            }
            return listTenTuyen;
        }
        public string getTenTuyenXeByID(int ma)
        {
            string tentuyen = "";
            string query = "select MATUYEN, DIEMDI, DIEMDEN from TUYENXE where MATUYEN = " + ma;
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            TuyenXe t = new TuyenXe(result.Rows[0]);
            tentuyen = t.Diemdi + "-" + t.Diemden;
            return tentuyen;
        }
        public int getIDByTuyenXe(string diemdi, string diemden)
        {
            int maloai = -1;
            string query = "select MATUYEN from TUYENXE where DIEMDI = N'" +diemdi +"' and DIEMDEN = N'" + diemden +"'";
            maloai = (int)DataProvider.Instance.ExcuteScalar(query);
            return maloai;
        }

    }
}

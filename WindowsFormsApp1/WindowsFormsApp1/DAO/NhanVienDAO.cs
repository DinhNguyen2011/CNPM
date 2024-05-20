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
        public List<NhanVien> getDSNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "DSNHANVIEN";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }
        public int themNhanVien(NhanVien nv)
        {
            int result = 0;
            try
            {
                string query = "THEMNHANVIEN @tennv , @cmnd , @sdt , @email , @maloainv";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { nv.Tennv, nv.CMND, nv.Sdt, nv.Email, nv.Maloainv });
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("Conversion failed when converting the nvarchar value 'Trùng CMND'"))
                    MessageBox.Show("Trùng CCCD, không thể thêm", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public int xoaNhanVien(int ma)
        {
            int result = 0;
            try
            {
                string query = "XOANHANVIEN @ma";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { ma });
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public int suaNhanVien(NhanVien nv)
        {
            int result = 0;
            try
            {
                string query = "SUATHONGTINNV @manv , @tennv , @sdt , @email , @maloainv";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { nv.Manv, nv.Tennv, nv.Sdt, nv.Email, nv.Maloainv });
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public List<NhanVien> timNhanVienTheoTen(string tennv)
        {
            List<NhanVien> list = new List<NhanVien>();
            string query = "TIMNHANVIENTHEOTEN N'" + tennv + "'";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                NhanVien nv = new NhanVien(item);
                list.Add(nv);
            }
            return list;
        }
    }
}

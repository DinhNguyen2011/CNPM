using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; //khai báo kiến trúc singleton
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }
        public DataProvider() { }
        private static string connectionSTR = "Data Source=MinhNghia;Initial Catalog=QuanLyBanVeXe;Integrated Security=True";
        //Thay đổi Data Source= <tên host trên máy> để kết nối vào Database trên máy localhost
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        //ExcuteNonQuery dùng cho insert, update, delete
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    int i = 0;
                    string[] listPara = query.Split(' ');
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}

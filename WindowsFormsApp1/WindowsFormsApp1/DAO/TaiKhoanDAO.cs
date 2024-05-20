using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public TaiKhoanDAO()
        {
        }
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public List<TaiKhoan> getDSTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            string query = "DSTAIKHOAN";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                TaiKhoan tk = new TaiKhoan(item);
                list.Add(tk);
            }
            return list;
        }
        public string maHoaPassword(string passWord)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";
            foreach (byte item in hashData)
            {
                hashPass += item;
            }
            return hashPass;
        }
        public bool Login(string userName, string passWord)
        {
            string hashPass = maHoaPassword(passWord);


            string query = "DANGNHAP @userName , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, hashPass });

            return result.Rows.Count > 0;
        }
        public bool Register(string tenkh, DateTime ngaysinh, string sdt, string email, string taikhoan, string matkhau)
        {
            string hashPass = maHoaPassword(matkhau);
            string query = "DANGKY @tenkh , @ngaysinh , @sdt , @email , @taikhoan , @matkhau";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {tenkh, ngaysinh, sdt, email, taikhoan, hashPass });

            return result > 0;
        }
        public TaiKhoan findTaiKhoanByMaKH(KhachHang kh)
        {
            TaiKhoan tk = null;
            string query = "FindAccountByMaKH @makh";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {kh.Makh});
            foreach (DataRow item in result.Rows)
            {
                tk = new TaiKhoan(item);
            }
            return tk;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public AccountDAO()
        {
        }
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public bool Login(string userName, string passWord)
        {
            string query = "EXEC DANGNHAP @userName , @passWord";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[]{userName,passWord});

            return result.Rows.Count > 0;
        }

    }
}

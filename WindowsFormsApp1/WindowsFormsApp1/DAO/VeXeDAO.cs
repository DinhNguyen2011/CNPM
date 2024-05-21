using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class VeXeDAO
    {
        private static VeXeDAO instance;

        public VeXeDAO()
        {
        }
        public static VeXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VeXeDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public List<VeXe> getDSVeXe()
        {
            List<VeXe> list = new List<VeXe>();
            string query = "DSVEXE";
            DataTable result = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                VeXe v = new VeXe(item);
                list.Add(v);
            }
            return list;
        }
    }
}

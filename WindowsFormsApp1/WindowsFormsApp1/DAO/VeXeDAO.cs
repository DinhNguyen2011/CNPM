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
        public int xoaVeXe(int mave)
        {
            int result = 0;
            try
            {
                string query = "HUYVEXE @mave";
                result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { mave });
            }
            catch (Exception e)
            {
                    MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public List<VeXe> timDSVeXetheoTenKH(string tenkh)
        {
            List<VeXe> list = new List<VeXe>();
            string query = "TIMKHACHHANGTHEOTEN_VEXE @tenkh";
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {tenkh});
            foreach (DataRow item in result.Rows)
            {
                VeXe v = new VeXe(item);
                list.Add(v);
            }
            return list;
        }

    }
}

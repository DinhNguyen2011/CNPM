using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.DTO
{
    public class NhanVien
    {
        private int manv;
        private string tennv;
        private string cmnd;
        private string sdt;
        private string email;
        private int maloainv;

        public int Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string CMND { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public int Maloainv { get => maloainv; set => maloainv = value; }
        public string tenloainv
        {
            get => LoaiNVDAO.Instance.getTenLoaiByID(maloainv);
        }

        public NhanVien(int manv, string tennv, string cMND, string sdt, string email, int maloainv)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.cmnd = cMND;
            this.sdt = sdt;
            this.email = email;
            this.maloainv = maloainv;
        }

        public NhanVien(string tennv, string cMND, string sdt, string email, int maloainv)
        {
            this.tennv = tennv;
            this.cmnd = cMND;
            this.sdt = sdt;
            this.email = email;
            this.maloainv = maloainv;
        }

        public NhanVien(DataRow row)
        {
            this.manv = (int)row["manv"];
            this.tennv = row["tennv"].ToString();
            this.cmnd = row["cmnd"].ToString();
            this.sdt = row["sdt"].ToString();
            this.email = row["email"].ToString();
            this.maloainv = (int)row["maloainv"];
        }

    }
}

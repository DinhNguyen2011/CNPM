using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.DTO
{
    public class ChuyenXe
    {
        private int machuyen;
        private string tenchuyen;
        private string giodi;
        private string gioden;
        private double giave;
        private int matuyen;
        private int mataixe;

        public int Machuyen { get => machuyen; set => machuyen = value; }
        public string Tenchuyen { get => tenchuyen; set => tenchuyen = value; }
        public string Giodi { get => giodi; set => giodi = value; }
        public string Gioden { get => gioden; set => gioden = value; }
        public int Matuyen { get => matuyen; set => matuyen = value; }
        public int Mataixe { get => mataixe; set => mataixe = value; }
        public double Giave { get => giave; set => giave = value; }
        public string Tentaixe { get => NhanVienDAO.Instance.getTenNVbyID(mataixe); }
        public string Tentuyen { get => TuyenXeDAO.Instance.getTenTuyenXeByID(matuyen); }
        public ChuyenXe(int machuyen, string tenchuyen, string giodi, string gioden, double giave, int matuyen, int mataixe)
        {
            this.machuyen = machuyen;
            this.tenchuyen = tenchuyen;
            this.giodi = giodi;
            this.gioden = gioden;
            this.giave = giave;
            this.matuyen = matuyen;
            this.mataixe = mataixe;
        }

        public ChuyenXe(string tenchuyen, string giodi, string gioden, double giave, int matuyen, int mataixe)
        {
            this.tenchuyen = tenchuyen;
            this.giodi = giodi;
            this.gioden = gioden;
            this.giave = giave;
            this.matuyen = matuyen;
            this.mataixe = mataixe;
        }

        public ChuyenXe()
        {
        }
        public ChuyenXe(DataRow row)
        {
            this.machuyen = (int)row["machuyen"];
            this.tenchuyen = row["tenchuyen"].ToString();
            this.giodi = row["giodi"].ToString();
            this.gioden = row["gioden"].ToString();
            this.giave = Convert.ToDouble(row["giave"]);
            this.matuyen = (int)row["matuyen"];
            this.mataixe = (int)row["mataixe"];
        }
    }
}

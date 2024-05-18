using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.KiemSoatUser
{
    public partial class UserLichTrinh : UserControl
    {
        private List<LichTrinh> tuyenXeList = null;
        public UserLichTrinh()
        {
            InitializeComponent();
            tuyenXeList = new LichTrinhDAO().getData();
            dgvLichTrinh.DataSource = tuyenXeList;
        }

        
    }
}

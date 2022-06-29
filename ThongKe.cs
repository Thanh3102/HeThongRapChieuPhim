using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void ThongKe_Load(object sender, EventArgs e)
        {
            ChartThongKe.Series["Vé"].Points.AddXY("A", "1");
            ChartThongKe.Series["Vé"].Points.AddXY("B", "5");
            ChartThongKe.Series["Vé"].Points.AddXY("C", "2");
            ChartThongKe.Series["Vé"].Points.AddXY("D", "8");
        }
    }
}

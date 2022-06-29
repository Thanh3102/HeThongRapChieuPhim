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
            conn = new SqlConnection(DangNhap.connectionString);
            conn.Open();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            if (cb_filterType.Text == "")
            {
                MessageBox.Show("Chưa chọn loại thống kê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (cb_filterType.SelectedIndex == 0)
                {
                    ChartThongKe.Visible = true;
                    lb_ChonThang.Visible = true;
                    cb_ChonThang.Visible = true;
                    cb_ChonThang.SelectedIndex = 0;
                    loadThongKeNgay("6");
                }
            }

/*            DataTable dt = new DataTable();
            dt.Columns.Add("Ngay");
            dt.Columns.Add("DoanhThu");
            dt.Columns.Add("DoanhThuSP");
            dt.Rows.Add("1", "15000000", "23000000");
            dt.Rows.Add("2", "18700000", "15000000");
            dt.Rows.Add("3", "35000000", "53000000");
            dt.Rows.Add("4", "65000000", "13000000");
            dt.Rows.Add("5", "10000000", "22000000");
            ChartThongKe.DataSource = dt;
            foreach(DataRow dr in dt.Rows)
            {
                ChartThongKe.Series["Vé"].Points.AddXY(dr.Field<string>("Ngay"), dr.Field<string>("DoanhThu"));
                ChartThongKe.Series["Sản phẩm"].Points.AddXY(dr.Field<string>("Ngay"), dr.Field<string>("DoanhThuSP"));
            }
            ChartThongKe.ChartAreas[0].AxisX.Title = "Ngày";
            ChartThongKe.ChartAreas[0].AxisY.Title = "VNĐ";*/


        }
        private void loadThongKeNgay(string Thang)
        {
           SqlDataAdapter adapter = null;
           for(int i = 1; i < 31; i++)
            {
                string query = "Select SUM(ThanhTien) as TongTien from HoaDon where Month(NgayTao) = " + Thang + " and day(NgayTao) = " + i.ToString();
                adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    object value = row["TongTien"];
                    if (value == DBNull.Value)
                    {
                        ChartThongKe.Series["Sản phẩm"].Points.AddXY(i.ToString(), "0"); 
                    }
                    else
                    {
                        ChartThongKe.Series["Sản phẩm"].Points.AddXY(i.ToString(), dt.Rows[0].Field<Decimal>("TongTien"));
                    }
                }
/*                ChartThongKe.Series["Sản phẩm"].Points.AddXY(i.ToString(), dt.Rows[0].Field<double>("TongTien"));*/
            }
        }

        private void cb_ChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            if (cb_filterType.SelectedIndex == 0)
            {
                loadThongKeNgay(cb_ChonThang.Text);
            }*/
        }
    }
}

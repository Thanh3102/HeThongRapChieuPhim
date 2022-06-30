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
using System.Windows.Forms.DataVisualization.Charting;

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
                    lb_ChonThang.Visible = true;
                    cb_ChonThang.Visible = true;
                    lb_Thang.Visible = false;
                    cb_Thang.Visible = false;
                    dateTime_Ngay.Visible = true;
                    lb_Ngay.Visible = true;
                    cb_ChonThang.SelectedIndex = 0;
                    loadThongKeNgay("1");
                    loadChiTietPhimNgay(dateTime_Ngay.Value);
                    loadChiTietSanPhamNgay(dateTime_Ngay.Value);
                }
                else
                {
                    lb_ChonThang.Visible = false;
                    cb_ChonThang.Visible = false;
                    lb_Thang.Visible = true;
                    cb_Thang.Visible = true;
                    dateTime_Ngay.Visible = false;
                    lb_Ngay.Visible = false;
                    loadThongKeThang();
                    loadChiTietPhimThang(cb_Thang.Text);
                    loadChiTietSanPhamThang(cb_Thang.Text);
                }
            }

        }
        private void loadChiTietPhimThang(string Thang)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MovieName");
            dt.Columns.Add("SoldTicketNum");
            dt.Columns.Add("MovieRevenue");


            string query = "Select MaPhim, TenPhim From Phim";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable MovieTable = new DataTable();
            adapter.Fill(MovieTable);
            foreach (DataRow dr in MovieTable.Rows)
            {
                dt.Rows.Add(dr.Field<string>("TenPhim"), getSoldTicketNum(dr.Field<int>("MaPhim"), cb_Thang.Text), getMovieRevenue(dr.Field<int>("MaPhim"), cb_Thang.Text));
            }
            dgv_ChiTietPhim.DataSource = dt;
            dgv_ChiTietPhim.Columns["MovieName"].HeaderText = "Tên phim";
            dgv_ChiTietPhim.Columns["SoldTicketNum"].HeaderText = "Số vé đã bán";
            dgv_ChiTietPhim.Columns["MovieRevenue"].HeaderText = "Tổng doanh thu";
        }
        private void loadChiTietSanPhamThang(string Thang)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductName");
            dt.Columns.Add("SoldNum");


            string query = "Select MaSanPham, TenSanPham From SanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable ProductTable = new DataTable();
            adapter.Fill(ProductTable);
            foreach (DataRow dr in ProductTable.Rows)
            {
                dt.Rows.Add(dr.Field<string>("TenSanPham"), getSoldNum(dr.Field<int>("MaSanPham"), Thang));
            }
            dgv_ChiTietSanPham.DataSource = dt;
            dgv_ChiTietSanPham.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgv_ChiTietSanPham.Columns["SoldNum"].HeaderText = "Số lượng đã bán";
        }
        private int getSoldTicketNum(int MovieID,DateTime date)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select COUNT(MaVe) as SoVe From VePhim Where MaPhim = '" + MovieID + "' and NgayChieu = '" + date.ToString("yyyy-MM-dd") + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows[0].Field<int>("SoVe");
        }
        private int getSoldTicketNum(int MovieID, string Month)
        {
            if (Month == "") return 0;
            string query = "Select COUNT(MaVe) as SoVe From VePhim Where MaPhim = '" + MovieID.ToString() + "' and month(NgayChieu) = " + Month;
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows[0].Field<int>("SoVe");
        }

        private double getMovieRevenue(int MovieID, string Month)
        {
            if (Month == "") return 0;
            string query = "Select Sum(ThanhTien) as DoanhThu From VePhim Where MaPhim = " + MovieID.ToString() + " and month(NgayChieu) = " + Month;
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0]["DoanhThu"] == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToDouble(dt.Rows[0].Field<Decimal>("DoanhThu"));
        }
        private double getMovieRevenue(int MovieID, DateTime date)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select Sum(ThanhTien) as DoanhThu From VePhim Where MaPhim = '" + MovieID + "' and NgayChieu = '" + date.ToString("yyyy-MM-dd") + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0]["DoanhThu"] == DBNull.Value)
            {
                return 0;
            }
            return Convert.ToDouble(dt.Rows[0].Field<Decimal>("DoanhThu"));
        }

        private void loadChiTietPhimNgay(DateTime date)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MovieName");
            dt.Columns.Add("SoldTicketNum");
            dt.Columns.Add("MovieRevenue");


            string query = "Select MaPhim, TenPhim From Phim";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable MovieTable = new DataTable();
            adapter.Fill(MovieTable);
            foreach (DataRow dr in MovieTable.Rows)
            {
                dt.Rows.Add(dr.Field<string>("TenPhim"), getSoldTicketNum(dr.Field<int>("MaPhim"), date), getMovieRevenue(dr.Field<int>("MaPhim"), date));
            }
            dgv_ChiTietPhim.DataSource = dt;
            dgv_ChiTietPhim.Columns["MovieName"].HeaderText = "Tên phim";
            dgv_ChiTietPhim.Columns["SoldTicketNum"].HeaderText = "Số vé đã bán";
            dgv_ChiTietPhim.Columns["MovieRevenue"].HeaderText = "Tổng doanh thu";
        }
        private int getSoldNum(int ProductID,DateTime date)
        {
            string query = "Select SUM(SoLuong) as SoLuong From HoaDon, ChiTietHoaDon Where HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon and ChiTietHoaDon.MaSanPham = '" + ProductID.ToString() + "' and day(NgayTao) = " + date.Day.ToString() + " and month(NgayTao) = " + date.Month.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0]["SoLuong"] == DBNull.Value)
            {
                return 0;
            }
            return dt.Rows[0].Field<int>("SoLuong");
        }

        private int getSoldNum(int ProductID,String Month)
        {
            if (Month == "") return 0;
            string query = "Select SUM(SoLuong) as SoLuong From HoaDon, ChiTietHoaDon Where HoaDon.MaHoaDon = ChiTietHoaDon.MaHoaDon and ChiTietHoaDon.MaSanPham = '"+ProductID.ToString()+"' and month(NgayTao) =" + Month;
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0]["SoLuong"] == DBNull.Value)
            {
                return 0;
            }
            return dt.Rows[0].Field<int>("SoLuong");
        }

        private void loadChiTietSanPhamNgay(DateTime date)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductName");
            dt.Columns.Add("SoldNum");


            string query = "Select MaSanPham, TenSanPham From SanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable ProductTable = new DataTable();
            adapter.Fill(ProductTable);
            foreach (DataRow dr in ProductTable.Rows)
            {
                dt.Rows.Add(dr.Field<string>("TenSanPham"), getSoldNum(dr.Field<int>("MaSanPham"), date));
            }
            dgv_ChiTietSanPham.DataSource = dt;
            dgv_ChiTietSanPham.Columns["ProductName"].HeaderText = "Tên sản phẩm";
            dgv_ChiTietSanPham.Columns["SoldNum"].HeaderText = "Số lượng đã bán";
        }
        private void loadThongKeNgay(string Thang)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Day");
            dt.Columns.Add("TicketRevenue");
            dt.Columns.Add("ProductRevenue");
            dt.Columns.Add("TotalRevenue");
            for(int i = 1; i <= 31; i++)
            {
                double Ve, SanPham;
                string query = "Select day(NgayTao) as Thang, Sum(ThanhTien) as DoanhThuSanPham from HoaDon where day(NgayTao) = " + i.ToString() + "and month(NgayTao) =" + cb_ChonThang.Text + " Group by day(NgayTao)";
                SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                adapter.Fill(dt1);

                query = "Select day(NgayChieu) as Ngay, Sum(ThanhTien) as DoanhThuVePhim from VePhim where day(NgayChieu) = " + i.ToString()  + "and month(NgayChieu) =" + cb_ChonThang.Text +" Group by day(NgayChieu)";
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt2);

                if (dt1.Rows.Count == 0)
                {
                    SanPham = 0;
                }
                else
                {
                    SanPham = Convert.ToDouble(dt1.Rows[0].Field<Decimal>("DoanhThuSanPham"));
                }

                if (dt2.Rows.Count == 0)
                {
                    Ve = 0;
                }
                else
                {
                    Ve = Convert.ToDouble(dt2.Rows[0].Field<Decimal>("DoanhThuVePhim"));
                }
                dt.Rows.Add(i.ToString() + "/" + cb_ChonThang.Text + "/" + DateTime.Now.Year.ToString(), Ve, SanPham, Ve + SanPham);
            }
            dgv_DoanhThu.DataSource = dt;
            dgv_DoanhThu.Columns["Day"].HeaderText = "Ngày";
            dgv_DoanhThu.Columns["TicketRevenue"].HeaderText = "Doanh thu vé phim";
            dgv_DoanhThu.Columns["ProductRevenue"].HeaderText = "Doanh thu sản phảm";
            dgv_DoanhThu.Columns["TotalRevenue"].HeaderText = "Tổng doanh thu";
        }

        private void loadThongKeThang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Month");
            dt.Columns.Add("TicketRevenue");
            dt.Columns.Add("ProductRevenue");
            dt.Columns.Add("TotalRevenue");
            for (int i = 1; i <= 12; i++)
            {
                double Ve, SanPham;
                string query = "Select month(NgayTao) as Ngay, Sum(ThanhTien) as DoanhThuSanPham from HoaDon where month(NgayTao) = " + i.ToString() + " Group by month(NgayTao)";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                adapter.Fill(dt1);

                query = "Select month(NgayChieu) as Ngay, Sum(ThanhTien) as DoanhThuVePhim from VePhim where month(NgayChieu) = " + i.ToString() + " Group by month(NgayChieu)";
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt2);

                if (dt1.Rows.Count == 0)
                {
                    SanPham = 0;
                }
                else
                {
                    SanPham = Convert.ToDouble(dt1.Rows[0].Field<Decimal>("DoanhThuSanPham"));
                }

                if (dt2.Rows.Count == 0)
                {
                    Ve = 0;
                }
                else
                {
                    Ve = Convert.ToDouble(dt2.Rows[0].Field<Decimal>("DoanhThuVePhim"));
                }
                dt.Rows.Add(i.ToString() + "/" + DateTime.Now.Year.ToString(), Ve, SanPham, Ve + SanPham);
            }
            dgv_DoanhThu.DataSource = dt;
            dgv_DoanhThu.Columns["Month"].HeaderText = "Tháng";
            dgv_DoanhThu.Columns["TicketRevenue"].HeaderText = "Doanh thu vé phim";
            dgv_DoanhThu.Columns["ProductRevenue"].HeaderText = "Doanh thu sản phảm";
            dgv_DoanhThu.Columns["TotalRevenue"].HeaderText = "Tổng doanh thu";
        }

        private void cb_ChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadThongKeNgay(cb_ChonThang.Text);
        }

        private void dateTime_Ngay_ValueChanged(object sender, EventArgs e)
        {
            loadChiTietPhimNgay(dateTime_Ngay.Value);
            loadChiTietSanPhamNgay(dateTime_Ngay.Value);
        }

        private void cb_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChiTietPhimThang(cb_Thang.Text);
            loadChiTietSanPhamThang(cb_Thang.Text);
        }
    }
}

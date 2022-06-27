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
    public partial class LichChieu : Form
    {
        public LichChieu()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        int dgvLC_SelectedIndex = -1;
        private int getMovieID(string filmName)
        {
            string sql = "Select MaPhim FROM Phim WHERE TenPhim = N'" + filmName + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable IDtable = new DataTable(); 
            adapter.Fill(IDtable);
            if (IDtable.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                return(IDtable.Rows[0].Field<int>("MaPhim"));
            }
        }
        private bool isDuplicate(int MovieID, DateTime InputDate,TimeSpan InputStartTime, string MaPhong)
        {
            // Lấy ra lịch chiếu của phòng chiếu trong ngày X, X+1, X-1
            string sql = "Select * From LichChieu Where NgayChieu in ('" + InputDate.AddDays(-1).ToString("yyyy-MM-dd") + "','" + InputDate.ToString("yyyy-MM-dd") + "','" + InputDate.AddDays(1).ToString("yyyy-MM-dd") + "') and MaPhong = '" + MaPhong + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable queryResult = new DataTable();
            adapter.Fill(queryResult);
            
            //Kiểm tra có trùng lặp
            //Khung giờ phim A | Khung giờ phim B
            //Trùng lặp = Start A < End B && B Start < A End
            DateTime InputMovieStart = InputDate.Date.Add(InputStartTime);
            DateTime InputMovieEnd = InputMovieStart.Add(getMovieDuration(MovieID));
            foreach (DataRow row in queryResult.Rows)
            {
                int ID = row.Field<int>("MaPhim");
                DateTime MovieDate = row.Field<DateTime>("NgayChieu");
                TimeSpan MovieShowTime = row.Field<TimeSpan>("KhungGio");
                DateTime MovieTimeStart = MovieDate.Date.Add(MovieShowTime);
                DateTime MovieTimeEnd = MovieTimeStart.Add(getMovieDuration(ID));
                if (MovieTimeStart < InputMovieEnd && InputMovieStart < MovieTimeEnd)
                {
                    MessageBox.Show("Lịch chiếu bị trùng !\nKhung giờ trùng: " + row.Field<TimeSpan>("KhungGio").ToString() + "\nNgày chiếu: " + row.Field<DateTime>("NgayChieu").ToString("dd-MM-yyyy"), "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
        private TimeSpan getMovieDuration(int id)
        {
            string query = "Select ThoiLuong From Phim Where MaPhim = '" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if(dataTable.Rows.Count == 0)
            {
                return TimeSpan.Parse("00:00:00");
            }
            else
            {
                TimeSpan time = dataTable.Rows[0].Field<TimeSpan>("ThoiLuong");
                return time;
            }
        }
        private void LoadLichChieu()
        {
            string sql = "Select * From LichChieu Order by NgayChieu, KhungGio, MaPhong";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable LichChieu = new DataTable();
            adapter.Fill(LichChieu);
            dgv_LichChieu.DataSource = LichChieu;
        }
        private void LichChieu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DangNhap.connectionString);
            conn.Open();

            string sql = "Select * From PhongChieu";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dtPhongChieu = new DataTable();
            adapter.Fill(dtPhongChieu);
            cb_PhongChieu.DataSource = dtPhongChieu;
            cb_PhongChieu.DisplayMember = "MaPhong";
            cb_PhongChieu.SelectedIndex = -1;

            sql = "Select TenPhim From Phim";
            adapter = new SqlDataAdapter(sql, conn);
            DataTable dtTenPhim = new DataTable();
            adapter.Fill(dtTenPhim);
            cb_Phim.DataSource = dtTenPhim;
            cb_Phim.DisplayMember = "TenPhim";
            cb_Phim.SelectedIndex = -1;

            LoadLichChieu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Phim.SelectedIndex == -1 || cb_PhongChieu.SelectedIndex == -1)
                {
                    MessageBox.Show("Chưa chọn phim hoặc phòng chiếu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!isDuplicate(getMovieID(cb_Phim.Text), datePicker_NgayChieu.Value, TimeSpan.Parse(timePicker_KhungGio.Text), cb_PhongChieu.Text))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO LichChieu VALUES (@MaPhim, @NgayChieu, @KhungGio, @MaPhong)";
                        cmd.Parameters.AddWithValue("@MaPhim", getMovieID(cb_Phim.Text));
                        cmd.Parameters.AddWithValue("@NgayChieu", datePicker_NgayChieu.Value);
                        cmd.Parameters.AddWithValue("@KhungGio", TimeSpan.Parse(timePicker_KhungGio.Text));
                        cmd.Parameters.AddWithValue("@MaPhong", cb_PhongChieu.Text);
                        cmd.ExecuteNonQuery();
                        LoadLichChieu();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Xác nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Delete From LichChieu Where ID = '" + dgv_LichChieu.Rows[dgvLC_SelectedIndex].Cells["ID"].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                LoadLichChieu();
            }
        }

        private void dgv_LichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLC_SelectedIndex = e.RowIndex;
            btn_Xoa.Enabled = true;
        }
    }
}

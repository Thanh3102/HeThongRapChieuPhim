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
    public partial class TaoVePhim : Form
    {
        public TaoVePhim()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        public TaiKhoan LoginAccount = null;
        private void checkbox_TheTV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_TheTV.Checked)
            {
                tb_TheTV.Enabled = true;
            }
            else
            {
                tb_TheTV.Enabled = false;
            }
        }
        private void loadMovieList()
        {
            string query = "Select TenPhim,MaPhim From Phim";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cb_Phim.DisplayMember = "TenPhim";
            cb_Phim.ValueMember = "MaPhim";
            cb_Phim.DataSource = dt;
            cb_Phim.SelectedIndex = -1;
        }

        private void loadMovieStartTime()
        {
            string query = "Select ID, KhungGio From LichChieu Where NgayChieu = '" + datePicker_NgayChieu.Value.ToString("yyyy-MM-dd") + "' and MaPhim = '" + cb_Phim.SelectedValue + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                cb_KhungGio.DataSource = null;
                cb_Phong.DataSource = null;
                MessageBox.Show("Không có khung giờ chiếu trong ngày " + datePicker_NgayChieu.Value.ToString("dd/MM/yyyy"), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                cb_KhungGio.DisplayMember = "KhungGio";
                cb_KhungGio.ValueMember = "ID";
                cb_KhungGio.DataSource = dt;
            }
        }

        private void loadMovieRoom()
        {
            {
                if (cb_KhungGio.SelectedValue == null)
                {
                    cb_Phong.DataSource = null;
                    return;
                }
                MessageBox.Show("Ngày chiếu: " + datePicker_NgayChieu.Value.ToString("yyyy-MM-dd")
                    + "\nMaPhong: " + cb_Phim.SelectedValue
                    + "\nKhungGio: " + cb_KhungGio.Text);
                string query = "Select ID, MaPhong From LichChieu Where NgayChieu = '" + datePicker_NgayChieu.Value.ToString("yyyy-MM-dd") + "' and MaPhim = '" + cb_Phim.SelectedValue +  "' and KhungGio = '" + cb_KhungGio.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cb_Phong.DisplayMember = "MaPhong";
                cb_Phong.ValueMember = "ID";
                cb_Phong.DataSource = dt;
            }
        }
        private void TaoVePhim_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DangNhap.connectionString);
            conn.Open();
            loadMovieList();
        }

        private void datePicker_NgayChieu_ValueChanged(object sender, EventArgs e)
        {
            loadMovieStartTime();
        }

        private void cb_Phim_DropDownClosed(object sender, EventArgs e)
        {
           loadMovieStartTime();
        }

        private void cb_KhungGio_TextChanged(object sender, EventArgs e)
        {
            loadMovieRoom();
        }
    }
}

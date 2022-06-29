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
        int TicketPrice = 100000;
        bool CardValid = false;
        int dgvTicketSelectIndex = -1;
        private void checkbox_TheTV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_TheTV.Checked)
            {
                tb_TheTV.Enabled = true;
                TinhTongTien();
            }
            else
            {
                tb_TheTV.Text = String.Empty;
                tb_TheTV.Enabled = false;
                TinhTongTien();
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
            string query = "Select DISTINCT KhungGio From LichChieu Where NgayChieu = '" + datePicker_NgayChieu.Value.ToString("yyyy-MM-dd") + "' and MaPhim = '" + cb_Phim.SelectedValue + "' Order by KhungGio";
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
                string query = "Select ID, MaPhong From LichChieu Where NgayChieu = '" + datePicker_NgayChieu.Value.ToString("yyyy-MM-dd") + "' and MaPhim = '" + cb_Phim.SelectedValue +  "' and KhungGio = '" + cb_KhungGio.Text + "' Order by MaPhong";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cb_Phong.DisplayMember = "MaPhong";
                cb_Phong.ValueMember = "ID";
                cb_Phong.DataSource = dt;
            }
        }

        private bool InputNotEmpty()
        {
            if (cb_Phim.Text == "") return false;
            if (cb_KhungGio.Text == "") return false;
            if (cb_Phong.Text == "") return false;
            if (tb_ViTriGhe.Text == "") return false;
            return true;
            
        }
        private void ClearInput()
        {
            cb_Phim.Text = String.Empty;
            cb_KhungGio.Text = String.Empty;
            cb_Phong.Text = String.Empty;
            tb_ViTriGhe.Text = String.Empty;
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
            tb_ViTriGhe.Text = String.Empty;
            tb_ViTriGhe.Tag = String.Empty;
        }

        private void cb_KhungGio_TextChanged(object sender, EventArgs e)
        {
            loadMovieRoom();
            tb_ViTriGhe.Text = String.Empty;
            tb_ViTriGhe.Tag = String.Empty;
        }

        private void btn_ViTriGhe_Click(object sender, EventArgs e)
        {
            if (cb_Phim.Text != String.Empty && cb_KhungGio.Text != String.Empty && cb_Phong.Text != String.Empty)
            {
                TrangThaiGhe trangThaiGhe = new TrangThaiGhe();
                trangThaiGhe.idLichChieu = Convert.ToInt32(cb_Phong.SelectedValue);
                trangThaiGhe.Phong = cb_Phong.Text;
                trangThaiGhe.Text = "Trạng thái ghế phòng " + cb_Phong.Text + " - " + cb_KhungGio.Text;
                trangThaiGhe.ShowDialog();
            }
            else
            {
                MessageBox.Show("Có thông tin chưa chọn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cb_Phim_DropDownClosed(object sender, EventArgs e)
        {
            loadMovieStartTime();
            tb_ViTriGhe.Text = String.Empty;
            tb_ViTriGhe.Tag = String.Empty;
        }
        private string getSeatStatusID(string SeatID, string IDLichChieu)
        {
            string query = "Select ID From TrangThaiGhe Where MaGhe = '" + SeatID + "' and IDLichChieu = '" + IDLichChieu + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0) return String.Empty;
            else return dt.Rows[0].Field<int>("ID").ToString();
        }
        private string getCardType(string id)
        {
            string query = "Select LoaiThe From TheThanhVien Where MaThe ='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return "";
            }
            else
            {
                return dt.Rows[0].Field<string>("LoaiThe").ToString();
            }
        }
        private void TinhTongTien()
        {
            int tong = 0;
            if (dgv_TicketList.Rows.Count == 0) {
                lb_ThanhTien.Text = "Tồng tiền: " + tong.ToString();
                return;
            }
            tong = TicketPrice * dgv_TicketList.Rows.Count;
            if (checkbox_TheTV.Checked)
            {
                if (CardValid)
                {
                    string cardType = getCardType(tb_TheTV.Text);
                    switch (cardType)
                    {
                        case "ThanhVien":
                            tong = tong * 95 / 100;
                            break;
                        case "VIP":
                            tong = tong * 93 / 100;
                            break;
                        case "VVIP":
                            tong = tong * 90 / 100;
                            break;
                    }
                    lb_ThanhTien.Text = "Tồng tiền: " + tong.ToString();
                }
                else
                {
                    lb_ThanhTien.Text = "Tồng tiền: " + tong.ToString();
                }
            }
            else
            {
                lb_ThanhTien.Text = "Tồng tiền: " + tong.ToString();
            }


        }
        private void updateSeatStatus(string ID, bool Statue)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update TrangThaiGhe SET TrangThai = @TrangThai Where ID = '" + ID + "'";
            cmd.Parameters.AddWithValue("@TrangThai", Statue);
            cmd.ExecuteNonQuery();
        }
        private void btn_CreateTicket_Click(object sender, EventArgs e)
        {
            if (InputNotEmpty())
            {
                dgv_TicketList.Rows.Add(cb_Phim.Text, datePicker_NgayChieu.Value.Date.ToString("dd/MM/yyyy"), cb_KhungGio.Text, cb_Phong.Text, tb_ViTriGhe.Text, TicketPrice, tb_ViTriGhe.Tag, getSeatStatusID(tb_ViTriGhe.Tag.ToString(), cb_Phong.SelectedValue.ToString()),cb_Phim.SelectedValue);
                TinhTongTien();
                updateSeatStatus(getSeatStatusID(tb_ViTriGhe.Tag.ToString(), cb_Phong.SelectedValue.ToString()), true);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Có thông tin chưa chọn !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool isCardValid()
        {
            string id = String.Empty;
            if (tb_TheTV.Text.All(char.IsDigit))
            {
                id = tb_TheTV.Text;
            }
            else
            {
                return false;
            }
            string query = "Select MaThe From TheThanhVien Where MaThe ='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else return true;
        }

        private void tb_TheTV_TextChanged(object sender, EventArgs e)
        {
            if (tb_TheTV.Text == String.Empty)
            {
                CardValid = false;
                lb_ThongBao.Visible = false;
                TinhTongTien();
            }
            if (tb_TheTV.Text.All(char.IsDigit))
            {
                if (isCardValid())
                {
                    lb_ThongBao.Text = "Mã thẻ hợp lệ";
                    lb_ThongBao.ForeColor = Color.Green;
                    lb_ThongBao.Visible = true;
                    CardValid = true;
                    TinhTongTien();
                }
                else
                {
                    CardValid = false;
                    lb_ThongBao.Text = "Mã thẻ không tồn tại";
                    lb_ThongBao.ForeColor = Color.Red;
                    lb_ThongBao.Visible = true;
                    TinhTongTien();
                }
            }
        }

        private void TaoVePhim_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgv_TicketList.Rows.Count != 0)
            {
                foreach(DataGridViewRow dr in dgv_TicketList.Rows)
                {
                    updateSeatStatus(dr.Cells["SeatStatusID"].Value.ToString(), false);
                }
            }
        }

        private void btn_DeleteTicket_Click(object sender, EventArgs e)
        {
            updateSeatStatus(dgv_TicketList.Rows[dgvTicketSelectIndex].Cells["SeatStatusID"].Value.ToString(), false);
            dgv_TicketList.Rows.RemoveAt(dgvTicketSelectIndex);
            dgvTicketSelectIndex = -1;
            btn_DeleteTicket.Enabled = false;
        }

        private void dgv_TicketList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvTicketSelectIndex = e.RowIndex;
            btn_DeleteTicket.Enabled = true;
        }
        private void ThemVePhim()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO VePhim VALUES (@MaPhim, @KhungGio, @MaPhong, @MaGhe, @ThanhTien, @NgayChieu, @MaNhanVien, null)";
            cmd.Parameters.Add("@MaPhim", SqlDbType.Int);
            cmd.Parameters.Add("@KhungGio", SqlDbType.Time, 7);
            cmd.Parameters.Add("@MaPhong", SqlDbType.NVarChar, 5);
            cmd.Parameters.Add("@MaGhe", SqlDbType.Int);
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Money);
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date);
            cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int);
            foreach (DataGridViewRow dr in dgv_TicketList.Rows)
            {
                cmd.Parameters["@MaPhim"].Value = Convert.ToInt32(dr.Cells["MovieID"].Value);
                cmd.Parameters["@KhungGio"].Value = TimeSpan.Parse(dr.Cells["MovieTimeStart"].Value.ToString());
                cmd.Parameters["@MaPhong"].Value = dr.Cells["MovieRoom"].Value.ToString();
                cmd.Parameters["@MaGhe"].Value = Convert.ToInt32(dr.Cells["SeatID"].Value);
                cmd.Parameters["@ThanhTien"].Value = Convert.ToInt32(dr.Cells["Price"].Value);
                cmd.Parameters["@NgayChieu"].Value = DateTime.ParseExact(dr.Cells["MovieDateShow"].Value.ToString(), "dd/MM/yyyy", null);
                cmd.Parameters["@MaNhanVien"].Value = this.LoginAccount.getID(conn);
                cmd.ExecuteNonQuery();
            }
        }
        private void ThemVePhim(string MaThe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO VePhim VALUES (@MaPhim, @KhungGio, @MaPhong, @MaGhe, @ThanhTien, @NgayChieu, @MaNhanVien, @MaThe)";
            cmd.Parameters.Add("@MaPhim", SqlDbType.Int);
            cmd.Parameters.Add("@KhungGio", SqlDbType.Time, 7);
            cmd.Parameters.Add("@MaPhong", SqlDbType.NVarChar, 5);
            cmd.Parameters.Add("@MaGhe", SqlDbType.Int);
            cmd.Parameters.Add("@ThanhTien", SqlDbType.Money);
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date);
            cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int);
            cmd.Parameters.Add("@MaThe", SqlDbType.Int);

            string LoaiThe = getCardType(MaThe);
            double Discount = 1;
            switch (LoaiThe)
            {
                case "ThanhVien":
                    Discount = 0.95;
                    break;
                case "VIP":
                    Discount = 0.93;
                    break;
                case "VVIP":
                    Discount = 0.9;
                    break;
            }
            foreach(DataGridViewRow dr in dgv_TicketList.Rows)
            {
                cmd.Parameters["@MaPhim"].Value = Convert.ToInt32(dr.Cells["MovieID"].Value);
                cmd.Parameters["@KhungGio"].Value = TimeSpan.Parse(dr.Cells["MovieTimeStart"].Value.ToString());
                cmd.Parameters["@MaPhong"].Value = dr.Cells["MovieRoom"].Value.ToString();
                cmd.Parameters["@MaGhe"].Value = Convert.ToInt32(dr.Cells["SeatID"].Value);
                cmd.Parameters["@ThanhTien"].Value = Convert.ToInt32(dr.Cells["Price"].Value) * Discount;
                cmd.Parameters["@NgayChieu"].Value = DateTime.ParseExact(dr.Cells["MovieDateShow"].Value.ToString(), "dd/MM/yyyy", null);
                cmd.Parameters["@MaNhanVien"].Value = this.LoginAccount.getID(conn);
                cmd.Parameters["@MaThe"].Value = Convert.ToInt32(tb_TheTV.Text);
                cmd.ExecuteNonQuery();
            }
        }
        private void UpdateCardType(string MaThe)
        {
            if (getTotalTradeValue(MaThe) >= 2500000 && getTotalTradeValue(MaThe) < 5000000)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE TheThanhVien SET LoaiThe = @LoaiThe Where MaThe = '" + MaThe + "'";
                cmd.Parameters.AddWithValue("@LoaiThe", "VIP");
                cmd.ExecuteNonQuery();
                return;
            }
            if (getTotalTradeValue(MaThe) >= 5000000)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE TheThanhVien SET LoaiThe = @LoaiThe Where MaThe = '" + MaThe + "'";
                cmd.Parameters.AddWithValue("@LoaiThe", "VVIP");
                cmd.ExecuteNonQuery();
                return;
            }
        }

        private int getTotalTradeValue(string MaThe)
        {
            string query = "Select GiaTriGiaoDich From TheThanhVien Where MaThe ='" + MaThe + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                Decimal price = dt.Rows[0].Field<System.Decimal>("GiaTriGiaoDich");
                return Convert.ToInt32(price);
            }
        }
        private void UpdateTradeValue(string MaThe) {
            {
                getCardType(MaThe);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE TheThanhVien SET GiaTriGiaoDich = GiaTriGiaoDich + @GiaTriGiaoDich Where MaThe = '" + MaThe + "'";
                cmd.Parameters.AddWithValue("@GiaTriGiaoDich", dgv_TicketList.Rows.Count * TicketPrice);
                cmd.ExecuteNonQuery();
                UpdateCardType(MaThe);
            } }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (dgv_TicketList.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách vé rỗng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Xác nhận thanh toán ?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkbox_TheTV.Checked)
                {
                    if (CardValid)
                    {
                        ThemVePhim(tb_TheTV.Text);
                        UpdateTradeValue(tb_TheTV.Text);
                        dgv_TicketList.Rows.Clear();
                        lb_ThanhTien.Text = String.Empty;
                        MessageBox.Show("Lưu thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã thẻ không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    ThemVePhim(); 
                    dgv_TicketList.Rows.Clear();
                    lb_ThanhTien.Text = String.Empty;
                    MessageBox.Show("Lưu thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

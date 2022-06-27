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
    public partial class TaoHoaDon : Form
    {
        public TaoHoaDon()
        {
            InitializeComponent();
        }
        public TaiKhoan LoginAccount = null;
        SqlConnection conn = null;
        bool CardValid = false;

        int dgv_SP_SelectedIndex = -1;
        private void loadSanPham()
        {
            string query = "Select TenSanPham,MaSanPham From SanPham Order by TenSanPham";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cb_TenSP.DisplayMember = "TenSanPham";
            cb_TenSP.ValueMember = "MaSanPham";
            cb_TenSP.DataSource = dt;
            cb_TenSP.SelectedIndex = -1;

        }

        private int getProductPrice(string id)
        {
            string query = "Select Gia From SanPham Where MaSanPham ='" + id + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                Decimal price = dt.Rows[0].Field<System.Decimal>("Gia");
                return Convert.ToInt32(price);
            }
        }
        private void TaoHoaDon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DangNhap.connectionString);
            conn.Open();
            loadSanPham();
        }

        private bool isContainProduct(string ProductName)
        {
            foreach(DataGridViewRow dr in dgv_SanPham.Rows)
            {
                if (dr.Cells["TenSanPham"].Value.ToString() == ProductName)
                {
                    return true;
                }
            }
            return false;
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

        private int TinhTongTien()
        {
            int Tong = 0;
            foreach (DataGridViewRow dr in dgv_SanPham.Rows)
            {
                Tong += Convert.ToInt32(dr.Cells["TotalPrice"].Value);
            }
            if (checkbox_TheTV.Checked && isCardValid())
            {
                string LoaiThe = getCardType(tb_TheTV.Text);
                if (LoaiThe == "ThanhVien")
                {
                    return (Tong * 95 / 100);
                }
                if (LoaiThe == "VIP")
                {
                    return (Tong * 93 / 100);
                }
                if (LoaiThe == "VVIP")
                {
                    return (Tong * 90 / 100);
                }
            }
            return Tong;

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

        private void ThemHoaDon()
        { 
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO HoaDon VALUES (@NgayTao, @ThanhTien, null, @MaNhanVien)";
            cmd.Parameters.AddWithValue("@NgayTao", DateTime.Now);
            cmd.Parameters.AddWithValue("@ThanhTien", TinhTongTien());
            cmd.Parameters.AddWithValue("@MaNhanVien", LoginAccount.getID(conn));
            cmd.ExecuteNonQuery();
            string IDHoaDon = getMaHoaDon();
            cmd.CommandText = "INSERT INTO ChiTietHoaDon VALUES (@MaHoaDon, @MaSanPham, @SoLuong)";
            cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cmd.Parameters.Add("@MaSanPham", SqlDbType.Int);
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int);

            foreach (DataGridViewRow dr in dgv_SanPham.Rows)
            {
                cmd.Parameters["@MaHoaDon"].Value = Convert.ToInt32(IDHoaDon);
                cmd.Parameters["@MaSanPham"].Value = Convert.ToInt32(dr.Cells["MaSanPham"].Value);
                cmd.Parameters["@SoLuong"].Value = Convert.ToInt32(dr.Cells["SoLuong"].Value);
                cmd.ExecuteNonQuery();
            }
        }
        private string getMaHoaDon()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 * FROM HoaDon ORDER BY MaHoaDon DESC", conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable.Rows[0].Field<int>("MaHoaDon").ToString();
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
        private void ThemHoaDon(string MaThe)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO HoaDon VALUES (@NgayTao, @ThanhTien, @MaThe, @MaNhanVien)";
            cmd.Parameters.AddWithValue("@NgayTao", DateTime.Now);
            cmd.Parameters.AddWithValue("@ThanhTien", TinhTongTien());
            cmd.Parameters.AddWithValue("@MaThe", Convert.ToInt32(MaThe));
            cmd.Parameters.AddWithValue("@MaNhanVien", LoginAccount.getID(conn));
            cmd.ExecuteNonQuery();

            string IDHoaDon = getMaHoaDon();
            cmd.CommandText = "INSERT INTO ChiTietHoaDon VALUES (@MaHoaDon, @MaSanPham, @SoLuong)";
            cmd.Parameters.Add("@MaHoaDon", SqlDbType.Int);
            cmd.Parameters.Add("@MaSanPham", SqlDbType.Int);
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int);

            foreach (DataGridViewRow dr in dgv_SanPham.Rows)
            {
                cmd.Parameters["@MaHoaDon"].Value = Convert.ToInt32(IDHoaDon);
                cmd.Parameters["@MaSanPham"].Value = Convert.ToInt32(dr.Cells["MaSanPham"].Value);
                cmd.Parameters["@SoLuong"].Value = Convert.ToInt32(dr.Cells["SoLuong"].Value);
                cmd.ExecuteNonQuery();
            }



            cmd.CommandText = "UPDATE TheThanhVien SET GiaTriGiaoDich = GiaTriGiaoDich + @GiaTriGiaoDich Where MaThe = '" + MaThe + "'";
            cmd.Parameters.AddWithValue("@GiaTriGiaoDich", TinhTongTien());
            cmd.ExecuteNonQuery();
            UpdateCardType(MaThe);

        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cb_TenSP.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sản phẩm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (isContainProduct(cb_TenSP.Text))
                {
                    MessageBox.Show("Sản phẩm đã có trong hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    dgv_SanPham.Rows.Add(cb_TenSP.SelectedValue ,cb_TenSP.Text, InputSoLuong.Value, getProductPrice(cb_TenSP.SelectedValue.ToString()), getProductPrice(cb_TenSP.SelectedValue.ToString()) * InputSoLuong.Value);

                    lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
                }
            }
        }

        private void dgv_SanPham_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SanPham.Rows.Count == 0) return;
            string soluong = dgv_SanPham.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            string giatien = dgv_SanPham.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            dgv_SanPham.Rows[e.RowIndex].Cells["TotalPrice"].Value = Convert.ToInt32(soluong) * Convert.ToInt32(giatien);
            lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
        }

        private void checkbox_TheTV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_TheTV.Checked)
            {
                tb_TheTV.Enabled = true;
            }
            else
            {
                if (tb_TheTV.Text != String.Empty)
                {
                    tb_TheTV.Text = String.Empty;
                }
                tb_TheTV.Enabled = false;
                CardValid = false;
                lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
            }
        }

        private void tb_TheTV_TextChanged(object sender, EventArgs e)
        {
            if (tb_TheTV.Text == String.Empty)
            {
                CardValid = false;
                lb_ThongBao.Visible = false;
                lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
                return;
            }
            if (tb_TheTV.Text.All(char.IsDigit))
            {
                if (isCardValid())
                {
                    CardValid = true;
                    lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
                    lb_ThongBao.Text = "Mã thẻ hợp lệ";
                    lb_ThongBao.ForeColor = Color.Green;
                    lb_ThongBao.Visible = true;
                }
                else
                {
                    CardValid = false;
                    lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
                    lb_ThongBao.Text = "Mã thẻ không tồn tại";
                    lb_ThongBao.ForeColor = Color.Red;
                    lb_ThongBao.Visible = true;
                }
            }
            else
            {
                CardValid = false;
                lb_ThongBao.Text = "Mã thẻ không hợp lệ";
                lb_ThongBao.ForeColor = Color.Red;
                lb_ThongBao.Visible = true;
                lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dgv_SanPham.Rows.RemoveAt(dgv_SP_SelectedIndex);
                btn_Xoa.Enabled = false;
                lb_TongTien.Text = "Tổng tiền: " + TinhTongTien().ToString() + " VNĐ";
            }
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_SP_SelectedIndex = e.RowIndex;
            btn_Xoa.Enabled = true;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (dgv_SanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Xác nhận thanh toán ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkbox_TheTV.Checked)
                {
                    if (CardValid)
                    {
                        ThemHoaDon(tb_TheTV.Text);
                        dgv_SanPham.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Mã thẻ sử dụng không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    ThemHoaDon();
                    dgv_SanPham.Rows.Clear();
                }
            }
        }

        private void TaoHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}

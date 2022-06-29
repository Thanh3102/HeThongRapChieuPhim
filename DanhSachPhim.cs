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
using System.IO;

namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    public partial class DanhSachPhim : Form
    {
        public DanhSachPhim()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        int rowSelect = -1;
        string imgLocation = null;
        bool isImgChange = false;
        string MovieNameSelect = "";
        private void reloadData()
        {
            string sql = "SELECT * FROM Phim";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_DSPhim.DataSource = dt;
        }
        private void DanhSachPhim_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DangNhap.connectionString);
            conn.Open();
            string sql = "SELECT * FROM Phim";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv_DSPhim.DataSource = dt;
            dgv_DSPhim.Columns["Anh"].Visible = false;
        }

        private void btn_ThemPhim_Click(object sender, EventArgs e)
        {
            FormThemPhim formThemPhim = new FormThemPhim();
            formThemPhim.ShowDialog();
        }

        private void dgv_DSPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowSelect = e.RowIndex;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;
                tb_TenPhim.Text = dgv_DSPhim.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_DaoDien.Text = dgv_DSPhim.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_ThoiLuong.Text = dgv_DSPhim.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_TheLoai.Text = dgv_DSPhim.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_NamSX.Text = dgv_DSPhim.Rows[e.RowIndex].Cells[5].Value.ToString();
                tb_QuocGia.Text = dgv_DSPhim.Rows[e.RowIndex].Cells[6].Value.ToString();

                Byte[] data = new Byte[0];
                data = (Byte[])(dgv_DSPhim.Rows[e.RowIndex].Cells[7].Value);
                MemoryStream mem = new MemoryStream(data);
                FilmImage.Image = Image.FromStream(mem);


                tb_TenPhim.Visible = true;
                tb_DaoDien.Visible = true;
                tb_ThoiLuong.Visible = true;
                tb_TheLoai.Visible = true;
                tb_NamSX.Visible = true;
                tb_QuocGia.Visible = true;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Sua.Visible = false;
            btn_ThemPhim.Visible = false;
            btn_Xoa.Visible = false;
            btn_Save.Visible = true;
            btn_Cancel.Visible = true;
            btn_Change.Visible = true;
            dgv_DSPhim.Enabled = false;
            dgv_DSPhim.ForeColor = Color.Gray;
            foreach (Control c in gb_ThongTin.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true;
                    ((TextBox)c).ReadOnly = false;
                }
            }
            MovieNameSelect = tb_TenPhim.Text;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Sua.Visible = true;
            btn_ThemPhim.Visible = true;
            btn_Xoa.Visible = true;
            btn_Save.Visible = false;
            btn_Cancel.Visible = false;
            btn_Change.Visible = false;
            dgv_DSPhim.Enabled = true;
            dgv_DSPhim.ForeColor = Color.Black;
            foreach (Control c in gb_ThongTin.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false;
                    ((TextBox)c).ReadOnly = true;
                }
            }
        }

        private bool checkValid()
        {
            if (tb_TenPhim.Text == String.Empty || tb_DaoDien.Text == String.Empty || tb_ThoiLuong.Text == String.Empty || tb_TheLoai.Text == String.Empty || tb_QuocGia.Text == String.Empty || tb_NamSX.Text == String.Empty)
            {
                MessageBox.Show("Không được để trống thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tb_NamSX.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Năm sản xuất chỉ chứa số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool isContain()
        {
            string query = "Select TenPhim From Phim Where TenPhim = N'" + tb_TenPhim.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        private void emptyInfo()
        {
            tb_TenPhim.Text = "";
            tb_DaoDien.Text = "";
            tb_TheLoai.Text = "";
            tb_ThoiLuong.Text = "";
            tb_NamSX.Text = "";
            tb_QuocGia.Text = "";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Lưu thay đổi ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkValid())
                {
                    if (tb_TenPhim.Text != MovieNameSelect)
                    {
                        if (isContain())
                        {
                            MessageBox.Show("Tên phim trùng lặp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    int id = Convert.ToInt32(dgv_DSPhim.Rows[rowSelect].Cells[0].Value);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    if (isImgChange)
                    {
                        cmd.CommandText = "UPDATE Phim SET TenPhim = @TenPhim, TheLoai = @TheLoai, ThoiLuong = @ThoiLuong, DaoDien = @DaoDien, NamSanXuat = @NamSX, QuocGia = @QuocGia, Anh = @img WHERE MaPhim = " + id.ToString();
                        byte[] image = File.ReadAllBytes(imgLocation);
                        cmd.Parameters.AddWithValue("@img", image);
                    }
                    else
                    {
                        cmd.CommandText = "UPDATE Phim SET TenPhim = @TenPhim, TheLoai = @TheLoai, ThoiLuong = @ThoiLuong, DaoDien = @DaoDien, NamSanXuat = @NamSX, QuocGia = @QuocGia WHERE MaPhim = " + id.ToString();
                    }
                    cmd.Parameters.AddWithValue("@TenPhim", tb_TenPhim.Text);
                    cmd.Parameters.AddWithValue("@TheLoai", tb_TheLoai.Text);
                    cmd.Parameters.AddWithValue("@ThoiLuong", TimeSpan.Parse(tb_ThoiLuong.Text));
                    cmd.Parameters.AddWithValue("@DaoDien", tb_DaoDien.Text);
                    cmd.Parameters.AddWithValue("@NamSX", tb_NamSX.Text);
                    cmd.Parameters.AddWithValue("@QuocGia", tb_QuocGia.Text);
                    cmd.ExecuteNonQuery();
                    btn_Sua.Visible = true;
                    btn_ThemPhim.Visible = true;
                    btn_Xoa.Visible = true;
                    btn_Save.Visible = false;
                    btn_Cancel.Visible = false;
                    btn_Change.Visible = false;
                    dgv_DSPhim.Enabled = true;
                    dgv_DSPhim.ForeColor = Color.Black;
                    foreach (Control c in gb_ThongTin.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Enabled = false;
                            ((TextBox)c).ReadOnly = true;
                        }
                    }
                    FilmImage.Image = null;
                    isImgChange = false;
                    rowSelect = -1;
                    emptyInfo();
                    reloadData();
                }
            }
        }
        private void btn_Change_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                FilmImage.ImageLocation = imgLocation;
                isImgChange = true;
            }
        }

        private void DeleteSeatStatus(string MovieID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select ID From LichChieu Where MaPhim = " + MovieID, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            SqlCommand cmd = new SqlCommand("Delete From TrangThaiGhe Where IDLichChieu = @IDLichChieu", conn);
            cmd.Parameters.Add("@IDLichChieu", SqlDbType.Int);
            foreach(DataRow dr in dt.Rows)
            {
                cmd.Parameters["@IDLichChieu"].Value = dr.Field<int>("ID");
                cmd.ExecuteNonQuery();
            }
        }
        private void DeleteShow(string MovieID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM LichChieu WHERE MaPhim = " + MovieID;
            cmd.ExecuteNonQuery();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_DSPhim.Rows[rowSelect].Cells[0].Value);
            DialogResult result = MessageBox.Show("Xác nhận xóa thông tin ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteSeatStatus(id.ToString());
                DeleteShow(id.ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM Phim WHERE MaPhim = " + id.ToString();
                cmd.ExecuteNonQuery();
                btn_Save.Visible = false;
                btn_Cancel.Visible = false;
                reloadData();
                FilmImage.Image = null;
                isImgChange = false;
                rowSelect = -1;
                emptyInfo();
                reloadData();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            reloadData();
        }
    }
}

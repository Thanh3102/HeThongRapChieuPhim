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
    public partial class FormThemPhim : Form
    {
        public FormThemPhim()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string imgLocation = null;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Phim VALUES (@TenPhim,@TheLoai,@ThoiLuong,@DaoDien,@NamSX,@QuocGia,@Anh)";
            cmd.Parameters.AddWithValue("@TenPhim", tb_TenPhim.Text);
            cmd.Parameters.AddWithValue("@TheLoai", tb_TheLoai.Text);
            TimeSpan time = TimeSpan.Parse(timePicker_ThoiLuong.Text.ToString());
            cmd.Parameters.AddWithValue("@ThoiLuong", time);
            cmd.Parameters.AddWithValue("@DaoDien", tb_DaoDien.Text);
            cmd.Parameters.AddWithValue("@NamSX", cb_NamSX.Text);
            cmd.Parameters.AddWithValue("@QuocGia", tb_QuocGia.Text);

            byte[] image = File.ReadAllBytes(imgLocation);

            cmd.Parameters.AddWithValue("@Anh", image);
            cmd.ExecuteNonQuery();
            this.Close();
        }
        private void FormThemPhim_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DangNhap.connectionString);
            conn.Open();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Lựa chọn hình ảnh";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                pictureBox_Image.ImageLocation = imgLocation;
            }
        }
    }
}

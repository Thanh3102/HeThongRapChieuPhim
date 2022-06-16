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
    public partial class TaoTheThanhVien : Form
    {
        public TaoTheThanhVien()
        {
            InitializeComponent();
        }

        string ConnectionString = "Data Source=LAPTOP-UUV86GVD;Initial Catalog=RapChieuPhim;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;
        private void TaoTheThanhVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        private void btn_TaoThe_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO TheThanhVien VALUES (N'" + tb_HoTen.Text + "','" + tb_SDT.Text + "', N'" + tb_DiaChi.Text + "' , '" + tb_Email.Text + "', 0, 'ThanhVien', 'NV1' )";
            cmd.ExecuteNonQuery();
        }
    }
}

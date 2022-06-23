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

        public TaiKhoan LoginAccount = null;
        string ConnectionString = "Data Source=LAPTOP-UUV86GVD;Initial Catalog=RapChieuPhim;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;

        private bool checkValid(string HoTen, string DiaChi, string Email, string SDT)
        {
            if (HoTen.Any(char.IsDigit) || HoTen.Any(char.IsSymbol) || HoTen.Any(char.IsPunctuation))
            {
                return false;
            }
            if (!SDT.All(char.IsDigit))
            {
                return false;
            }
            if (DiaChi.Any(char.IsSymbol))
            {
                return false;
            }
            if (!Email.Contains("@"))
            {
                return false;
            }
            return true;

        }
        private bool checkEmpty(string HoTen, string DiaChi, string Email , string SDT)
        {
            if (HoTen == "" || DiaChi == "" || Email == "" || SDT == "")
            {
                return true;
            }
            return false;
        }
        private void TaoTheThanhVien_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
        }

        private void btn_TaoThe_Click(object sender, EventArgs e)
        {
            if (!checkEmpty(tb_HoTen.Text, tb_DiaChi.Text, tb_Email.Text, tb_SDT.Text)){
                if (checkValid(tb_HoTen.Text, tb_DiaChi.Text, tb_Email.Text, tb_SDT.Text))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO TheThanhVien VALUES (N'" + tb_HoTen.Text + "','" + tb_SDT.Text + "', N'" + tb_DiaChi.Text + "' , '" + tb_Email.Text + "', 0, 'ThanhVien', '" + DateTime.Now + "','" + LoginAccount.getID(conn) + "' )";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Có thông tin chưa nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

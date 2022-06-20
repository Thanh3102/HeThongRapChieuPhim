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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string connectionString = "Data Source=LAPTOP-UUV86GVD;Initial Catalog=RapChieuPhim;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn = null;
        public TaiKhoan LoginAccount = null;
        public class TaiKhoan
        {
            public string username;
            public string password;
            public string HoTen;
            public TaiKhoan(string username, string password, SqlConnection conn, DataGridView dgv)
            {
                this.username = username;
                this.password = password;
                this.HoTen = this.getHoTen(conn, dgv);
            }
            public string getHoTen(SqlConnection conn, DataGridView dgv)
            {
                string sql = "SELECT HoTen FROM NhanVien WHERE Username = '" + username + "'";
                SqlDataAdapter HoTen = new SqlDataAdapter(sql,conn);
                DataTable dt = new DataTable();
                HoTen.Fill(dt);
                dgv.DataSource = dt;
                return dt.Rows[0].Field<string>("HoTen").ToString();
            }
        }

        private void bnt_Login_Click(object sender, EventArgs e)
        {
            //LoginAccount = new TaiKhoan(tb_Username.Text, tb_Password.Text, conn, dgv1);
            //textBox1.Text = LoginAccount.HoTen;


            //formTrangChu.isLogin = true;
            //formTrangChu.tb_AccountName.Text = "Tên nhân viên: " + LoginAccount.HoTen;
            //MessageBox.Show(LoginAccount.HoTen, "Thông báo");
/*            TrangChu formTrangChu = Application.OpenForms[0];
            formTrangChu.Show();
            formTrangChu.panel1.Visible = true;*/
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }
    }
}

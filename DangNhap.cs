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
        private void bnt_Login_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Username.Focus();
                return;
            }
            else
            {
                if (tb_Password.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Password.Focus();
                    return;
                }
                else
                {
                    LoginAccount = new TaiKhoan(tb_Username.Text, tb_Password.Text, conn);
                    if (LoginAccount.isExist(conn))
                    {
                        if (LoginAccount.checkPassword(conn))
                        {
                            TrangChu formTrangChu = new TrangChu();
                            tb_Username.Text = string.Empty;
                            tb_Password.Text = string.Empty;
                            formTrangChu.LoginAccount = this.LoginAccount;
                            this.Hide();
                            formTrangChu.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_Username.Text = string.Empty;
                        tb_Password.Text = string.Empty;
                        tb_Username.Focus();
                    }

                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

public class TaiKhoan
{
    private string username;
    private string password;
    public TaiKhoan(string username, string password, SqlConnection conn)
    {
        this.username = username;
        this.password = password;
    }
    public string getHoTen(SqlConnection conn)
    {
        string sql = "SELECT HoTen FROM NhanVien WHERE Username = '" + username + "'";
        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            return "";
        }
        else
        {
            return dt.Rows[0].Field<string>("HoTen").ToString();
        }
    }
    public bool checkPassword(SqlConnection conn)
    {
        bool isCorrect = false;
        string sql = "SELECT password FROM NhanVien WHERE Username = '" + username + "'";
        SqlDataAdapter PW = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        PW.Fill(dt);
        if (this.password.Equals(dt.Rows[0].Field<string>("password").ToString()))
        {
            isCorrect = true;
            return isCorrect;
        }
        else
        {
            return isCorrect;
        }
    }

    public bool isExist(SqlConnection conn)
    {
        string sql = "SELECT password FROM NhanVien WHERE Username = '" + username + "'";
        SqlDataAdapter PW = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        PW.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string getID(SqlConnection conn)
    {
        string sql = "SELECT MaNhanVien FROM NhanVien WHERE Username = '" + username + "'";
        SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        if (dt.Rows.Count == 0)
        {
            return "";
        }
        else
        {
            return dt.Rows[0].Field<int>("MaNhanVien").ToString();
        }
    }
}

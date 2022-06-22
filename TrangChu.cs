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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();

        }
        Form activeForm = null;
        SqlConnection conn = null;
        public TaiKhoan LoginAccount;
        void openChildForm(Form Fname)
        {
            if (activeForm == null)
            {
                {
                    Fname.MdiParent = this;
                    Fname.FormBorderStyle = FormBorderStyle.None;
                    Fname.Dock = DockStyle.Fill;
                    Fname.Show();
                    activeForm = Fname;
                }

            }
            else
            {
                if (Fname == activeForm)
                {
                    return;
                }
                else
                {
                    activeForm.Close();
                    Fname.MdiParent = this;
                    Fname.FormBorderStyle = FormBorderStyle.None;
                    Fname.Dock = DockStyle.Fill;
                    Fname.Show();
                    activeForm = Fname;
                }

            }
        }

        private void DSPhim_BTN_Click(object sender, EventArgs e)
        {
            DanhSachPhim FormDSPhim = new DanhSachPhim();
            openChildForm(FormDSPhim);
        }

        private void btn_TaoThe_Click(object sender, EventArgs e)
        {
            TaoTheThanhVien FormTaoThe = new TaoTheThanhVien();
            FormTaoThe.LoginAccount = this.LoginAccount;
            openChildForm(FormTaoThe);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if (f.Name == "DangNhap")
                {
                    f.Show();
                    this.Close();
                }
            }  
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DangNhap.connectionString);
            tb_AccountName.Text = "Tài khoản: " + LoginAccount.getHoTen(conn);
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_TaoVePhim_Click(object sender, EventArgs e)
        {
            TaoVePhim FormTaoVePhim = new TaoVePhim();
            openChildForm(FormTaoVePhim);
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            TaoHoaDon FormTaoHoaDon = new TaoHoaDon();
            openChildForm(FormTaoHoaDon);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LoginAccount.getID(conn));
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            LichChieu formLichChieu = new LichChieu();
            openChildForm(formLichChieu);
        }
    }
}

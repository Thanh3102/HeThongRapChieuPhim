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
        String activeForm = null;
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
                    activeForm = Fname.Name;
                }

            }
            else
            {
                if (Fname.Name == activeForm)
                {
                    return;
                }
                else
                {
                    foreach(Form f in Application.OpenForms)
                    {
                        if (f.Name == activeForm)
                        {
                            f.Close();
                            break;
                        }
                    }
                    Fname.MdiParent = this;
                    Fname.FormBorderStyle = FormBorderStyle.None;
                    Fname.Dock = DockStyle.Fill;
                    Fname.Show();
                    activeForm = Fname.Name;
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
            FormTaoVePhim.LoginAccount = this.LoginAccount;
            openChildForm(FormTaoVePhim);
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            TaoHoaDon FormTaoHoaDon = new TaoHoaDon();
            FormTaoHoaDon.LoginAccount = this.LoginAccount;
            openChildForm(FormTaoHoaDon);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.ParseExact("24-06-2022:23:00:00", "dd-MM-yyyy:HH:mm:ss", null);
            DateTime dateTime2 = DateTime.ParseExact("25-06-2022:13:00:00", "dd-MM-yyyy:HH:mm:ss", null);
            DateTime dateTime1 = DateTime.ParseExact("25-06-2022", "dd-MM-yyyy", null);
            TimeSpan time = TimeSpan.Parse("02:15:00");
            /*MessageBox.Show(dateTime.AddHours(2).ToString());*/
            /* MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd"));*/
            /*MessageBox.Show((dateTime.CompareTo(dateTime2).ToString()));*/
            /*MessageBox.Show(dateTime.Add(time).ToString());*/
            DateTime dateStart = dateTime1.Add(time);
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            LichChieu formLichChieu = new LichChieu();
            openChildForm(formLichChieu);
        }
    }
}

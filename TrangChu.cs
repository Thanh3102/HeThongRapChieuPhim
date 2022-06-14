using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        Form activeForm = null;
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
            openChildForm(FormTaoThe);
        }
    }
}

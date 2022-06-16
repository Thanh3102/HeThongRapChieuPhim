﻿using System;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void bnt_Login_Click(object sender, EventArgs e)
        {
            TrangChu formTrangChu = new TrangChu();
            formTrangChu.isLogin = true;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Name == "TrangChu")
                {
                    f.Show();
                }
            }
            this.Close();
        }

    }
}

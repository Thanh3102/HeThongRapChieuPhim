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
    public partial class TaoVePhim : Form
    {
        public TaoVePhim()
        {
            InitializeComponent();
        }

        private void checkbox_TheTV_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_TheTV.Checked)
            {
                tb_TheTV.Enabled = true;
            }
            else
            {
                tb_TheTV.Enabled = false;
            }
        }
    }
}

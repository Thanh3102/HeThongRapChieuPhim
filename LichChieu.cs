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
    public partial class LichChieu : Form
    {
        public LichChieu()
        {
            InitializeComponent();
        }

        private void LichChieu_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.CustomFormat = "hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ShowUpDown = true;
        }
    }
}

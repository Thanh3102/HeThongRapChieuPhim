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
    public partial class TrangThaiGhe : Form
    {
        public TrangThaiGhe()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        public int idLichChieu = -1;
        public string Phong = string.Empty;
        Control lastButton = null;
        Color lastButtonColor = Color.Empty;

        private int getSeatID(string SeatName, string RoomName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select MaGhe From Ghe Where ViTriGhe = '" + SeatName + "' and MaPhong = '" + RoomName + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows[0].Field<int>("MaGhe");
        }
        private void loadStatus(Button btn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select TrangThai From TrangThaiGhe Where IDLichChieu = '" + idLichChieu.ToString() + "' and MaGhe ='" + getSeatID(btn.Text,Phong) + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0].Field<bool>("TrangThai"))
            {
                btn.BackColor = Color.Red;
                btn.Enabled = false;
            }
            else
            {
                btn.BackColor = Color.White;
            }
            btn.Tag = getSeatID(btn.Text, Phong);
        }
        private void loadSeatStatus()
        {
            if (idLichChieu != -1)
            {
                foreach (Button btn in this.SeatTable.Controls)
                {
                    loadStatus(btn);
                }
            }
        }
        private void TrangThaiGhe_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(DangNhap.connectionString);
            conn.Open();
            loadSeatStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender.GetType() != typeof(Button)) return;
            if (lastButton == null)
            {
                lastButton = (Button)sender;
                var obj = sender as Button;
                obj.BackColor = Color.Lime;
            }
            else
            {
                lastButton.BackColor = Color.White;
                lastButton = (Button)sender;
                var obj = sender as Button;
                obj.BackColor = Color.Lime;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (lastButton == null)
            {
                this.Close();
                return;
            }
            else
            {
                var frm = Application.OpenForms.Cast<Form>().Where(x => x.Name == "TaoVePhim").FirstOrDefault();
                TaoVePhim f = (TaoVePhim)frm;
                f.tb_ViTriGhe.Text = lastButton.Text;
                f.tb_ViTriGhe.Tag = getSeatID(lastButton.Text, Phong);
                this.Close();
            }
        }
    }


}

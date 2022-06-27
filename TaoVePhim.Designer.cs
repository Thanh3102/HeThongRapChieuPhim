namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    partial class TaoVePhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Phim = new System.Windows.Forms.ComboBox();
            this.cb_KhungGio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Phong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_TheTV = new System.Windows.Forms.TextBox();
            this.checkbox_TheTV = new System.Windows.Forms.CheckBox();
            this.btn_ViTriGhe = new System.Windows.Forms.Button();
            this.tb_ViTriGhe = new System.Windows.Forms.TextBox();
            this.lb_ThanhTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_TicketList = new System.Windows.Forms.DataGridView();
            this.btn_CreateTicket = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_DeleteTicket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker_NgayChieu = new System.Windows.Forms.DateTimePicker();
            this.lb_ThongBao = new System.Windows.Forms.Label();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieDateShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatStatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo vé phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên phim";
            // 
            // cb_Phim
            // 
            this.cb_Phim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Phim.FormattingEnabled = true;
            this.cb_Phim.Location = new System.Drawing.Point(185, 97);
            this.cb_Phim.Name = "cb_Phim";
            this.cb_Phim.Size = new System.Drawing.Size(461, 33);
            this.cb_Phim.TabIndex = 3;
            this.cb_Phim.DropDownClosed += new System.EventHandler(this.cb_Phim_DropDownClosed);
            // 
            // cb_KhungGio
            // 
            this.cb_KhungGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_KhungGio.FormattingEnabled = true;
            this.cb_KhungGio.Location = new System.Drawing.Point(518, 162);
            this.cb_KhungGio.MaxDropDownItems = 5;
            this.cb_KhungGio.Name = "cb_KhungGio";
            this.cb_KhungGio.Size = new System.Drawing.Size(127, 33);
            this.cb_KhungGio.TabIndex = 5;
            this.cb_KhungGio.TextChanged += new System.EventHandler(this.cb_KhungGio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khung giờ";
            // 
            // cb_Phong
            // 
            this.cb_Phong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Phong.FormattingEnabled = true;
            this.cb_Phong.Location = new System.Drawing.Point(185, 236);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Size = new System.Drawing.Size(134, 33);
            this.cb_Phong.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phòng chiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vị trí ghế";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(706, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mã thẻ thành viên";
            // 
            // tb_TheTV
            // 
            this.tb_TheTV.Enabled = false;
            this.tb_TheTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TheTV.Location = new System.Drawing.Point(922, 100);
            this.tb_TheTV.Name = "tb_TheTV";
            this.tb_TheTV.Size = new System.Drawing.Size(286, 30);
            this.tb_TheTV.TabIndex = 10;
            this.tb_TheTV.TextChanged += new System.EventHandler(this.tb_TheTV_TextChanged);
            // 
            // checkbox_TheTV
            // 
            this.checkbox_TheTV.AutoSize = true;
            this.checkbox_TheTV.Location = new System.Drawing.Point(711, 146);
            this.checkbox_TheTV.Name = "checkbox_TheTV";
            this.checkbox_TheTV.Size = new System.Drawing.Size(162, 20);
            this.checkbox_TheTV.TabIndex = 11;
            this.checkbox_TheTV.Text = "Sử dụng thẻ thành viên";
            this.checkbox_TheTV.UseVisualStyleBackColor = true;
            this.checkbox_TheTV.CheckedChanged += new System.EventHandler(this.checkbox_TheTV_CheckedChanged);
            // 
            // btn_ViTriGhe
            // 
            this.btn_ViTriGhe.Location = new System.Drawing.Point(521, 282);
            this.btn_ViTriGhe.Name = "btn_ViTriGhe";
            this.btn_ViTriGhe.Size = new System.Drawing.Size(125, 30);
            this.btn_ViTriGhe.TabIndex = 12;
            this.btn_ViTriGhe.Text = "Chọn vị trí ghế";
            this.btn_ViTriGhe.UseVisualStyleBackColor = true;
            this.btn_ViTriGhe.Click += new System.EventHandler(this.btn_ViTriGhe_Click);
            // 
            // tb_ViTriGhe
            // 
            this.tb_ViTriGhe.Enabled = false;
            this.tb_ViTriGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ViTriGhe.Location = new System.Drawing.Point(521, 236);
            this.tb_ViTriGhe.Name = "tb_ViTriGhe";
            this.tb_ViTriGhe.ReadOnly = true;
            this.tb_ViTriGhe.Size = new System.Drawing.Size(125, 30);
            this.tb_ViTriGhe.TabIndex = 13;
            // 
            // lb_ThanhTien
            // 
            this.lb_ThanhTien.AutoSize = true;
            this.lb_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThanhTien.Location = new System.Drawing.Point(706, 238);
            this.lb_ThanhTien.Name = "lb_ThanhTien";
            this.lb_ThanhTien.Size = new System.Drawing.Size(132, 29);
            this.lb_ThanhTien.TabIndex = 14;
            this.lb_ThanhTien.Text = "Thành tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_TicketList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 424);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách vé hiện tại";
            // 
            // dgv_TicketList
            // 
            this.dgv_TicketList.AllowUserToAddRows = false;
            this.dgv_TicketList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TicketList.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_TicketList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TicketList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieName,
            this.MovieDateShow,
            this.MovieTimeStart,
            this.MovieRoom,
            this.Seat,
            this.Price,
            this.SeatID,
            this.SeatStatusID,
            this.MovieID});
            this.dgv_TicketList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_TicketList.Location = new System.Drawing.Point(3, 26);
            this.dgv_TicketList.Name = "dgv_TicketList";
            this.dgv_TicketList.RowHeadersWidth = 51;
            this.dgv_TicketList.RowTemplate.Height = 24;
            this.dgv_TicketList.Size = new System.Drawing.Size(1226, 395);
            this.dgv_TicketList.TabIndex = 2;
            this.dgv_TicketList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TicketList_CellClick);
            // 
            // btn_CreateTicket
            // 
            this.btn_CreateTicket.Location = new System.Drawing.Point(30, 337);
            this.btn_CreateTicket.Name = "btn_CreateTicket";
            this.btn_CreateTicket.Size = new System.Drawing.Size(122, 40);
            this.btn_CreateTicket.TabIndex = 16;
            this.btn_CreateTicket.Text = "Tạo vé";
            this.btn_CreateTicket.UseVisualStyleBackColor = true;
            this.btn_CreateTicket.Click += new System.EventHandler(this.btn_CreateTicket_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(1051, 369);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(169, 51);
            this.btn_ThanhToan.TabIndex = 17;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_DeleteTicket
            // 
            this.btn_DeleteTicket.Enabled = false;
            this.btn_DeleteTicket.Location = new System.Drawing.Point(190, 337);
            this.btn_DeleteTicket.Name = "btn_DeleteTicket";
            this.btn_DeleteTicket.Size = new System.Drawing.Size(122, 40);
            this.btn_DeleteTicket.TabIndex = 18;
            this.btn_DeleteTicket.Text = "Xóa vé";
            this.btn_DeleteTicket.UseVisualStyleBackColor = true;
            this.btn_DeleteTicket.Click += new System.EventHandler(this.btn_DeleteTicket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ngày chiếu";
            // 
            // datePicker_NgayChieu
            // 
            this.datePicker_NgayChieu.CustomFormat = "dd/MM/yyyy";
            this.datePicker_NgayChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_NgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker_NgayChieu.Location = new System.Drawing.Point(185, 162);
            this.datePicker_NgayChieu.Name = "datePicker_NgayChieu";
            this.datePicker_NgayChieu.Size = new System.Drawing.Size(134, 30);
            this.datePicker_NgayChieu.TabIndex = 20;
            this.datePicker_NgayChieu.ValueChanged += new System.EventHandler(this.datePicker_NgayChieu_ValueChanged);
            // 
            // lb_ThongBao
            // 
            this.lb_ThongBao.AutoSize = true;
            this.lb_ThongBao.Location = new System.Drawing.Point(919, 133);
            this.lb_ThongBao.Name = "lb_ThongBao";
            this.lb_ThongBao.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBao.TabIndex = 30;
            this.lb_ThongBao.Text = "Thông báo";
            this.lb_ThongBao.Visible = false;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "Tên phim";
            this.MovieName.MinimumWidth = 6;
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            // 
            // MovieDateShow
            // 
            this.MovieDateShow.HeaderText = "Ngày chiếu";
            this.MovieDateShow.MinimumWidth = 6;
            this.MovieDateShow.Name = "MovieDateShow";
            this.MovieDateShow.ReadOnly = true;
            // 
            // MovieTimeStart
            // 
            this.MovieTimeStart.HeaderText = "Khung giờ";
            this.MovieTimeStart.MinimumWidth = 6;
            this.MovieTimeStart.Name = "MovieTimeStart";
            this.MovieTimeStart.ReadOnly = true;
            // 
            // MovieRoom
            // 
            this.MovieRoom.HeaderText = "Phòng chiếu";
            this.MovieRoom.MinimumWidth = 6;
            this.MovieRoom.Name = "MovieRoom";
            this.MovieRoom.ReadOnly = true;
            // 
            // Seat
            // 
            this.Seat.HeaderText = "Vị trí ghế";
            this.Seat.MinimumWidth = 6;
            this.Seat.Name = "Seat";
            this.Seat.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá vé";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // SeatID
            // 
            this.SeatID.HeaderText = "ID Ghế";
            this.SeatID.MinimumWidth = 6;
            this.SeatID.Name = "SeatID";
            this.SeatID.ReadOnly = true;
            this.SeatID.Visible = false;
            // 
            // SeatStatusID
            // 
            this.SeatStatusID.HeaderText = "ID Trạng Thái ghế";
            this.SeatStatusID.MinimumWidth = 6;
            this.SeatStatusID.Name = "SeatStatusID";
            this.SeatStatusID.ReadOnly = true;
            this.SeatStatusID.Visible = false;
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "Mã phim";
            this.MovieID.MinimumWidth = 6;
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            this.MovieID.Visible = false;
            // 
            // TaoVePhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 850);
            this.Controls.Add(this.lb_ThongBao);
            this.Controls.Add(this.datePicker_NgayChieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_DeleteTicket);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_CreateTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_ThanhTien);
            this.Controls.Add(this.tb_ViTriGhe);
            this.Controls.Add(this.btn_ViTriGhe);
            this.Controls.Add(this.checkbox_TheTV);
            this.Controls.Add(this.tb_TheTV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_KhungGio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Phim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoVePhim";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaoVePhim_FormClosing);
            this.Load += new System.EventHandler(this.TaoVePhim_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TicketList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Phim;
        private System.Windows.Forms.ComboBox cb_KhungGio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_TheTV;
        private System.Windows.Forms.CheckBox checkbox_TheTV;
        private System.Windows.Forms.Button btn_ViTriGhe;
        private System.Windows.Forms.Label lb_ThanhTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_TicketList;
        private System.Windows.Forms.Button btn_CreateTicket;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_DeleteTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePicker_NgayChieu;
        public System.Windows.Forms.TextBox tb_ViTriGhe;
        private System.Windows.Forms.ComboBox cb_Phong;
        private System.Windows.Forms.Label lb_ThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieDateShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatStatusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
    }
}
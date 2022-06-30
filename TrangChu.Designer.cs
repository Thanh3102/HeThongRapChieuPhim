namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    partial class TrangChu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_AccountName = new System.Windows.Forms.TextBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.btn_TaoVePhim = new System.Windows.Forms.Button();
            this.btn_TaoThe = new System.Windows.Forms.Button();
            this.btn_DSPhim = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.btn_ThongKe);
            this.panel1.Controls.Add(this.btn_TaoHoaDon);
            this.panel1.Controls.Add(this.btn_TaoVePhim);
            this.panel1.Controls.Add(this.btn_TaoThe);
            this.panel1.Controls.Add(this.btn_DSPhim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 900);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(0, 841);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(298, 57);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.calendar;
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.Location = new System.Drawing.Point(0, 463);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(298, 57);
            this.btn_CapNhat.TabIndex = 6;
            this.btn_CapNhat.Text = "Lịch chiếu";
            this.btn_CapNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_AccountName);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 178);
            this.panel2.TabIndex = 0;
            // 
            // tb_AccountName
            // 
            this.tb_AccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(76)))));
            this.tb_AccountName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_AccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AccountName.Location = new System.Drawing.Point(0, 80);
            this.tb_AccountName.Multiline = true;
            this.tb_AccountName.Name = "tb_AccountName";
            this.tb_AccountName.Size = new System.Drawing.Size(296, 53);
            this.tb_AccountName.TabIndex = 3;
            this.tb_AccountName.Text = "Tên nhân viên:";
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.chart;
            this.btn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.Location = new System.Drawing.Point(0, 406);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(298, 57);
            this.btn_ThongKe.TabIndex = 5;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TaoHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_TaoHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_TaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoHoaDon.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.bill;
            this.btn_TaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(0, 349);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(298, 57);
            this.btn_TaoHoaDon.TabIndex = 4;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            this.btn_TaoHoaDon.Click += new System.EventHandler(this.btn_TaoHoaDon_Click);
            // 
            // btn_TaoVePhim
            // 
            this.btn_TaoVePhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TaoVePhim.FlatAppearance.BorderSize = 0;
            this.btn_TaoVePhim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_TaoVePhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoVePhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoVePhim.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.ticket;
            this.btn_TaoVePhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoVePhim.Location = new System.Drawing.Point(0, 292);
            this.btn_TaoVePhim.Name = "btn_TaoVePhim";
            this.btn_TaoVePhim.Size = new System.Drawing.Size(298, 57);
            this.btn_TaoVePhim.TabIndex = 3;
            this.btn_TaoVePhim.Text = "Tạo vé phim";
            this.btn_TaoVePhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoVePhim.UseVisualStyleBackColor = true;
            this.btn_TaoVePhim.Click += new System.EventHandler(this.btn_TaoVePhim_Click);
            // 
            // btn_TaoThe
            // 
            this.btn_TaoThe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TaoThe.FlatAppearance.BorderSize = 0;
            this.btn_TaoThe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_TaoThe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaoThe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoThe.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.credit_card;
            this.btn_TaoThe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoThe.Location = new System.Drawing.Point(0, 235);
            this.btn_TaoThe.Name = "btn_TaoThe";
            this.btn_TaoThe.Size = new System.Drawing.Size(298, 57);
            this.btn_TaoThe.TabIndex = 2;
            this.btn_TaoThe.Text = "Tạo thẻ thành viên";
            this.btn_TaoThe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TaoThe.UseVisualStyleBackColor = true;
            this.btn_TaoThe.Click += new System.EventHandler(this.btn_TaoThe_Click);
            // 
            // btn_DSPhim
            // 
            this.btn_DSPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DSPhim.FlatAppearance.BorderSize = 0;
            this.btn_DSPhim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_DSPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DSPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSPhim.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.list;
            this.btn_DSPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DSPhim.Location = new System.Drawing.Point(0, 178);
            this.btn_DSPhim.Name = "btn_DSPhim";
            this.btn_DSPhim.Size = new System.Drawing.Size(298, 57);
            this.btn_DSPhim.TabIndex = 1;
            this.btn_DSPhim.Text = "Danh sách phim";
            this.btn_DSPhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DSPhim.UseVisualStyleBackColor = true;
            this.btn_DSPhim.Click += new System.EventHandler(this.DSPhim_BTN_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.logout__1_;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(0, 133);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(296, 43);
            this.btn_logout.TabIndex = 2;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hệ_thống_quản_lý_rạp_chiếu_phim.Properties.Resources.cinema_reel;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(111, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.Button btn_TaoVePhim;
        private System.Windows.Forms.Button btn_TaoThe;
        private System.Windows.Forms.Button btn_DSPhim;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.Button btn_Exit;
        public System.Windows.Forms.TextBox tb_AccountName;
        public System.Windows.Forms.Panel panel1;
    }
}


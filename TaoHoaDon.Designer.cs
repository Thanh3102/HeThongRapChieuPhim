namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    partial class TaoHoaDon
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
            this.label6 = new System.Windows.Forms.Label();
            this.tb_TheTV = new System.Windows.Forms.TextBox();
            this.checkbox_TheTV = new System.Windows.Forms.CheckBox();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TenSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_ThongBao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 29);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mã thẻ thành viên";
            // 
            // tb_TheTV
            // 
            this.tb_TheTV.Enabled = false;
            this.tb_TheTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TheTV.Location = new System.Drawing.Point(854, 118);
            this.tb_TheTV.Name = "tb_TheTV";
            this.tb_TheTV.Size = new System.Drawing.Size(346, 30);
            this.tb_TheTV.TabIndex = 25;
            this.tb_TheTV.TextChanged += new System.EventHandler(this.tb_TheTV_TextChanged);
            // 
            // checkbox_TheTV
            // 
            this.checkbox_TheTV.AutoSize = true;
            this.checkbox_TheTV.Location = new System.Drawing.Point(616, 164);
            this.checkbox_TheTV.Name = "checkbox_TheTV";
            this.checkbox_TheTV.Size = new System.Drawing.Size(162, 20);
            this.checkbox_TheTV.TabIndex = 26;
            this.checkbox_TheTV.Text = "Sử dụng thẻ thành viên";
            this.checkbox_TheTV.UseVisualStyleBackColor = true;
            this.checkbox_TheTV.CheckedChanged += new System.EventHandler(this.checkbox_TheTV_CheckedChanged);
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Location = new System.Drawing.Point(611, 210);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(121, 29);
            this.lb_TongTien.TabIndex = 27;
            this.lb_TongTien.Text = "Tổng tiền:";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(1051, 291);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(169, 51);
            this.btn_ThanhToan.TabIndex = 28;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sản phẩm";
            // 
            // cb_TenSP
            // 
            this.cb_TenSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TenSP.FormattingEnabled = true;
            this.cb_TenSP.Location = new System.Drawing.Point(259, 119);
            this.cb_TenSP.Name = "cb_TenSP";
            this.cb_TenSP.Size = new System.Drawing.Size(311, 33);
            this.cb_TenSP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // InputSoLuong
            // 
            this.InputSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSoLuong.Location = new System.Drawing.Point(259, 174);
            this.InputSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.InputSoLuong.Name = "InputSoLuong";
            this.InputSoLuong.Size = new System.Drawing.Size(76, 30);
            this.InputSoLuong.TabIndex = 7;
            this.InputSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(60, 261);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(154, 40);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Thêm vào hóa đơn";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(259, 261);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(154, 40);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa khỏi hóa đơn";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AllowUserToAddRows = false;
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.Price,
            this.TotalPrice});
            this.dgv_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SanPham.Location = new System.Drawing.Point(3, 26);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 24;
            this.dgv_SanPham.Size = new System.Drawing.Size(1226, 376);
            this.dgv_SanPham.TabIndex = 2;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            this.dgv_SanPham.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellEndEdit);
            // 
            // MaSanPham
            // 
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.MinimumWidth = 6;
            this.MaSanPham.Name = "MaSanPham";
            this.MaSanPham.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.MinimumWidth = 6;
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Thành Tiền";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SanPham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 405);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // lb_ThongBao
            // 
            this.lb_ThongBao.AutoSize = true;
            this.lb_ThongBao.Location = new System.Drawing.Point(857, 161);
            this.lb_ThongBao.Name = "lb_ThongBao";
            this.lb_ThongBao.Size = new System.Drawing.Size(73, 16);
            this.lb_ThongBao.TabIndex = 29;
            this.lb_ThongBao.Text = "Thông báo";
            this.lb_ThongBao.Visible = false;
            // 
            // TaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.lb_ThongBao);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.checkbox_TheTV);
            this.Controls.Add(this.tb_TheTV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.InputSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_TenSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoHoaDon";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaoHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.TaoHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_TheTV;
        private System.Windows.Forms.CheckBox checkbox_TheTV;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown InputSoLuong;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_ThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}
namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    partial class ThongKe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_DoanhThu = new System.Windows.Forms.DataGridView();
            this.cb_ChonThang = new System.Windows.Forms.ComboBox();
            this.lb_ChonThang = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_Thang = new System.Windows.Forms.ComboBox();
            this.lb_Thang = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ChiTietPhim = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ChiTietSanPham = new System.Windows.Forms.DataGridView();
            this.lb_Ngay = new System.Windows.Forms.Label();
            this.dateTime_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_filterType = new System.Windows.Forms.ComboBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhim)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_DoanhThu);
            this.tabPage1.Controls.Add(this.cb_ChonThang);
            this.tabPage1.Controls.Add(this.lb_ChonThang);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tổng quan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_DoanhThu
            // 
            this.dgv_DoanhThu.AllowUserToAddRows = false;
            this.dgv_DoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DoanhThu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DoanhThu.Location = new System.Drawing.Point(3, 100);
            this.dgv_DoanhThu.Name = "dgv_DoanhThu";
            this.dgv_DoanhThu.ReadOnly = true;
            this.dgv_DoanhThu.RowHeadersWidth = 51;
            this.dgv_DoanhThu.RowTemplate.Height = 24;
            this.dgv_DoanhThu.Size = new System.Drawing.Size(1168, 489);
            this.dgv_DoanhThu.TabIndex = 10;
            // 
            // cb_ChonThang
            // 
            this.cb_ChonThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ChonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ChonThang.FormattingEnabled = true;
            this.cb_ChonThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_ChonThang.Location = new System.Drawing.Point(97, 35);
            this.cb_ChonThang.Name = "cb_ChonThang";
            this.cb_ChonThang.Size = new System.Drawing.Size(77, 28);
            this.cb_ChonThang.TabIndex = 9;
            this.cb_ChonThang.Visible = false;
            this.cb_ChonThang.SelectedIndexChanged += new System.EventHandler(this.cb_ChonThang_SelectedIndexChanged);
            // 
            // lb_ChonThang
            // 
            this.lb_ChonThang.AutoSize = true;
            this.lb_ChonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChonThang.Location = new System.Drawing.Point(22, 34);
            this.lb_ChonThang.Name = "lb_ChonThang";
            this.lb_ChonThang.Size = new System.Drawing.Size(69, 25);
            this.lb_ChonThang.TabIndex = 8;
            this.lb_ChonThang.Text = "Tháng";
            this.lb_ChonThang.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_Thang);
            this.tabPage2.Controls.Add(this.lb_Thang);
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Controls.Add(this.lb_Ngay);
            this.tabPage2.Controls.Add(this.dateTime_Ngay);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_Thang
            // 
            this.cb_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Thang.FormattingEnabled = true;
            this.cb_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_Thang.Location = new System.Drawing.Point(548, 27);
            this.cb_Thang.Name = "cb_Thang";
            this.cb_Thang.Size = new System.Drawing.Size(77, 28);
            this.cb_Thang.TabIndex = 11;
            this.cb_Thang.Visible = false;
            this.cb_Thang.SelectedIndexChanged += new System.EventHandler(this.cb_Thang_SelectedIndexChanged);
            // 
            // lb_Thang
            // 
            this.lb_Thang.AutoSize = true;
            this.lb_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Thang.Location = new System.Drawing.Point(464, 27);
            this.lb_Thang.Name = "lb_Thang";
            this.lb_Thang.Size = new System.Drawing.Size(69, 25);
            this.lb_Thang.TabIndex = 10;
            this.lb_Thang.Text = "Tháng";
            this.lb_Thang.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(3, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1168, 526);
            this.splitContainer1.SplitterDistance = 563;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ChiTietPhim);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 526);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phim";
            // 
            // dgv_ChiTietPhim
            // 
            this.dgv_ChiTietPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTietPhim.Location = new System.Drawing.Point(3, 23);
            this.dgv_ChiTietPhim.Name = "dgv_ChiTietPhim";
            this.dgv_ChiTietPhim.ReadOnly = true;
            this.dgv_ChiTietPhim.RowHeadersWidth = 51;
            this.dgv_ChiTietPhim.RowTemplate.Height = 24;
            this.dgv_ChiTietPhim.Size = new System.Drawing.Size(557, 500);
            this.dgv_ChiTietPhim.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ChiTietSanPham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 526);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm";
            // 
            // dgv_ChiTietSanPham
            // 
            this.dgv_ChiTietSanPham.AllowUserToAddRows = false;
            this.dgv_ChiTietSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ChiTietSanPham.Location = new System.Drawing.Point(3, 23);
            this.dgv_ChiTietSanPham.Name = "dgv_ChiTietSanPham";
            this.dgv_ChiTietSanPham.ReadOnly = true;
            this.dgv_ChiTietSanPham.RowHeadersWidth = 51;
            this.dgv_ChiTietSanPham.RowTemplate.Height = 24;
            this.dgv_ChiTietSanPham.Size = new System.Drawing.Size(595, 500);
            this.dgv_ChiTietSanPham.TabIndex = 1;
            // 
            // lb_Ngay
            // 
            this.lb_Ngay.AutoSize = true;
            this.lb_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngay.Location = new System.Drawing.Point(22, 27);
            this.lb_Ngay.Name = "lb_Ngay";
            this.lb_Ngay.Size = new System.Drawing.Size(108, 25);
            this.lb_Ngay.TabIndex = 5;
            this.lb_Ngay.Text = "Chọn ngày";
            // 
            // dateTime_Ngay
            // 
            this.dateTime_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_Ngay.Location = new System.Drawing.Point(210, 25);
            this.dateTime_Ngay.Name = "dateTime_Ngay";
            this.dateTime_Ngay.Size = new System.Drawing.Size(148, 30);
            this.dateTime_Ngay.TabIndex = 4;
            this.dateTime_Ngay.ValueChanged += new System.EventHandler(this.dateTime_Ngay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại thời gian";
            // 
            // cb_filterType
            // 
            this.cb_filterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filterType.FormattingEnabled = true;
            this.cb_filterType.Items.AddRange(new object[] {
            "Báo cáo theo ngày",
            "Báo cáo theo tháng"});
            this.cb_filterType.Location = new System.Drawing.Point(179, 32);
            this.cb_filterType.Name = "cb_filterType";
            this.cb_filterType.Size = new System.Drawing.Size(263, 28);
            this.cb_filterType.TabIndex = 7;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Location = new System.Drawing.Point(473, 29);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(169, 36);
            this.btn_ThongKe.TabIndex = 8;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.cb_filterType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DoanhThu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhim)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_filterType;
        private System.Windows.Forms.ComboBox cb_ChonThang;
        private System.Windows.Forms.Label lb_ChonThang;
        private System.Windows.Forms.Button btn_ThongKe;
        private System.Windows.Forms.DataGridView dgv_DoanhThu;
        private System.Windows.Forms.Label lb_Ngay;
        private System.Windows.Forms.DateTimePicker dateTime_Ngay;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ChiTietSanPham;
        private System.Windows.Forms.ComboBox cb_Thang;
        private System.Windows.Forms.Label lb_Thang;
    }
}
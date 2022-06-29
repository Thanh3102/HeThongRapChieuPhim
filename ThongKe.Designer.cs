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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_filterType = new System.Windows.Forms.ComboBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.cb_ChonThang = new System.Windows.Forms.ComboBox();
            this.lb_ChonThang = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartThongKe)).BeginInit();
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
            this.tabPage1.Controls.Add(this.cb_ChonThang);
            this.tabPage1.Controls.Add(this.lb_ChonThang);
            this.tabPage1.Controls.Add(this.ChartThongKe);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tổng quan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChartThongKe
            // 
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.Name = "ChartArea1";
            this.ChartThongKe.ChartAreas.Add(chartArea3);
            this.ChartThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend3.Name = "Legend1";
            this.ChartThongKe.Legends.Add(legend3);
            this.ChartThongKe.Location = new System.Drawing.Point(3, 133);
            this.ChartThongKe.Name = "ChartThongKe";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Vé";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Sản phẩm";
            this.ChartThongKe.Series.Add(series5);
            this.ChartThongKe.Series.Add(series6);
            this.ChartThongKe.Size = new System.Drawing.Size(1168, 456);
            this.ChartThongKe.TabIndex = 0;
            this.ChartThongKe.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Doanh thu theo ngày";
            this.ChartThongKe.Titles.Add(title3);
            this.ChartThongKe.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.cb_filterType.Location = new System.Drawing.Point(165, 33);
            this.cb_filterType.Name = "cb_filterType";
            this.cb_filterType.Size = new System.Drawing.Size(263, 28);
            this.cb_filterType.TabIndex = 7;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Location = new System.Drawing.Point(473, 28);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(169, 36);
            this.btn_ThongKe.TabIndex = 8;
            this.btn_ThongKe.Text = "Thống kê";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
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
            this.cb_ChonThang.Location = new System.Drawing.Point(97, 48);
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
            this.lb_ChonThang.Location = new System.Drawing.Point(22, 47);
            this.lb_ChonThang.Name = "lb_ChonThang";
            this.lb_ChonThang.Size = new System.Drawing.Size(69, 25);
            this.lb_ChonThang.TabIndex = 8;
            this.lb_ChonThang.Text = "Tháng";
            this.lb_ChonThang.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.ChartThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_filterType;
        private System.Windows.Forms.ComboBox cb_ChonThang;
        private System.Windows.Forms.Label lb_ChonThang;
        private System.Windows.Forms.Button btn_ThongKe;
    }
}
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_ViTriGhe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker_NgayChieu = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cb_KhungGio.Name = "cb_KhungGio";
            this.cb_KhungGio.Size = new System.Drawing.Size(127, 33);
            this.cb_KhungGio.TabIndex = 5;
            this.cb_KhungGio.DropDownClosed += new System.EventHandler(this.cb_KhungGio_DropDownClosed);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Chọn vị trí ghế";
            this.button1.UseVisualStyleBackColor = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(706, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thành tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 424);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách vé hiện tại";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 395);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 40);
            this.button2.TabIndex = 16;
            this.button2.Text = "Tạo vé";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1051, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 51);
            this.button3.TabIndex = 17;
            this.button3.Text = "Thanh toán";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(190, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 40);
            this.button4.TabIndex = 18;
            this.button4.Text = "Xóa vé";
            this.button4.UseVisualStyleBackColor = true;
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
            // TaoVePhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 850);
            this.Controls.Add(this.datePicker_NgayChieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_ViTriGhe);
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.TaoVePhim_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Phim;
        private System.Windows.Forms.ComboBox cb_KhungGio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Phong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_TheTV;
        private System.Windows.Forms.CheckBox checkbox_TheTV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_ViTriGhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePicker_NgayChieu;
    }
}
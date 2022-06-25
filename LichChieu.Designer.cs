namespace Hệ_thống_quản_lý_rạp_chiếu_phim
{
    partial class LichChieu
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
            this.gb_LichChieu = new System.Windows.Forms.GroupBox();
            this.dgv_LichChieu = new System.Windows.Forms.DataGridView();
            this.gb_CapNhat = new System.Windows.Forms.GroupBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cb_Phim = new System.Windows.Forms.ComboBox();
            this.cb_PhongChieu = new System.Windows.Forms.ComboBox();
            this.datePicker_NgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.timePicker_KhungGio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_LichChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichChieu)).BeginInit();
            this.gb_CapNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_LichChieu
            // 
            this.gb_LichChieu.Controls.Add(this.dgv_LichChieu);
            this.gb_LichChieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_LichChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_LichChieu.Location = new System.Drawing.Point(0, 291);
            this.gb_LichChieu.Name = "gb_LichChieu";
            this.gb_LichChieu.Size = new System.Drawing.Size(1232, 562);
            this.gb_LichChieu.TabIndex = 0;
            this.gb_LichChieu.TabStop = false;
            this.gb_LichChieu.Text = "Lịch chiếu";
            // 
            // dgv_LichChieu
            // 
            this.dgv_LichChieu.AllowUserToAddRows = false;
            this.dgv_LichChieu.AllowUserToDeleteRows = false;
            this.dgv_LichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LichChieu.Location = new System.Drawing.Point(3, 30);
            this.dgv_LichChieu.Name = "dgv_LichChieu";
            this.dgv_LichChieu.ReadOnly = true;
            this.dgv_LichChieu.RowHeadersWidth = 51;
            this.dgv_LichChieu.RowTemplate.Height = 24;
            this.dgv_LichChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LichChieu.Size = new System.Drawing.Size(1226, 529);
            this.dgv_LichChieu.TabIndex = 0;
            this.dgv_LichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LichChieu_CellClick);
            // 
            // gb_CapNhat
            // 
            this.gb_CapNhat.Controls.Add(this.btn_Xoa);
            this.gb_CapNhat.Controls.Add(this.btn_Them);
            this.gb_CapNhat.Controls.Add(this.cb_Phim);
            this.gb_CapNhat.Controls.Add(this.cb_PhongChieu);
            this.gb_CapNhat.Controls.Add(this.datePicker_NgayChieu);
            this.gb_CapNhat.Controls.Add(this.label4);
            this.gb_CapNhat.Controls.Add(this.timePicker_KhungGio);
            this.gb_CapNhat.Controls.Add(this.label3);
            this.gb_CapNhat.Controls.Add(this.label2);
            this.gb_CapNhat.Controls.Add(this.label1);
            this.gb_CapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CapNhat.Location = new System.Drawing.Point(0, 0);
            this.gb_CapNhat.Name = "gb_CapNhat";
            this.gb_CapNhat.Size = new System.Drawing.Size(1232, 291);
            this.gb_CapNhat.TabIndex = 13;
            this.gb_CapNhat.TabStop = false;
            this.gb_CapNhat.Text = "Cập nhật lịch chiếu";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Location = new System.Drawing.Point(936, 181);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(201, 47);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa lịch chiếu";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(936, 92);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(201, 47);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm lịch chiếu";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cb_Phim
            // 
            this.cb_Phim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Phim.FormattingEnabled = true;
            this.cb_Phim.Location = new System.Drawing.Point(204, 145);
            this.cb_Phim.Name = "cb_Phim";
            this.cb_Phim.Size = new System.Drawing.Size(528, 33);
            this.cb_Phim.TabIndex = 19;
            // 
            // cb_PhongChieu
            // 
            this.cb_PhongChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PhongChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PhongChieu.FormattingEnabled = true;
            this.cb_PhongChieu.Location = new System.Drawing.Point(204, 71);
            this.cb_PhongChieu.Name = "cb_PhongChieu";
            this.cb_PhongChieu.Size = new System.Drawing.Size(96, 33);
            this.cb_PhongChieu.TabIndex = 18;
            // 
            // datePicker_NgayChieu
            // 
            this.datePicker_NgayChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker_NgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker_NgayChieu.Location = new System.Drawing.Point(569, 217);
            this.datePicker_NgayChieu.Name = "datePicker_NgayChieu";
            this.datePicker_NgayChieu.Size = new System.Drawing.Size(161, 30);
            this.datePicker_NgayChieu.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày chiếu";
            // 
            // timePicker_KhungGio
            // 
            this.timePicker_KhungGio.CustomFormat = "HH:mm";
            this.timePicker_KhungGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker_KhungGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker_KhungGio.Location = new System.Drawing.Point(204, 217);
            this.timePicker_KhungGio.Name = "timePicker_KhungGio";
            this.timePicker_KhungGio.ShowUpDown = true;
            this.timePicker_KhungGio.Size = new System.Drawing.Size(96, 30);
            this.timePicker_KhungGio.TabIndex = 15;
            this.timePicker_KhungGio.Value = new System.DateTime(2022, 6, 20, 12, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Khung giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phòng chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên phim";
            // 
            // LichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 853);
            this.Controls.Add(this.gb_CapNhat);
            this.Controls.Add(this.gb_LichChieu);
            this.Name = "LichChieu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LichChieu_Load);
            this.gb_LichChieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichChieu)).EndInit();
            this.gb_CapNhat.ResumeLayout(false);
            this.gb_CapNhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_LichChieu;
        private System.Windows.Forms.DataGridView dgv_LichChieu;
        private System.Windows.Forms.GroupBox gb_CapNhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cb_Phim;
        private System.Windows.Forms.ComboBox cb_PhongChieu;
        private System.Windows.Forms.DateTimePicker datePicker_NgayChieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePicker_KhungGio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
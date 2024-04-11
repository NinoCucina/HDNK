namespace ThaoTacDuLieuHocSinh
{
    partial class BangHs
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
            this.TOP = new System.Windows.Forms.Label();
            this.TenHS = new System.Windows.Forms.Label();
            this.BoxTenHS = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.BoxGT = new System.Windows.Forms.TextBox();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.BoxNS = new System.Windows.Forms.TextBox();
            this.SDT = new System.Windows.Forms.Label();
            this.BoxSDT = new System.Windows.Forms.TextBox();
            this.XemDL = new System.Windows.Forms.Button();
            this.LuuMoi = new System.Windows.Forms.Button();
            this.SuaDL = new System.Windows.Forms.Button();
            this.LuuSua = new System.Windows.Forms.Button();
            this.MaKhoi = new System.Windows.Forms.Label();
            this.BoxMaKhoi = new System.Windows.Forms.TextBox();
            this.MaLop = new System.Windows.Forms.Label();
            this.BoxMaLop = new System.Windows.Forms.TextBox();
            this.MaHDNKTG = new System.Windows.Forms.Label();
            this.BoxMaHDNK = new System.Windows.Forms.TextBox();
            this.BoxTKTTSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxNMSVCX = new System.Windows.Forms.TextBox();
            this.Xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mkhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahdnk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHOCS = new System.Windows.Forms.Label();
            this.BoxMahs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TOP
            // 
            this.TOP.AutoSize = true;
            this.TOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TOP.Location = new System.Drawing.Point(197, 9);
            this.TOP.Name = "TOP";
            this.TOP.Size = new System.Drawing.Size(385, 32);
            this.TOP.TabIndex = 0;
            this.TOP.Text = "Thao Tác Dữ Liệu Học Sinh";
            this.TOP.Click += new System.EventHandler(this.label1_Click);
            // 
            // TenHS
            // 
            this.TenHS.AutoSize = true;
            this.TenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHS.Location = new System.Drawing.Point(298, 91);
            this.TenHS.Name = "TenHS";
            this.TenHS.Size = new System.Drawing.Size(110, 18);
            this.TenHS.TabIndex = 1;
            this.TenHS.Text = "Tên Học Sinh";
            // 
            // BoxTenHS
            // 
            this.BoxTenHS.Location = new System.Drawing.Point(420, 90);
            this.BoxTenHS.Name = "BoxTenHS";
            this.BoxTenHS.Size = new System.Drawing.Size(162, 22);
            this.BoxTenHS.TabIndex = 2;
            this.BoxTenHS.TextChanged += new System.EventHandler(this.BoxTenHS_TextChanged);
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.Location = new System.Drawing.Point(47, 130);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(76, 18);
            this.GioiTinh.TabIndex = 3;
            this.GioiTinh.Text = "Giới Tính";
            // 
            // BoxGT
            // 
            this.BoxGT.Location = new System.Drawing.Point(128, 127);
            this.BoxGT.Name = "BoxGT";
            this.BoxGT.Size = new System.Drawing.Size(162, 22);
            this.BoxGT.TabIndex = 4;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.Location = new System.Drawing.Point(324, 130);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(84, 18);
            this.NgaySinh.TabIndex = 5;
            this.NgaySinh.Text = "Ngày Sinh";
            // 
            // BoxNS
            // 
            this.BoxNS.Location = new System.Drawing.Point(420, 127);
            this.BoxNS.Name = "BoxNS";
            this.BoxNS.Size = new System.Drawing.Size(162, 22);
            this.BoxNS.TabIndex = 6;
            // 
            // SDT
            // 
            this.SDT.AutoSize = true;
            this.SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDT.Location = new System.Drawing.Point(81, 169);
            this.SDT.Name = "SDT";
            this.SDT.Size = new System.Drawing.Size(41, 18);
            this.SDT.TabIndex = 7;
            this.SDT.Text = "SDT";
            // 
            // BoxSDT
            // 
            this.BoxSDT.Location = new System.Drawing.Point(128, 168);
            this.BoxSDT.Name = "BoxSDT";
            this.BoxSDT.Size = new System.Drawing.Size(162, 22);
            this.BoxSDT.TabIndex = 8;
            // 
            // XemDL
            // 
            this.XemDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XemDL.Location = new System.Drawing.Point(635, 85);
            this.XemDL.Name = "XemDL";
            this.XemDL.Size = new System.Drawing.Size(101, 31);
            this.XemDL.TabIndex = 9;
            this.XemDL.Text = "Xem DL";
            this.XemDL.UseVisualStyleBackColor = true;
            // 
            // LuuMoi
            // 
            this.LuuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuuMoi.Location = new System.Drawing.Point(635, 122);
            this.LuuMoi.Name = "LuuMoi";
            this.LuuMoi.Size = new System.Drawing.Size(101, 31);
            this.LuuMoi.TabIndex = 10;
            this.LuuMoi.Text = "Lưu Mới";
            this.LuuMoi.UseVisualStyleBackColor = true;
            this.LuuMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuaDL
            // 
            this.SuaDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaDL.Location = new System.Drawing.Point(635, 159);
            this.SuaDL.Name = "SuaDL";
            this.SuaDL.Size = new System.Drawing.Size(101, 31);
            this.SuaDL.TabIndex = 11;
            this.SuaDL.Text = "Sửa DL";
            this.SuaDL.UseVisualStyleBackColor = true;
            // 
            // LuuSua
            // 
            this.LuuSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuuSua.Location = new System.Drawing.Point(635, 196);
            this.LuuSua.Name = "LuuSua";
            this.LuuSua.Size = new System.Drawing.Size(101, 31);
            this.LuuSua.TabIndex = 12;
            this.LuuSua.Text = "Lưu Sửa";
            this.LuuSua.UseVisualStyleBackColor = true;
            // 
            // MaKhoi
            // 
            this.MaKhoi.AutoSize = true;
            this.MaKhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhoi.Location = new System.Drawing.Point(333, 169);
            this.MaKhoi.Name = "MaKhoi";
            this.MaKhoi.Size = new System.Drawing.Size(75, 18);
            this.MaKhoi.TabIndex = 13;
            this.MaKhoi.Text = "Mã Khối ";
            // 
            // BoxMaKhoi
            // 
            this.BoxMaKhoi.Location = new System.Drawing.Point(420, 168);
            this.BoxMaKhoi.Name = "BoxMaKhoi";
            this.BoxMaKhoi.Size = new System.Drawing.Size(162, 22);
            this.BoxMaKhoi.TabIndex = 14;
            // 
            // MaLop
            // 
            this.MaLop.AutoSize = true;
            this.MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLop.Location = new System.Drawing.Point(47, 209);
            this.MaLop.Name = "MaLop";
            this.MaLop.Size = new System.Drawing.Size(64, 18);
            this.MaLop.TabIndex = 15;
            this.MaLop.Text = "Mã Lớp";
            // 
            // BoxMaLop
            // 
            this.BoxMaLop.Location = new System.Drawing.Point(128, 208);
            this.BoxMaLop.Name = "BoxMaLop";
            this.BoxMaLop.Size = new System.Drawing.Size(162, 22);
            this.BoxMaLop.TabIndex = 16;
            // 
            // MaHDNKTG
            // 
            this.MaHDNKTG.AutoSize = true;
            this.MaHDNKTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHDNKTG.Location = new System.Drawing.Point(298, 210);
            this.MaHDNKTG.Name = "MaHDNKTG";
            this.MaHDNKTG.Size = new System.Drawing.Size(152, 18);
            this.MaHDNKTG.TabIndex = 17;
            this.MaHDNKTG.Text = "Mã HĐNK tham gia";
            // 
            // BoxMaHDNK
            // 
            this.BoxMaHDNK.Location = new System.Drawing.Point(456, 208);
            this.BoxMaHDNK.Name = "BoxMaHDNK";
            this.BoxMaHDNK.Size = new System.Drawing.Size(126, 22);
            this.BoxMaHDNK.TabIndex = 18;
            // 
            // BoxTKTTSV
            // 
            this.BoxTKTTSV.Location = new System.Drawing.Point(18, 276);
            this.BoxTKTTSV.Name = "BoxTKTTSV";
            this.BoxTKTTSV.Size = new System.Drawing.Size(249, 22);
            this.BoxTKTTSV.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tìm kiếm thông tin học sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TimKiem
            // 
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.Location = new System.Drawing.Point(273, 271);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(101, 31);
            this.TimKiem.TabIndex = 21;
            this.TimKiem.Text = "Tìm Kiếm";
            this.TimKiem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(395, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhập mã sinh viên cần xóa";
            // 
            // BoxNMSVCX
            // 
            this.BoxNMSVCX.Location = new System.Drawing.Point(397, 280);
            this.BoxNMSVCX.Name = "BoxNMSVCX";
            this.BoxNMSVCX.Size = new System.Drawing.Size(249, 22);
            this.BoxNMSVCX.TabIndex = 23;
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(652, 276);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(101, 31);
            this.Xoa.TabIndex = 24;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bảng thông tin học sinh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.Ten,
            this.GT,
            this.NG,
            this.sodt,
            this.mkhoi,
            this.mLop,
            this.Mahdnk});
            this.dataGridView1.Location = new System.Drawing.Point(18, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 170);
            this.dataGridView1.TabIndex = 26;
            // 
            // MaHS
            // 
            this.MaHS.HeaderText = "Mã Học Sinh";
            this.MaHS.MinimumWidth = 6;
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 125;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Tên Học Sinh";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // GT
            // 
            this.GT.HeaderText = "Giới Tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            this.GT.Width = 125;
            // 
            // NG
            // 
            this.NG.HeaderText = "Ngày Sinh";
            this.NG.MinimumWidth = 6;
            this.NG.Name = "NG";
            this.NG.Width = 125;
            // 
            // sodt
            // 
            this.sodt.HeaderText = "Số Điện Thoại";
            this.sodt.MinimumWidth = 6;
            this.sodt.Name = "sodt";
            this.sodt.Width = 125;
            // 
            // mkhoi
            // 
            this.mkhoi.HeaderText = "Mã Khối";
            this.mkhoi.MinimumWidth = 6;
            this.mkhoi.Name = "mkhoi";
            this.mkhoi.Width = 125;
            // 
            // mLop
            // 
            this.mLop.HeaderText = "Mã Lớp";
            this.mLop.MinimumWidth = 6;
            this.mLop.Name = "mLop";
            this.mLop.Width = 125;
            // 
            // Mahdnk
            // 
            this.Mahdnk.HeaderText = "Mã HĐNK tham gia";
            this.Mahdnk.MinimumWidth = 6;
            this.Mahdnk.Name = "Mahdnk";
            this.Mahdnk.Width = 125;
            // 
            // mAHOCS
            // 
            this.mAHOCS.AutoSize = true;
            this.mAHOCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAHOCS.Location = new System.Drawing.Point(15, 91);
            this.mAHOCS.Name = "mAHOCS";
            this.mAHOCS.Size = new System.Drawing.Size(100, 18);
            this.mAHOCS.TabIndex = 27;
            this.mAHOCS.Text = "Mã học sinh";
            // 
            // BoxMahs
            // 
            this.BoxMahs.Location = new System.Drawing.Point(128, 90);
            this.BoxMahs.Name = "BoxMahs";
            this.BoxMahs.Size = new System.Drawing.Size(162, 22);
            this.BoxMahs.TabIndex = 28;
            // 
            // BangHs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.BoxMahs);
            this.Controls.Add(this.mAHOCS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.BoxNMSVCX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxTKTTSV);
            this.Controls.Add(this.BoxMaHDNK);
            this.Controls.Add(this.MaHDNKTG);
            this.Controls.Add(this.BoxMaLop);
            this.Controls.Add(this.MaLop);
            this.Controls.Add(this.BoxMaKhoi);
            this.Controls.Add(this.MaKhoi);
            this.Controls.Add(this.LuuSua);
            this.Controls.Add(this.SuaDL);
            this.Controls.Add(this.LuuMoi);
            this.Controls.Add(this.XemDL);
            this.Controls.Add(this.BoxSDT);
            this.Controls.Add(this.SDT);
            this.Controls.Add(this.BoxNS);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.BoxGT);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.BoxTenHS);
            this.Controls.Add(this.TenHS);
            this.Controls.Add(this.TOP);
            this.Name = "BangHs";
            this.Text = "BangHs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TOP;
        private System.Windows.Forms.Label TenHS;
        private System.Windows.Forms.TextBox BoxTenHS;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.TextBox BoxGT;
        private System.Windows.Forms.Label NgaySinh;
        private System.Windows.Forms.TextBox BoxNS;
        private System.Windows.Forms.Label SDT;
        private System.Windows.Forms.TextBox BoxSDT;
        private System.Windows.Forms.Button XemDL;
        private System.Windows.Forms.Button LuuMoi;
        private System.Windows.Forms.Button SuaDL;
        private System.Windows.Forms.Button LuuSua;
        private System.Windows.Forms.Label MaKhoi;
        private System.Windows.Forms.TextBox BoxMaKhoi;
        private System.Windows.Forms.Label MaLop;
        private System.Windows.Forms.TextBox BoxMaLop;
        private System.Windows.Forms.Label MaHDNKTG;
        private System.Windows.Forms.TextBox BoxMaHDNK;
        private System.Windows.Forms.TextBox BoxTKTTSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxNMSVCX;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NG;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mkhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahdnk;
        private System.Windows.Forms.Label mAHOCS;
        private System.Windows.Forms.TextBox BoxMahs;
    }
}


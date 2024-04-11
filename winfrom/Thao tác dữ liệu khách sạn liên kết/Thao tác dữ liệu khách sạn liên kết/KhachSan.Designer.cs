namespace Thao_tác_dữ_liệu_khách_sạn_liên_kết
{
    partial class KhachSan
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
            this.MaKS = new System.Windows.Forms.Label();
            this.BoxMaKS = new System.Windows.Forms.TextBox();
            this.TenKS = new System.Windows.Forms.Label();
            this.BoxTenKS = new System.Windows.Forms.TextBox();
            this.SĐT = new System.Windows.Forms.Label();
            this.BoxSDT = new System.Windows.Forms.TextBox();
            this.TK = new System.Windows.Forms.Label();
            this.BoxTK = new System.Windows.Forms.TextBox();
            this.ButTK = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Label();
            this.BoxXoa = new System.Windows.Forms.TextBox();
            this.ButXoa = new System.Windows.Forms.Button();
            this.ButXEM = new System.Windows.Forms.Button();
            this.ButLuu = new System.Windows.Forms.Button();
            this.ButSua = new System.Windows.Forms.Button();
            this.ButLuuSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thao tác dữ liệu khách sạn liên kết";
            // 
            // MaKS
            // 
            this.MaKS.AutoSize = true;
            this.MaKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKS.Location = new System.Drawing.Point(12, 56);
            this.MaKS.Name = "MaKS";
            this.MaKS.Size = new System.Drawing.Size(115, 18);
            this.MaKS.TabIndex = 1;
            this.MaKS.Text = "Mã Khách sạn";
            // 
            // BoxMaKS
            // 
            this.BoxMaKS.Location = new System.Drawing.Point(133, 55);
            this.BoxMaKS.Name = "BoxMaKS";
            this.BoxMaKS.Size = new System.Drawing.Size(135, 22);
            this.BoxMaKS.TabIndex = 2;
            // 
            // TenKS
            // 
            this.TenKS.AutoSize = true;
            this.TenKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKS.Location = new System.Drawing.Point(285, 56);
            this.TenKS.Name = "TenKS";
            this.TenKS.Size = new System.Drawing.Size(120, 18);
            this.TenKS.TabIndex = 3;
            this.TenKS.Text = "Tên Khách sạn";
            // 
            // BoxTenKS
            // 
            this.BoxTenKS.Location = new System.Drawing.Point(411, 56);
            this.BoxTenKS.Name = "BoxTenKS";
            this.BoxTenKS.Size = new System.Drawing.Size(135, 22);
            this.BoxTenKS.TabIndex = 4;
            // 
            // SĐT
            // 
            this.SĐT.AutoSize = true;
            this.SĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SĐT.Location = new System.Drawing.Point(86, 94);
            this.SĐT.Name = "SĐT";
            this.SĐT.Size = new System.Drawing.Size(41, 18);
            this.SĐT.TabIndex = 5;
            this.SĐT.Text = "SĐT";
            // 
            // BoxSDT
            // 
            this.BoxSDT.Location = new System.Drawing.Point(133, 93);
            this.BoxSDT.Name = "BoxSDT";
            this.BoxSDT.Size = new System.Drawing.Size(135, 22);
            this.BoxSDT.TabIndex = 6;
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.Location = new System.Drawing.Point(11, 132);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(255, 20);
            this.TK.TabIndex = 7;
            this.TK.Text = "Tìm kiếm thông tin khách sạn";
            // 
            // BoxTK
            // 
            this.BoxTK.Location = new System.Drawing.Point(15, 155);
            this.BoxTK.Name = "BoxTK";
            this.BoxTK.Size = new System.Drawing.Size(251, 22);
            this.BoxTK.TabIndex = 8;
            // 
            // ButTK
            // 
            this.ButTK.Location = new System.Drawing.Point(272, 155);
            this.ButTK.Name = "ButTK";
            this.ButTK.Size = new System.Drawing.Size(88, 23);
            this.ButTK.TabIndex = 9;
            this.ButTK.Text = "Tìm kiếm";
            this.ButTK.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.AutoSize = true;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(11, 193);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(205, 20);
            this.Xoa.TabIndex = 10;
            this.Xoa.Text = "Xóa khách sạn theo mã";
            // 
            // BoxXoa
            // 
            this.BoxXoa.Location = new System.Drawing.Point(15, 216);
            this.BoxXoa.Name = "BoxXoa";
            this.BoxXoa.Size = new System.Drawing.Size(251, 22);
            this.BoxXoa.TabIndex = 11;
            // 
            // ButXoa
            // 
            this.ButXoa.Location = new System.Drawing.Point(272, 216);
            this.ButXoa.Name = "ButXoa";
            this.ButXoa.Size = new System.Drawing.Size(88, 23);
            this.ButXoa.TabIndex = 12;
            this.ButXoa.Text = "Xóa";
            this.ButXoa.UseVisualStyleBackColor = true;
            // 
            // ButXEM
            // 
            this.ButXEM.Location = new System.Drawing.Point(411, 93);
            this.ButXEM.Name = "ButXEM";
            this.ButXEM.Size = new System.Drawing.Size(88, 23);
            this.ButXEM.TabIndex = 13;
            this.ButXEM.Text = "Xem DL";
            this.ButXEM.UseVisualStyleBackColor = true;
            // 
            // ButLuu
            // 
            this.ButLuu.Location = new System.Drawing.Point(411, 132);
            this.ButLuu.Name = "ButLuu";
            this.ButLuu.Size = new System.Drawing.Size(88, 23);
            this.ButLuu.TabIndex = 14;
            this.ButLuu.Text = "Lưu mới";
            this.ButLuu.UseVisualStyleBackColor = true;
            // 
            // ButSua
            // 
            this.ButSua.Location = new System.Drawing.Point(530, 94);
            this.ButSua.Name = "ButSua";
            this.ButSua.Size = new System.Drawing.Size(88, 23);
            this.ButSua.TabIndex = 15;
            this.ButSua.Text = "Sửa DL";
            this.ButSua.UseVisualStyleBackColor = true;
            // 
            // ButLuuSua
            // 
            this.ButLuuSua.Location = new System.Drawing.Point(530, 132);
            this.ButLuuSua.Name = "ButLuuSua";
            this.ButLuuSua.Size = new System.Drawing.Size(88, 23);
            this.ButLuuSua.TabIndex = 16;
            this.ButLuuSua.Text = "Lưu sửa";
            this.ButLuuSua.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MKS,
            this.TKS,
            this.SDT});
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bảng thông tin khách sạn";
            // 
            // MKS
            // 
            this.MKS.HeaderText = "Mã Khách Sạn";
            this.MKS.MinimumWidth = 6;
            this.MKS.Name = "MKS";
            this.MKS.Width = 150;
            // 
            // TKS
            // 
            this.TKS.HeaderText = "Tên khách sạn";
            this.TKS.MinimumWidth = 6;
            this.TKS.Name = "TKS";
            this.TKS.Width = 150;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // KhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButLuuSua);
            this.Controls.Add(this.ButSua);
            this.Controls.Add(this.ButLuu);
            this.Controls.Add(this.ButXEM);
            this.Controls.Add(this.ButXoa);
            this.Controls.Add(this.BoxXoa);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.ButTK);
            this.Controls.Add(this.BoxTK);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.BoxSDT);
            this.Controls.Add(this.SĐT);
            this.Controls.Add(this.BoxTenKS);
            this.Controls.Add(this.TenKS);
            this.Controls.Add(this.BoxMaKS);
            this.Controls.Add(this.MaKS);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KhachSan";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaKS;
        private System.Windows.Forms.TextBox BoxMaKS;
        private System.Windows.Forms.Label TenKS;
        private System.Windows.Forms.TextBox BoxTenKS;
        private System.Windows.Forms.Label SĐT;
        private System.Windows.Forms.TextBox BoxSDT;
        private System.Windows.Forms.Label TK;
        private System.Windows.Forms.TextBox BoxTK;
        private System.Windows.Forms.Button ButTK;
        private System.Windows.Forms.Label Xoa;
        private System.Windows.Forms.TextBox BoxXoa;
        private System.Windows.Forms.Button ButXoa;
        private System.Windows.Forms.Button ButXEM;
        private System.Windows.Forms.Button ButLuu;
        private System.Windows.Forms.Button ButSua;
        private System.Windows.Forms.Button ButLuuSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Label label2;
    }
}


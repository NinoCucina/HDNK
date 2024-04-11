namespace Bảng_trạng_thái
{
    partial class TrangThai
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
            this.MaTT = new System.Windows.Forms.Label();
            this.BoxMTT = new System.Windows.Forms.TextBox();
            this.TenTT = new System.Windows.Forms.Label();
            this.BoxTTT = new System.Windows.Forms.TextBox();
            this.Xem = new System.Windows.Forms.Button();
            this.Lưu = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.ButLuuSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTT = new System.Windows.Forms.Label();
            this.MTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng trạng thái";
            // 
            // MaTT
            // 
            this.MaTT.AutoSize = true;
            this.MaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaTT.Location = new System.Drawing.Point(12, 57);
            this.MaTT.Name = "MaTT";
            this.MaTT.Size = new System.Drawing.Size(106, 18);
            this.MaTT.TabIndex = 1;
            this.MaTT.Text = "Mã trạng thái";
            // 
            // BoxMTT
            // 
            this.BoxMTT.Location = new System.Drawing.Point(124, 56);
            this.BoxMTT.Name = "BoxMTT";
            this.BoxMTT.Size = new System.Drawing.Size(100, 22);
            this.BoxMTT.TabIndex = 2;
            // 
            // TenTT
            // 
            this.TenTT.AutoSize = true;
            this.TenTT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TenTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenTT.Location = new System.Drawing.Point(230, 57);
            this.TenTT.Name = "TenTT";
            this.TenTT.Size = new System.Drawing.Size(111, 18);
            this.TenTT.TabIndex = 3;
            this.TenTT.Text = "Tên trạng thái";
            // 
            // BoxTTT
            // 
            this.BoxTTT.Location = new System.Drawing.Point(347, 56);
            this.BoxTTT.Name = "BoxTTT";
            this.BoxTTT.Size = new System.Drawing.Size(100, 22);
            this.BoxTTT.TabIndex = 4;
            // 
            // Xem
            // 
            this.Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xem.Location = new System.Drawing.Point(24, 91);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(94, 31);
            this.Xem.TabIndex = 5;
            this.Xem.Text = "Xem DL";
            this.Xem.UseVisualStyleBackColor = true;
            // 
            // Lưu
            // 
            this.Lưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lưu.Location = new System.Drawing.Point(124, 91);
            this.Lưu.Name = "Lưu";
            this.Lưu.Size = new System.Drawing.Size(94, 31);
            this.Lưu.TabIndex = 6;
            this.Lưu.Text = "Lưu mới";
            this.Lưu.UseVisualStyleBackColor = true;
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Location = new System.Drawing.Point(224, 91);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(94, 31);
            this.Sua.TabIndex = 7;
            this.Sua.Text = "Sửa DL";
            this.Sua.UseVisualStyleBackColor = true;
            // 
            // ButLuuSua
            // 
            this.ButLuuSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButLuuSua.Location = new System.Drawing.Point(324, 91);
            this.ButLuuSua.Name = "ButLuuSua";
            this.ButLuuSua.Size = new System.Drawing.Size(94, 31);
            this.ButLuuSua.TabIndex = 8;
            this.ButLuuSua.Text = "Lưu sửa";
            this.ButLuuSua.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MTT,
            this.TTT});
            this.dataGridView1.Location = new System.Drawing.Point(15, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(432, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // BTT
            // 
            this.BTT.AutoSize = true;
            this.BTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTT.Location = new System.Drawing.Point(12, 138);
            this.BTT.Name = "BTT";
            this.BTT.Size = new System.Drawing.Size(138, 16);
            this.BTT.TabIndex = 10;
            this.BTT.Text = "Bảng dữ liệu trạng thái";
            // 
            // MTT
            // 
            this.MTT.HeaderText = "Mã trạng thái";
            this.MTT.MinimumWidth = 6;
            this.MTT.Name = "MTT";
            this.MTT.Width = 125;
            // 
            // TTT
            // 
            this.TTT.HeaderText = "Tên trạng thái";
            this.TTT.MinimumWidth = 6;
            this.TTT.Name = "TTT";
            this.TTT.Width = 125;
            // 
            // TrangThai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 321);
            this.Controls.Add(this.BTT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButLuuSua);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Lưu);
            this.Controls.Add(this.Xem);
            this.Controls.Add(this.BoxTTT);
            this.Controls.Add(this.TenTT);
            this.Controls.Add(this.BoxMTT);
            this.Controls.Add(this.MaTT);
            this.Controls.Add(this.label1);
            this.Name = "TrangThai";
            this.Text = "trangthai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaTT;
        private System.Windows.Forms.TextBox BoxMTT;
        private System.Windows.Forms.Label TenTT;
        private System.Windows.Forms.TextBox BoxTTT;
        private System.Windows.Forms.Button Xem;
        private System.Windows.Forms.Button Lưu;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button ButLuuSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTT;
        private System.Windows.Forms.Label BTT;
    }
}


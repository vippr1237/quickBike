
namespace QuickBikeProject.form
{
    partial class formChonDV
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
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaXe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbThoiGian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.chonBtn = new System.Windows.Forms.Button();
            this.themBtn = new System.Windows.Forms.Button();
            this.tbNgayKT = new System.Windows.Forms.TextBox();
            this.tbNgayBD = new System.Windows.Forms.TextBox();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.chonXeBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(12, 283);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 62;
            this.dgvDV.RowTemplate.Height = 28;
            this.dgvDV.Size = new System.Drawing.Size(482, 263);
            this.dgvDV.TabIndex = 0;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma DV";
            // 
            // tbMaDV
            // 
            this.tbMaDV.Enabled = false;
            this.tbMaDV.Location = new System.Drawing.Point(605, 38);
            this.tbMaDV.Name = "tbMaDV";
            this.tbMaDV.Size = new System.Drawing.Size(196, 26);
            this.tbMaDV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma Xe";
            // 
            // tbMaXe
            // 
            this.tbMaXe.Enabled = false;
            this.tbMaXe.Location = new System.Drawing.Point(605, 96);
            this.tbMaXe.Name = "tbMaXe";
            this.tbMaXe.Size = new System.Drawing.Size(196, 26);
            this.tbMaXe.TabIndex = 2;
            this.tbMaXe.TextChanged += new System.EventHandler(this.tbMaXe_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thoi Gian";
            // 
            // tbThoiGian
            // 
            this.tbThoiGian.Location = new System.Drawing.Point(605, 155);
            this.tbThoiGian.Name = "tbThoiGian";
            this.tbThoiGian.Size = new System.Drawing.Size(196, 26);
            this.tbThoiGian.TabIndex = 2;
            this.tbThoiGian.TextChanged += new System.EventHandler(this.tbThoiGian_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngay BD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngay KT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trang Thai";
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(605, 344);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(196, 26);
            this.tbStatus.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thanh Tien";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(605, 404);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(196, 26);
            this.tbTotal.TabIndex = 2;
            // 
            // chonBtn
            // 
            this.chonBtn.Location = new System.Drawing.Point(739, 462);
            this.chonBtn.Name = "chonBtn";
            this.chonBtn.Size = new System.Drawing.Size(87, 40);
            this.chonBtn.TabIndex = 3;
            this.chonBtn.Text = "Ket Thuc";
            this.chonBtn.UseVisualStyleBackColor = true;
            this.chonBtn.Click += new System.EventHandler(this.chonBtn_Click);
            // 
            // themBtn
            // 
            this.themBtn.Location = new System.Drawing.Point(532, 462);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(77, 40);
            this.themBtn.TabIndex = 3;
            this.themBtn.Text = "Them";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // tbNgayKT
            // 
            this.tbNgayKT.Enabled = false;
            this.tbNgayKT.Location = new System.Drawing.Point(605, 283);
            this.tbNgayKT.Name = "tbNgayKT";
            this.tbNgayKT.Size = new System.Drawing.Size(196, 26);
            this.tbNgayKT.TabIndex = 2;
            // 
            // tbNgayBD
            // 
            this.tbNgayBD.Enabled = false;
            this.tbNgayBD.Location = new System.Drawing.Point(605, 221);
            this.tbNgayBD.Name = "tbNgayBD";
            this.tbNgayBD.Size = new System.Drawing.Size(196, 26);
            this.tbNgayBD.TabIndex = 2;
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Location = new System.Drawing.Point(12, 38);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 62;
            this.dgvXe.RowTemplate.Height = 28;
            this.dgvXe.Size = new System.Drawing.Size(389, 206);
            this.dgvXe.TabIndex = 0;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // chonXeBtn
            // 
            this.chonXeBtn.Location = new System.Drawing.Point(411, 99);
            this.chonXeBtn.Name = "chonXeBtn";
            this.chonXeBtn.Size = new System.Drawing.Size(83, 35);
            this.chonXeBtn.TabIndex = 4;
            this.chonXeBtn.Text = "Chon";
            this.chonXeBtn.UseVisualStyleBackColor = true;
            this.chonXeBtn.Click += new System.EventHandler(this.chonXeBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Location = new System.Drawing.Point(630, 462);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(75, 40);
            this.xoaBtn.TabIndex = 5;
            this.xoaBtn.Text = "Xoa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // formChonDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 558);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.chonXeBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.chonBtn);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNgayKT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNgayBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbThoiGian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.dgvDV);
            this.Name = "formChonDV";
            this.Text = "formChonDV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbThoiGian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button chonBtn;
        private System.Windows.Forms.Button themBtn;
        private System.Windows.Forms.TextBox tbNgayKT;
        private System.Windows.Forms.TextBox tbNgayBD;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.Button chonXeBtn;
        private System.Windows.Forms.Button xoaBtn;
    }
}

namespace QuickBikeProject.form
{
    partial class formThongtinDN
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
            this.tbTDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMKmoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNhaplai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Dang Nhap";
            // 
            // tbTDN
            // 
            this.tbTDN.Enabled = false;
            this.tbTDN.Location = new System.Drawing.Point(182, 71);
            this.tbTDN.Name = "tbTDN";
            this.tbTDN.Size = new System.Drawing.Size(280, 26);
            this.tbTDN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mat Khau";
            // 
            // tbMK
            // 
            this.tbMK.Enabled = false;
            this.tbMK.Location = new System.Drawing.Point(182, 125);
            this.tbMK.Name = "tbMK";
            this.tbMK.PasswordChar = '*';
            this.tbMK.Size = new System.Drawing.Size(280, 26);
            this.tbMK.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mat Khau Moi";
            // 
            // tbMKmoi
            // 
            this.tbMKmoi.Location = new System.Drawing.Point(182, 195);
            this.tbMKmoi.Name = "tbMKmoi";
            this.tbMKmoi.PasswordChar = '*';
            this.tbMKmoi.Size = new System.Drawing.Size(280, 26);
            this.tbMKmoi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 0;
            // 
            // tbNhaplai
            // 
            this.tbNhaplai.Location = new System.Drawing.Point(182, 262);
            this.tbNhaplai.Name = "tbNhaplai";
            this.tbNhaplai.PasswordChar = '*';
            this.tbNhaplai.Size = new System.Drawing.Size(280, 26);
            this.tbNhaplai.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhap Lai";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(182, 324);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 43);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Cap Nhat";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(372, 324);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(90, 43);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Thoat";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // formThongtinDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 425);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.tbNhaplai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMKmoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTDN);
            this.Controls.Add(this.label1);
            this.Name = "formThongtinDN";
            this.Text = "formThongtinDN";
            this.Load += new System.EventHandler(this.formThongtinDN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMKmoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNhaplai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}
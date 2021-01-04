
namespace QuickBikeProject
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.noti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten Dang Nhap";
            // 
            // tbTDN
            // 
            this.tbTDN.Location = new System.Drawing.Point(223, 51);
            this.tbTDN.Name = "tbTDN";
            this.tbTDN.Size = new System.Drawing.Size(252, 26);
            this.tbTDN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mat Khau";
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(223, 125);
            this.tbMK.Name = "tbMK";
            this.tbMK.PasswordChar = '*';
            this.tbMK.Size = new System.Drawing.Size(252, 26);
            this.tbMK.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(223, 217);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(111, 54);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Dang Nhap";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(370, 217);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 54);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Thoat";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // noti
            // 
            this.noti.AutoSize = true;
            this.noti.Location = new System.Drawing.Point(219, 177);
            this.noti.Name = "noti";
            this.noti.Size = new System.Drawing.Size(0, 20);
            this.noti.TabIndex = 3;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 330);
            this.Controls.Add(this.noti);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTDN);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label noti;
    }
}
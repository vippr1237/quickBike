namespace QuickBikeProject
{
    partial class Home
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.filterBtn = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.freeRBtn = new System.Windows.Forms.RadioButton();
            this.usedRBtn = new System.Windows.Forms.RadioButton();
            this.allRBtn = new System.Windows.Forms.RadioButton();
            this.dgvXeThue = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timePick = new System.Windows.Forms.DateTimePicker();
            this.lbTotal = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinDangNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbGreet = new System.Windows.Forms.Label();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.chonDVBtn = new System.Windows.Forms.Button();
            this.chonKHBtn = new System.Windows.Forms.Button();
            this.lvDV = new System.Windows.Forms.ListView();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeThue)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.filterBtn);
            this.tabPage2.Controls.Add(this.tbSearch);
            this.tabPage2.Controls.Add(this.searchBtn);
            this.tabPage2.Controls.Add(this.freeRBtn);
            this.tabPage2.Controls.Add(this.usedRBtn);
            this.tabPage2.Controls.Add(this.allRBtn);
            this.tabPage2.Controls.Add(this.dgvXeThue);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1104, 649);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xe Thue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(614, 248);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(78, 34);
            this.filterBtn.TabIndex = 4;
            this.filterBtn.Text = "Loc";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(598, 62);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(268, 26);
            this.tbSearch.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(884, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(103, 38);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tim";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // freeRBtn
            // 
            this.freeRBtn.AutoSize = true;
            this.freeRBtn.Location = new System.Drawing.Point(614, 205);
            this.freeRBtn.Name = "freeRBtn";
            this.freeRBtn.Size = new System.Drawing.Size(108, 24);
            this.freeRBtn.TabIndex = 1;
            this.freeRBtn.Text = "Chua thue";
            this.freeRBtn.UseVisualStyleBackColor = true;
            // 
            // usedRBtn
            // 
            this.usedRBtn.AutoSize = true;
            this.usedRBtn.Location = new System.Drawing.Point(614, 153);
            this.usedRBtn.Name = "usedRBtn";
            this.usedRBtn.Size = new System.Drawing.Size(91, 24);
            this.usedRBtn.TabIndex = 1;
            this.usedRBtn.Text = "Da thue";
            this.usedRBtn.UseVisualStyleBackColor = true;
            // 
            // allRBtn
            // 
            this.allRBtn.AutoSize = true;
            this.allRBtn.Checked = true;
            this.allRBtn.Location = new System.Drawing.Point(614, 107);
            this.allRBtn.Name = "allRBtn";
            this.allRBtn.Size = new System.Drawing.Size(78, 24);
            this.allRBtn.TabIndex = 1;
            this.allRBtn.TabStop = true;
            this.allRBtn.Text = "Tat ca";
            this.allRBtn.UseVisualStyleBackColor = true;
            // 
            // dgvXeThue
            // 
            this.dgvXeThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeThue.Location = new System.Drawing.Point(17, 37);
            this.dgvXeThue.Name = "dgvXeThue";
            this.dgvXeThue.RowHeadersWidth = 62;
            this.dgvXeThue.RowTemplate.Height = 28;
            this.dgvXeThue.Size = new System.Drawing.Size(542, 595);
            this.dgvXeThue.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvDV);
            this.tabPage1.Controls.Add(this.chonKHBtn);
            this.tabPage1.Controls.Add(this.chonDVBtn);
            this.tabPage1.Controls.Add(this.timePick);
            this.tabPage1.Controls.Add(this.lbTotal);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.billBtn);
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.tbStatus);
            this.tabPage1.Controls.Add(this.tbMaNV);
            this.tabPage1.Controls.Add(this.tbMaKH);
            this.tabPage1.Controls.Add(this.tbMaHD);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1104, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoa Don";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // timePick
            // 
            this.timePick.Location = new System.Drawing.Point(749, 166);
            this.timePick.Name = "timePick";
            this.timePick.Size = new System.Drawing.Size(231, 26);
            this.timePick.TabIndex = 8;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(826, 556);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(27, 20);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "0d";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(658, 594);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(111, 43);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Tao Moi";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.Location = new System.Drawing.Point(902, 545);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(111, 43);
            this.billBtn.TabIndex = 6;
            this.billBtn.Text = "Thanh Toan";
            this.billBtn.UseVisualStyleBackColor = true;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(660, 545);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(111, 43);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Them";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Enabled = false;
            this.tbStatus.Location = new System.Drawing.Point(749, 215);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(264, 26);
            this.tbStatus.TabIndex = 4;
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(749, 114);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(264, 26);
            this.tbMaNV.TabIndex = 4;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Enabled = false;
            this.tbMaKH.Location = new System.Drawing.Point(749, 65);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(264, 26);
            this.tbMaKH.TabIndex = 4;
            // 
            // tbMaHD
            // 
            this.tbMaHD.Enabled = false;
            this.tbMaHD.Location = new System.Drawing.Point(749, 15);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(264, 26);
            this.tbMaHD.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Dich Vu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trang Thai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngay Lap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ma NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ma KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ma HD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(632, 637);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 682);
            this.tabControl1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thongTinDangNhapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thongTinDangNhapToolStripMenuItem
            // 
            this.thongTinDangNhapToolStripMenuItem.Name = "thongTinDangNhapToolStripMenuItem";
            this.thongTinDangNhapToolStripMenuItem.Size = new System.Drawing.Size(195, 29);
            this.thongTinDangNhapToolStripMenuItem.Text = "Thong tin dang nhap";
            this.thongTinDangNhapToolStripMenuItem.Click += new System.EventHandler(this.thongTinDangNhapToolStripMenuItem_Click);
            // 
            // lbGreet
            // 
            this.lbGreet.AutoSize = true;
            this.lbGreet.Location = new System.Drawing.Point(842, 9);
            this.lbGreet.Name = "lbGreet";
            this.lbGreet.Size = new System.Drawing.Size(71, 20);
            this.lbGreet.TabIndex = 5;
            this.lbGreet.Text = "Xin chao";
            // 
            // signOutBtn
            // 
            this.signOutBtn.Location = new System.Drawing.Point(994, 3);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(109, 30);
            this.signOutBtn.TabIndex = 6;
            this.signOutBtn.Text = "Dang Xuat";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // chonDVBtn
            // 
            this.chonDVBtn.Location = new System.Drawing.Point(985, 390);
            this.chonDVBtn.Name = "chonDVBtn";
            this.chonDVBtn.Size = new System.Drawing.Size(87, 56);
            this.chonDVBtn.TabIndex = 9;
            this.chonDVBtn.Text = "Chinh Sua";
            this.chonDVBtn.UseVisualStyleBackColor = true;
            this.chonDVBtn.Click += new System.EventHandler(this.chonDVBtn_Click);
            // 
            // chonKHBtn
            // 
            this.chonKHBtn.Location = new System.Drawing.Point(1019, 58);
            this.chonKHBtn.Name = "chonKHBtn";
            this.chonKHBtn.Size = new System.Drawing.Size(72, 41);
            this.chonKHBtn.TabIndex = 10;
            this.chonKHBtn.Text = "Chon";
            this.chonKHBtn.UseVisualStyleBackColor = true;
            this.chonKHBtn.Click += new System.EventHandler(this.chonKHBtn_Click);
            // 
            // lvDV
            // 
            this.lvDV.HideSelection = false;
            this.lvDV.Location = new System.Drawing.Point(658, 300);
            this.lvDV.Name = "lvDV";
            this.lvDV.Size = new System.Drawing.Size(318, 215);
            this.lvDV.TabIndex = 11;
            this.lvDV.UseCompatibleStateImageBehavior = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 720);
            this.Controls.Add(this.signOutBtn);
            this.Controls.Add(this.lbGreet);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Trang chu";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeThue)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RadioButton freeRBtn;
        private System.Windows.Forms.RadioButton usedRBtn;
        private System.Windows.Forms.RadioButton allRBtn;
        private System.Windows.Forms.DataGridView dgvXeThue;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker timePick;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinDangNhapToolStripMenuItem;
        private System.Windows.Forms.Label lbGreet;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button chonDVBtn;
        private System.Windows.Forms.Button chonKHBtn;
        private System.Windows.Forms.ListView lvDV;
    }
}


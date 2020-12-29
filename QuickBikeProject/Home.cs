using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickBikeProject
{
    public delegate void SendMessage(string value);
    public partial class Home : Form
    {
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        private string user;

        public Home()
        {
            InitializeComponent();
            this.Hide();
            Login loginForm = new Login(SetValue);
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                lbGreet.Text = "Xin chao " + user;
            }
            else
                this.Close();
        }
        private void SetValue(string value)
        {
            this.user = value;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadHD();
            
        }

        private void LoadHD() 
        {
            
            var bill = from h in quickBikeDB.HoaDon
                       select new
                       {
                           MaHD = h.MaHD,
                           MaNV = h.MaNV,
                           MaKH = h.MaKH,
                           TrangThai = h.TrangThai,
                           NgayLap = h.NgayLap,
                           ThanhTien = h.ThanhTien
                       };
            dataGridView1.DataSource = bill.ToList();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            Models.HoaDon new_hd = new Models.HoaDon();
            var id = from h in quickBikeDB.HoaDon
                     select h.MaHD;
            if (id.Count() == 0)
                new_hd.MaHD = 1;
            else
            {
                new_hd.MaHD = id.Max() + 1;
            }
            new_hd.NgayLap = DateTime.Now;

            quickBikeDB.HoaDon.Add(new_hd);
            quickBikeDB.SaveChanges();
        }
        private void LoadXeThue()
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var auth = quickBikeDB.User.SingleOrDefault(u => u.MaNV == user);
            if (auth.Admin == true)
            {
                Admin admin = new Admin();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ban khong co quyen truy cap");
            }
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login(SetValue);
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                lbGreet.Text = "Xin chao " + user;
            }
            else
                this.Close();
        }
    }
}

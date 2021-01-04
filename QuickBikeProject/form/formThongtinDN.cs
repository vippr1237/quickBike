using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickBikeProject.form
{
    public partial class formThongtinDN : Form
    {
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        private string username;
        public formThongtinDN()
        {
            InitializeComponent();
        }
        public formThongtinDN(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var user = quickBikeDB.User.SingleOrDefault(u => u.MaNV == username);
            if (tbMKmoi.Text == tbNhaplai.Text)
            {
                user.PassWord = tbMKmoi.Text;
                quickBikeDB.SaveChanges();
                tbMK.Text = user.PassWord;
                tbMKmoi.Clear();
                tbNhaplai.Clear();
            }
        }

        private void formThongtinDN_Load(object sender, EventArgs e)
        {
            var user = quickBikeDB.User.SingleOrDefault(u => u.MaNV == username);
            tbTDN.Text = user.MaNV;
            tbMK.Text = user.PassWord;
        }
    }
}

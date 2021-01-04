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
    public partial class Login : Form
    {
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        public SendMessage send;
        public Login()
        {
            InitializeComponent();
        }


        public Login(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = quickBikeDB.User.SingleOrDefault(u => u.MaNV == tbTDN.Text);
            if (user == null)
            {
                noti.Text = "Ten dang nhap khong ton tai";
            }
            else
            {
                if (user.PassWord != tbMK.Text)
                {
                    noti.Text = "Sai mat khau";
                    clear();
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    this.send(user.MaNV);
                    clear();
                }
            }
            if (DialogResult == DialogResult.OK)
                this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
        private void clear()
        {
            tbMK.Clear();
            tbTDN.Clear();
        }
    }
}

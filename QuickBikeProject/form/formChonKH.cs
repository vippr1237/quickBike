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
    public partial class formChonKH : Form
    {
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        public SendMessage send;
        public formChonKH()
        {
            InitializeComponent();
        }
        public formChonKH(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void formChonKH_Load(object sender, EventArgs e)
        {
            LoadGuest();
        }
        private void addGuestBtn_Click(object sender, EventArgs e)
        {
            Models.Guest new_guest = new Models.Guest();
            var id = from g in quickBikeDB.Guest
                     select g.MaKH;
            if (id.Count() == 0)
                new_guest.MaKH = 0;
            else
                new_guest.MaKH = id.Max() + 1;
            new_guest.TenKH = tbTenKH.Text;
            new_guest.CMND = tbCMND.Text;
            new_guest.NgaySinh = ngaySinhKH.Value;
            new_guest.SDT = tbSDT.Text;
            new_guest.Email = tbEmail.Text;
            new_guest.DiaChi = tbDiachi.Text;
            quickBikeDB.Guest.Add(new_guest);
            quickBikeDB.SaveChanges();
            LoadGuest();
        }
        private void dgvGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbMaKH.Text = dgvGuest.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbTenKH.Text = dgvGuest.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbCMND.Text = dgvGuest.Rows[e.RowIndex].Cells[2].Value.ToString();
            ngaySinhKH.Value = (DateTime)dgvGuest.Rows[e.RowIndex].Cells[3].Value;
            tbSDT.Text = dgvGuest.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbEmail.Text = dgvGuest.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbDiachi.Text = dgvGuest.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void LoadGuest()
        {
            var guests = from k in quickBikeDB.Guest
                         select new
                         {
                             MaKH = k.MaKH,
                             TenKH = k.TenKH,
                             CMND = k.CMND,
                             NgaySinh = k.NgaySinh,
                             SDT = k.SDT,
                             Email = k.Email,
                             DiaChi = k.DiaChi
                         };
            dgvGuest.DataSource = guests.ToList();
        }

        private void chonBtn_Click(object sender, EventArgs e)
        {
            if (tbMaKH.Text == "")
            {
                MessageBox.Show("Vui long chon khach hang");
            }
            else
            {
                this.send(tbMaKH.Text);
                this.Close();
            }
        }
    }
}

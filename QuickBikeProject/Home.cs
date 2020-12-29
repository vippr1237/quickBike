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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadHD();
            
        }

        private void LoadHD() 
        {
            Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
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
            Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
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
    }
}

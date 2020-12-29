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
    public partial class formXemHD : Form
    {
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        private string _date;
        public formXemHD()
        {
            InitializeComponent();
            
        }
        public formXemHD(string date) : this()
        {
            _date = date;
            LoadHD();
        }
        private void LoadHD()
        {
            DateTime date = Convert.ToDateTime(_date);
            label1.Text = "Danh sach hoa don ngay " + _date;
            var hd = quickBikeDB.HoaDon.Where(p => p.NgayLap == date);
            dgvHD.DataSource = hd.ToList();
        }

    }
}

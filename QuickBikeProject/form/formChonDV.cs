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
    public partial class formChonDV : Form
    {
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        private int bikerow;
        private List<Models.DichVu> dv = new List<Models.DichVu>();
        public SendDV send;
        public formChonDV()
        {
            InitializeComponent();
        }
        public formChonDV(SendDV sender, List<Models.DichVu> dichvu)
        {
            InitializeComponent();
            
            this.send = sender;
            this.dv = dichvu;
            LoadXe();
            if (dv.Count() > 0)
            {
                dgvDV.DataSource = dv.ToList();
            }
        }

        private void tbThoiGian_TextChanged(object sender, EventArgs e)
        {
            var isNumber = int.TryParse(tbThoiGian.Text, out int n);
            if (isNumber)
            {
                double time = double.Parse(tbThoiGian.Text);
                tbNgayBD.Text = DateTime.Now.ToString();
                tbNgayKT.Text = DateTime.Now.AddDays(time).ToString();
                if (tbMaXe.Text != "")
                {
                    var maXe = Int32.Parse(tbMaXe.Text);
                    var giaXe = quickBikeDB.Bike.FirstOrDefault(p => p.MaXe == maXe).DonGia;
                    tbTotal.Text = (Int32.Parse(tbThoiGian.Text)*giaXe).ToString();
                }
            }
            else if (tbThoiGian.Text == "")
            {
                tbNgayBD.Clear();
                tbNgayKT.Clear();
                tbTotal.Clear();
                return;
            }
            else
            {
                
                MessageBox.Show("Vui long nhap so");
                tbThoiGian.Clear();
            }
        }
        
        private void chonXeBtn_Click(object sender, EventArgs e)
        {
            tbMaXe.Text = dgvXe.Rows[bikerow].Cells[0].Value.ToString();
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bikerow = e.RowIndex;
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            var maXe = Int32.Parse(tbMaXe.Text);
            var check = dv.FirstOrDefault(b => b.MaXe == maXe);
            if (check != null || tbMaXe.Text == "")
            {
                MessageBox.Show("Vui long chon xe khac");
            }
            else if (tbThoiGian.Text == "")
            {
                MessageBox.Show("vui long nhap thoi gian");
            }
            else
            {
                Models.DichVu new_dv = new Models.DichVu();
                var id = from d in quickBikeDB.DichVu
                         select d.MaDV;
                if (dv.Count() != 0)
                {
                    var _id = from d in dv
                              select d.MaDV;
                    new_dv.MaDV = _id.Max() + 1;
                }
                else
                {
                    if (id.Count() == 0)
                        new_dv.MaDV = 1;
                    else
                        new_dv.MaDV = id.Max() + 1;
                }
                new_dv.MaXe = Int32.Parse(tbMaXe.Text);
                new_dv.ThoiGian = Int32.Parse(tbThoiGian.Text);
                new_dv.NgayBD = DateTime.Parse(tbNgayBD.Text);
                new_dv.NgayKT = DateTime.Parse(tbNgayKT.Text);
                new_dv.ThanhTien = float.Parse(tbTotal.Text);
                new_dv.TrangThai = "Dang su dung";
                dv.Add(new_dv);
                dgvDV.DataSource = dv.ToList();
                tbMaXe.Clear();
                tbThoiGian.Clear();
                LoadXe();
            }
        }
        private void xoaBtn_Click(object sender, EventArgs e)
        {
            var maDV = Int32.Parse(tbMaDV.Text);
            var rdv = dv.FirstOrDefault(p => p.MaDV == maDV);
            dv.Remove(rdv);
            dgvDV.DataSource = dv.ToList();
            LoadXe();
        }
        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaDV.Text = dgvDV.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbMaXe.Text = dgvDV.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbNgayBD.Text = dgvDV.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbNgayKT.Text = dgvDV.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbThoiGian.Text = dgvDV.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTotal.Text = dgvDV.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbStatus.Text = dgvDV.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void tbMaXe_TextChanged(object sender, EventArgs e)
        {
            if (tbMaXe.Text != "" && tbThoiGian.Text != "")
            {
                var maXe = Int32.Parse(tbMaXe.Text);
                var giaXe = quickBikeDB.Bike.FirstOrDefault(p => p.MaXe == maXe).DonGia;
                tbTotal.Text = (Int32.Parse(tbThoiGian.Text) * giaXe).ToString();
            }
        }
        private void chonBtn_Click(object sender, EventArgs e)
        {
            if (dv.Count() >0)
                this.send(dv);
            this.Close();
        }
        private void LoadXe()
        {
            var bikes = from b in quickBikeDB.Bike
                        where b.TrangThai == "Con Trong"
                        select new
                        {
                            MaXe = b.MaXe,
                            LoaiXe = b.LoaiXe,
                            TenXe = b.TenXe,
                            TrangThai = b.TrangThai
                        };
            foreach (Models.DichVu item in dv)
            {
                bikes = bikes.Where(b => b.MaXe != item.MaXe);
            }
            dgvXe.DataSource = bikes.ToList();
        }

 
    }
}

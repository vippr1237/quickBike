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
    public delegate void SendDV(List<Models.DichVu> dvs);
    public partial class Home : Form
    {
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        private string user;
        private string KH;
        private List<Models.DichVu> dv = new List<Models.DichVu>();
        public Home()
        {
            InitializeComponent();
            this.Hide();
            Login loginForm = new Login(SetUser);
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                lbGreet.Text = "Xin chao " + getUserName();
            }
            else
            {
                Load += Home_Load1;
            }
            lvDV.Columns.Add("Ma Xe", 50);
            lvDV.Columns.Add("Thoi Gian", 50);
            lvDV.Columns.Add("Thanh Tien", 50);
        }

        private void Home_Load1(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getUserName()
        {
            var userprofile = quickBikeDB.User.SingleOrDefault(u => u.MaNV == user).MaHoSo;
            var username = quickBikeDB.HoSo.SingleOrDefault(p => p.MaHoSo == userprofile).HoTen;
            return username;
        }
        private void SetUser(string value)
        {
            this.user = value;
        }
        private void SetKH(string value)
        {
            this.KH = value;
        }
        private void SetDV(List<Models.DichVu> dvs)
        {
            this.dv = dvs;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadHD();
            LoadXeThue();
            tbMaNV.Text = user;

        }
        //Hoa don
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
            if (tbMaHD.Text != "")
            {
                MessageBox.Show("Hoa Don da duoc su dung vui long nhap moi");
            }
            else
            {

                if (tbMaKH.Text == "")
                {
                    MessageBox.Show("Vui long chon khach hang");
                }
                else
                {
                    

                    if (tbMaNV.Text == "")
                    {
                        MessageBox.Show("Vui long nhap ma nhan vien");
                    }
                    else
                    {
                        if (dv.Count() == 0)
                        {
                            MessageBox.Show("Vui long chon dich vu");
                        }
                        else
                        {
                            if (id.Count() == 0)
                                new_hd.MaHD = 1;
                            else
                            {
                                new_hd.MaHD = id.Max() + 1;
                            }
                            new_hd.MaNV = tbMaNV.Text;
                            new_hd.MaKH = Int32.Parse(tbMaKH.Text);
                            new_hd.NgayLap = DateTime.Now;
                            new_hd.TrangThai = "Chua Thanh Toan";
                            foreach (Models.DichVu item in dv)
                            {
                                item.MaHD = new_hd.MaHD;
                                quickBikeDB.DichVu.Add(item);
                                var bike = quickBikeDB.Bike.FirstOrDefault(b => b.MaXe == item.MaXe);
                                bike.TrangThai = "Dang Thue";
                            }

                            var total = (from d in dv
                                         select d.ThanhTien).Sum();
                            lbTotal.Text = total.ToString() + "d";
                            new_hd.ThanhTien = total;
                            quickBikeDB.HoaDon.Add(new_hd);
                            quickBikeDB.SaveChanges();

                            LoadHD();
                            LoadXeThue();
                            clearHD();
                        }
                    }
                }
            }
        }
        // Xe thue
        private void searchBtn_Click(object sender, EventArgs e)
        {
            var bikes = quickBikeDB.Bike.Where(b => b.TenXe.Contains(tbSearch.Text)
                                            || b.LoaiXe.Contains(tbSearch.Text));

            if (bikes.Count() == 0)
            {
                MessageBox.Show("Khong tim thay xe");
            }
            else
            {
                if (usedRBtn.Checked == true)
                {
                    bikes = bikes.Where(b => b.TrangThai == "Dang Thue");
                }
                else if (freeRBtn.Checked == true)
                {
                    bikes = bikes.Where(b => b.TrangThai == "Con Trong");
                }
                dgvXeThue.DataSource = bikes.ToList();
            }
        }
        private void filterBtn_Click(object sender, EventArgs e)
        {
            LoadXeThue();
        }
        private void LoadXeThue()
        {
            var bikes = from b in quickBikeDB.Bike
                        select new
                        {
                            MaXe = b.MaXe,
                            TenXe = b.TenXe,
                            LoaiXe = b.LoaiXe,
                            NgayNhap = b.NgayNhap,
                            TrangThai = b.TrangThai,
                            DonGia = b.DonGia,
                        };
            if (usedRBtn.Checked == true)
            {
                bikes = bikes.Where(b => b.TrangThai == "Dang Thue");
            }
            if (freeRBtn.Checked == true)
            {
                bikes = bikes.Where(b => b.TrangThai == "Con Trong");
            }
            dgvXeThue.DataSource = bikes.ToList();
        }
        // admin + thong tin dang nhap
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var auth = quickBikeDB.User.SingleOrDefault(u => u.MaNV == user);
            if (auth.Admin == true)
            {
                Admin admin = new Admin();
                this.Visible = false;
                admin.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Ban khong co quyen truy cap");
            }
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login(SetUser);
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
                lbGreet.Text = "Xin chao " + user;
            }
            else
                this.Close();
        }
        private void thongTinDangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.formThongtinDN xem = new form.formThongtinDN(this.user);
            this.Visible = false;
            xem.ShowDialog();
            this.Visible = true;
        }

        private void chonDVBtn_Click(object sender, EventArgs e)
        {
            List<Models.DichVu> temp = new List<Models.DichVu>(dv);
            dv.Clear();
            form.formChonDV chonDV = new form.formChonDV(SetDV, dv);
            chonDV.ShowDialog();
            lvDV.Items.Clear();
            foreach (Models.DichVu item in dv)
            {
                string[] arr = new string[4];
                ListViewItem itm;
                arr[0] = item.MaXe.ToString();
                arr[1] = item.ThoiGian.ToString();
                arr[2] = item.ThanhTien.ToString();
                itm = new ListViewItem(arr);
                lvDV.Items.Add(itm);
            }
            lvDV.View = View.Details;
        }

        private void chonKHBtn_Click(object sender, EventArgs e)
        {
            form.formChonKH chonKH = new form.formChonKH(SetKH);
            chonKH.ShowDialog();
            tbMaKH.Text = KH;
        }
        private void clearHD()
        {
            tbMaKH.Clear();
            tbMaHD.Clear();
            dv.Clear();
            lvDV.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            else
            {
                lvDV.Items.Clear();
                tbMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbMaKH.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                timePick.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                lbTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() + "d";
                var maHD = Int32.Parse(tbMaHD.Text);
                var _dv = quickBikeDB.DichVu.Where(d => d.MaHD == maHD).ToList();

                foreach (Models.DichVu item in _dv)
                {
                    string[] arr = new string[4];
                    ListViewItem itm;
                    arr[0] = item.MaXe.ToString();
                    arr[1] = item.ThoiGian.ToString();
                    arr[2] = item.ThanhTien.ToString();
                    itm = new ListViewItem(arr);
                    lvDV.Items.Add(itm);
                }
                lvDV.View = View.Details;
            }
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ban co chac muon thanh toan hoa don nay", "Xac nhan thanh toan", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                var maHD = Int32.Parse(tbMaHD.Text);
                var bill = quickBikeDB.HoaDon.FirstOrDefault(b => b.MaHD == maHD);
                if (bill.TrangThai == "Da thanh toan")
                {
                    MessageBox.Show("Hoa don da thanh toan");
                }
                else
                {
                    bill.TrangThai = "Da thanh toan";
                    var _dv = quickBikeDB.DichVu.Where(d => d.MaHD == maHD).ToList();

                    foreach (Models.DichVu item in _dv)
                    {
                        item.TrangThai = "Da Ket Thuc";
                        var bike = quickBikeDB.Bike.FirstOrDefault(b => b.MaXe == item.MaXe);
                        bike.TrangThai = "Con Trong";
                    }
                    quickBikeDB.SaveChanges();
                    LoadHD();
                    LoadXeThue();
                    clearHD();
                    
                }
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearHD();
        }
    }
}

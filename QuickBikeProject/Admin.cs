using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;

namespace QuickBikeProject
{
    public partial class Admin : Form
    {
        List<string> listItems = new List<string>() {"Con Trong", "Dang Thue", "Hong"};
        Models.QuickBikeDBContext quickBikeDB = new Models.QuickBikeDBContext();
        public Admin()
        {
            InitializeComponent();
            LoadXe();
            LoadGuest();
            LoadNV();
            LoadDT();
            cbStatus.DataSource = listItems;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Models.Bike new_bike = new Models.Bike();
            var id = from b in quickBikeDB.Bike
                     select b.MaXe;
            if (id.Count() == 0)
                new_bike.MaXe = 0;
            else
                new_bike.MaXe = id.Max() + 1;
            new_bike.TenXe = tbTenXe.Text;
            new_bike.LoaiXe = tbLoaiXe.Text;
            new_bike.TrangThai = cbStatus.SelectedItem.ToString();
            new_bike.NgayNhap = ngaynhap.Value;
            new_bike.DonGia = Int32.Parse(tbDonGia.Text);
            quickBikeDB.Bike.Add(new_bike);
            quickBikeDB.SaveChanges();
            LoadXe();
        }
        private void dvgXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                textBox1.Text = dvgXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbTenXe.Text = dvgXe.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbLoaiXe.Text = dvgXe.Rows[e.RowIndex].Cells[2].Value.ToString();
                ngaynhap.Value = (DateTime)dvgXe.Rows[e.RowIndex].Cells[3].Value;
                cbStatus.SelectedItem = dvgXe.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbDonGia.Text = dvgXe.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void edit_bikeBtn_Click(object sender, EventArgs e)
        {
            var bike = quickBikeDB.Bike.SingleOrDefault(b => b.MaXe.ToString() == textBox1.Text);
            if (bike != null)
            {
                bike.TenXe = tbTenXe.Text;
                bike.LoaiXe = tbLoaiXe.Text;
                bike.NgayNhap = ngaynhap.Value;
                bike.TrangThai = cbStatus.SelectedItem.ToString();
                bike.DonGia = Int32.Parse(tbDonGia.Text);
                quickBikeDB.SaveChanges();
                LoadXe();
            }
            else
            {
                MessageBox.Show("Ma xe khong ton tai");
            }

        }
        private void delete_bikeBtn_Click(object sender, EventArgs e)
        {
            var bike = quickBikeDB.Bike.SingleOrDefault(b => b.MaXe.ToString() == textBox1.Text);
            if (bike != null)
            {
                quickBikeDB.Bike.Remove(bike);
                quickBikeDB.SaveChanges();
                LoadXe();
            }
            else
            {
                MessageBox.Show("Ma xe khong ton tai");
            }
        }
        private void LoadXe()
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
            dvgXe.DataSource = bikes.ToList();
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
        private void editGuestBtn_Click(object sender, EventArgs e)
        {
            var guest = quickBikeDB.Guest.SingleOrDefault(b => b.MaKH.ToString() == tbMaKH.Text);
            if (guest != null)
            {
                guest.TenKH = tbTenKH.Text;
                guest.CMND = tbCMND.Text;
                guest.SDT = tbSDT.Text;
                guest.NgaySinh = ngaySinhKH.Value;
                guest.DiaChi = tbDiachi.Text;
                guest.Email = tbEmail.Text;
                quickBikeDB.SaveChanges();
                LoadGuest();
            }
            else
            {
                MessageBox.Show("Ma khach hang khong ton tai");
            }
        }
        private void deleteGuestBtn_Click(object sender, EventArgs e)
        {
            var guest = quickBikeDB.Guest.SingleOrDefault(b => b.MaKH.ToString() == tbMaKH.Text);
            if (guest != null)
            {
                quickBikeDB.Guest.Remove(guest);
                quickBikeDB.SaveChanges();
                LoadGuest();
            }
            else
            {
                MessageBox.Show("Ma khach hang khong ton tai");
            }
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

        private void themNVBtn_Click(object sender, EventArgs e)
        {
            Models.HoSo new_profile = new Models.HoSo();
            Models.User new_user = new Models.User();
            var profile_id = from h in quickBikeDB.HoSo
                             select h.MaHoSo;
            var user_id = quickBikeDB.User.SingleOrDefault(u => u.MaNV == tbMaNV.Text);
            if (profile_id.Count() == 0)
            {
                new_profile.MaHoSo = 0;
            }
            else
            {
                new_profile.MaHoSo = profile_id.Max() + 1;
            }
            new_profile.HoTen = tbHoTenNV.Text;
            new_profile.NgaySinh = ngaysinhNV.Value;
            new_profile.SDT = tbSDTNV.Text;
            new_profile.DiaChi = tbDiaChiNV.Text;

            if (user_id != null)
            {
                MessageBox.Show("Ten da ton tai");
            }
            else
            {
                new_user.MaNV = tbMaNV.Text;
                new_user.PassWord = tbMK.Text;
                new_user.MaHoSo = new_profile.MaHoSo;
                new_user.Admin = cBAdmin.Checked;
                quickBikeDB.HoSo.Add(new_profile);
                quickBikeDB.User.Add(new_user);
                quickBikeDB.SaveChanges();
                LoadNV();
            }

        }

        private void editNVBtn_Click(object sender, EventArgs e)
        {
            var user = quickBikeDB.User.SingleOrDefault(u => u.MaNV == tbMaNV.Text);
            
            if (user == null)
            {
                MessageBox.Show("Ma nhan vien khong ton tai");
            }
            else
            {
                var profile = quickBikeDB.HoSo.SingleOrDefault(p => p.MaHoSo == user.MaHoSo);
                user.MaNV = tbMaNV.Text;
                user.PassWord = tbMK.Text;
                user.Admin = cBAdmin.Checked;
                profile.HoTen = tbHoTenNV.Text;
                profile.NgaySinh = ngaysinhNV.Value;
                profile.SDT = tbSDTNV.Text;
                profile.DiaChi = tbDiaChiNV.Text;
                quickBikeDB.SaveChanges();
                LoadNV();
            }
        }

        private void deleteNVBtn_Click(object sender, EventArgs e)
        {
            var user = quickBikeDB.User.SingleOrDefault(u => u.MaNV == tbMaNV.Text);
            
            if (user == null)
            {
                MessageBox.Show("Ma nhan vien khong ton tai");
            }
            else
            {
                var profile = quickBikeDB.HoSo.SingleOrDefault(p => p.MaHoSo == user.MaHoSo);
                quickBikeDB.HoSo.Remove(profile);
                quickBikeDB.User.Remove(user);
                quickBikeDB.SaveChanges();
                LoadNV();
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbMaNV.Text = dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbMK.Text = dgvNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            cBAdmin.Checked = (bool)dgvNV.Rows[e.RowIndex].Cells[2].Value;
            tbHoTenNV.Text = dgvNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            ngaysinhNV.Value = (DateTime)dgvNV.Rows[e.RowIndex].Cells[4].Value;
            tbSDTNV.Text = dgvNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbDiaChiNV.Text = dgvNV.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        private void LoadNV()
        {
            var nv = from u in quickBikeDB.User
                     join h in quickBikeDB.HoSo on u.MaHoSo equals h.MaHoSo
                     select new
                     {
                         MaNv = u.MaNV,
                         MatKhau = u.PassWord,
                         Quyen = u.Admin,
                         HoTen = h.HoTen,
                         NgaySinh = h.NgaySinh,
                         SDT = h.SDT,
                         DiaChi = h.DiaChi
                     };
            dgvNV.DataSource = nv.ToList();
        }
        private void LoadDT()
        {
            var dt = from hd in quickBikeDB.HoaDon
                     orderby hd.NgayLap
                     group hd by EntityFunctions.TruncateTime(hd.NgayLap) into g
                     let tongDT = g.Sum(m => m.ThanhTien)
                     select new
                     {
                         Ngay = g.Key.Value,
                         tongDT
                     };
            dgvDT.DataSource = dt.ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var dt = from hd in quickBikeDB.HoaDon
                     where hd.NgayLap >= batDau.Value && hd.NgayLap <= ketThuc.Value && hd.TrangThai == "Da thanh toan"
                     orderby hd.NgayLap
                     group hd by EntityFunctions.TruncateTime(hd.NgayLap) into g
                     let tongDT = g.Sum(m => m.ThanhTien)
                     select new
                     {
                         Ngay = g.Key.Value,
                         TongDT =tongDT
                     };
            dgvDT.DataSource = dt.ToList();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadDT();
        }

        private void dgvDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbNgayDT.Text = dgvDT.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDT.Text = dgvDT.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void xemHD_Click(object sender, EventArgs e)
        {
            if (tbNgayDT.Text == "")
            {
                MessageBox.Show("Vui long chon ngay");
            }
            else
            {
                form.formXemHD formXemHD = new form.formXemHD(tbNgayDT.Text);
                formXemHD.ShowDialog();
            }
        }
    }
}

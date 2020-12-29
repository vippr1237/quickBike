using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickBikeProject.Models
{
    public class Bike
    {
        [Key]
        public int MaXe { get; set; } 
        public string TenXe { get; set; }
        public string LoaiXe { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TrangThai { get; set; }
        public float DonGia { get; set; }
        public ICollection<DichVu> DichVu { get; set; }
    }
}

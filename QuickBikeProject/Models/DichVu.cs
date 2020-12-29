using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickBikeProject.Models
{
    public class DichVu
    {
        [Key]
        public int MaDV { get; set; }
        public int? MaXe { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public int ThoiGian { get; set; }
        public int? MaHD { get; set; }
        public float ThanhTien { get; set; }
        public string TrangThai { get; set; }
        public Bike Bike { get; set; }
        public HoaDon HoaDon { get; set; }
    }
}

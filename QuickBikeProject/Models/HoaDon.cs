using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickBikeProject.Models
{
    public class HoaDon
    {
        [Key]
        public int MaHD { get; set; }
        public int? MaKH { get; set; }
        [Required]
        public string MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public float ThanhTien { get; set; }
        public string TrangThai { get; set; }
        public ICollection<DichVu> DichVu { get; set; }
        public Guest Guest { get; set; }
        public User User { get; set; }
    }
}

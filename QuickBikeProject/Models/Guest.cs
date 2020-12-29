using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickBikeProject.Models
{
    public class Guest
    {
        [Key]
        public int MaKH { get; set; }
        [StringLength(30)]
        [Required]
        public string TenKH { get; set; }
        [Required]
        public string CMND { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}

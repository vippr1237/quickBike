using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace QuickBikeProject.Models
{
    public class User
    {
        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }
        [StringLength(10)]
        [Required]
        public string PassWord { get; set; }
        public bool Admin { get; set; }
        public int? MaHoSo { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
        public HoSo HoSo { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickBikeProject.Models
{
    public class Shift
    {
        [Key]
        public int MaCa { get; set; }
        public DateTime Ngay { get; set; }
        public int Ca { get; set; }
        public string MaNV { get; set; }
        public User User { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}

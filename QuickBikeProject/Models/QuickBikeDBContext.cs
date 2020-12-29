using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
namespace QuickBikeProject.Models
{
    public class QuickBikeDBContext : DbContext
    {
        public QuickBikeDBContext() : base("QuickBikeConnectionString")
        {

        }
        public DbSet<Bike> Bike { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoSo> HoSo { get; set; }

    }
}

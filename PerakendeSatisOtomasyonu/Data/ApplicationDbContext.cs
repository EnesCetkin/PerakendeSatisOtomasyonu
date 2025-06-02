using Microsoft.EntityFrameworkCore;
using PerakendeSatisOtomasyonu.Models;

namespace PerakendeSatisOtomasyonu.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}

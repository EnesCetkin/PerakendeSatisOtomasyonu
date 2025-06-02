using Microsoft.AspNetCore.Mvc;
using PerakendeSatisOtomasyonu.Data;
using PerakendeSatisOtomasyonu.Models;

namespace PerakendeSatisOtomasyonu.Controllers
{
    public class UrunController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UrunController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var urunler = _context.Urunler.ToList(); // Veritabanından ürünleri çek
            return View(urunler); // View’a gönder
        }
    }
}

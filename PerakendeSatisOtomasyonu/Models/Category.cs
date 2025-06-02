namespace PerakendeSatisOtomasyonu.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<Urun> Urunler { get; set; }  // Bu kategoriye ait ürünler
    }
}

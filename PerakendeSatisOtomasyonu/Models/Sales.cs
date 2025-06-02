namespace PerakendeSatisOtomasyonu.Models
{
    public class Satis
    {
        public int Id { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }
        public int Adet { get; set; }
        public decimal ToplamFiyat { get; set; }
        public DateTime SatisTarihi { get; set; }
    }
}

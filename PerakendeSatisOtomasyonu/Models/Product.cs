namespace PerakendeSatisOtomasyonu.Models
{
    public class Urun
    {
        public int Id { get; set; }                // Primary key
        public string Ad { get; set; }             // Ürün adý
        public string Aciklama { get; set; }       // Açýklama
        public decimal Fiyat { get; set; }          // Fiyat
        public int KategoriId { get; set; }         // Kategori ile iliþki için foreign key
        public Kategori Kategori { get; set; }      // Navigation property - kategori bilgisi
    }
}
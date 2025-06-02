namespace PerakendeSatisOtomasyonu.Models
{
    public class Urun
    {
        public int Id { get; set; }                // Primary key
        public string Ad { get; set; }             // �r�n ad�
        public string Aciklama { get; set; }       // A��klama
        public decimal Fiyat { get; set; }          // Fiyat
        public int KategoriId { get; set; }         // Kategori ile ili�ki i�in foreign key
        public Kategori Kategori { get; set; }      // Navigation property - kategori bilgisi
    }
}
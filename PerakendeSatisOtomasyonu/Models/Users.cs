namespace PerakendeSatisOtomasyonu.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }   // �rn: Admin, Kasiyer, SatisDanismani
    }
}

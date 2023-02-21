namespace TurkiyeBolgelerSehirler.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public int BolgeId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string SehirAd { get; set; } = string.Empty;
        public int Nufus { get; set; }
        public Bolge Bolgeler { get; set; } 

    }
}

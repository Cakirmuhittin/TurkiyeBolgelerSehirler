namespace TurkiyeBolgelerSehirler.Models
{
    public class Bolge
    {
        public int Id { get; set; }
        public string BolgeAd { get; set; }=string.Empty;
        public string Slug { get; set; }=string.Empty;
        public List<Sehir> Sehirler { get; set; } = new();

    }
}

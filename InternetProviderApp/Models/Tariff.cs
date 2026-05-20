namespace InternetProviderApp.Models
{
    public class Tariff
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Speed { get; set; }
    }
}
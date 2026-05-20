namespace InternetProviderApp.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
        public string ContractNumber { get; set; } = "";
        public int TariffId { get; set; }
        public string TariffName { get; set; } = "";
        public bool IsActive { get; set; } = true;
    }
}
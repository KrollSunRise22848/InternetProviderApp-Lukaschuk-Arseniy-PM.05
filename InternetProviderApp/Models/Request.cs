using System;

namespace InternetProviderApp.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int SubscriberId { get; set; }
        public string SubscriberName { get; set; } = "";
        public int TariffId { get; set; }
        public string TariffName { get; set; } = "";
        public DateTime Date { get; set; }
        public string Status { get; set; } = "новая";
    }
}
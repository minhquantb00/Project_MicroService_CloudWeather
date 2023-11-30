namespace CloudWeather.Temperature.Entities
{
    public class Temperature
    {
        public Guid Id { get; set; }
        public DateTime CreateOn { get; set; }
        public decimal TempHighF { get; set; }
        public decimal TempLowF { get; set; }
        public string ZipCode { get; set; }
    }
}

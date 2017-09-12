namespace HealthAPI.Lib
{
    public class Location
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }
    
    public class LocationRoot
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string tzOffset { get; set; }
        public string name { get; set; }
        public string source { get; set; }
        public Location location { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string humanId { get; set; }
    }
}

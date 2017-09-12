namespace HealthAPI.Lib
{
    public class BloodGlucose
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string timestamp { get; set; }
        public string tzOffset { get; set; }
        public int value { get; set; }
        public string unit { get; set; }
        public string source { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string humanId { get; set; }
    }
}

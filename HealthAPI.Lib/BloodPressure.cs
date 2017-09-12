namespace HealthAPI.Lib
{
    public class BloodPressure
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string timestamp { get; set; }
        public string tzOffset { get; set; }
        public int systolic { get; set; }
        public int diastolic { get; set; }
        public string unit { get; set; }
        public int heartRate { get; set; }
        public string source { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string humanId { get; set; }
    }
}

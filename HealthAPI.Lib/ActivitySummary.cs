namespace HealthAPI.Lib
{
    public class ActivitySummary
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string tzOffset { get; set; }
        public string type { get; set; }
        public string source { get; set; }
        public int duration { get; set; }
        public int distance { get; set; }
        public int steps { get; set; }
        public double calories { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string humanId { get; set; }
    }
}

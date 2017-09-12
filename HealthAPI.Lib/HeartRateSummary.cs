using System.Collections.Generic;

namespace HealthAPI.Lib
{
    public class Zone
    {
        public string name { get; set; }
        public int max { get; set; }
        public int min { get; set; }
        public int duration { get; set; }
        public double caloriesBurned { get; set; }
    }

    public class HeartRateSummary
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string date { get; set; }
        public List<Zone> zones { get; set; }
        public int restingHR { get; set; }
        public int averageHR { get; set; }
        public int maxHR { get; set; }
        public int minHR { get; set; }
        public string source { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string humanId { get; set; }
    }
}

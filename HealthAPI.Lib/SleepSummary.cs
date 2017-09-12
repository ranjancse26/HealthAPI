namespace HealthAPI.Lib
{
    public class SleepSummary
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string day { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string tzOffset { get; set; }
        public string source { get; set; }
        public bool mainSleep { get; set; }
        public int timeAsleep { get; set; }
        public int timeAwake { get; set; }
        public int efficiency { get; set; }
        public int timeToFallAsleep { get; set; }
        public int timeAfterWakeup { get; set; }
        public int timeInBed { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string humanId { get; set; }
    }
}

namespace HealthAPI.Lib
{
    public class HealthSummary
    {
        public string humanId { get; set; }
        public string userId { get; set; }
        public string createdAt { get; set; }
        public BloodGlucose bloodGlucose { get; set; }
        public BloodOxygen bloodOxygen { get; set; }
        public BloodPressure bloodPressure { get; set; }
        public Bmi bmi { get; set; }
        public BodyFat bodyFat { get; set; }
        public Height height { get; set; }
        public HeartRate heartRate { get; set; }
        public Weight weight { get; set; }
        public ActivitySummary activitySummary { get; set; }
        public SleepSummary sleepSummary { get; set; }
    }
}

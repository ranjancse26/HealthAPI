namespace HealthAPI.Lib
{
    public class Amount
    {
        public string unit { get; set; }
        public int value { get; set; }
    }

    public class Meal
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string source { get; set; }
        public string timestamp { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public Amount amount { get; set; }
        public double calories { get; set; }
        public double carbohydrate { get; set; }
        public double fat { get; set; }
        public double protein { get; set; }
        public double sodium { get; set; }
        public double fiber { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public string tzOffset { get; set; }
        public string humanId { get; set; }
        public double? sugar { get; set; }
        public int? calcium { get; set; }
        public double? cholesterol { get; set; }
        public int? iron { get; set; }
        public int? monounsaturatedFat { get; set; }
        public int? polyunsaturatedFat { get; set; }
        public int? potassium { get; set; }
        public double? saturatedFat { get; set; }
        public int? vitaminA { get; set; }
        public int? vitaminC { get; set; }
    }
}

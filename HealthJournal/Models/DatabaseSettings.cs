namespace HealthJournal.Models
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string MealCollectionName { get; set; }
        public string DessertCollectionName { get; set; }
    }
}

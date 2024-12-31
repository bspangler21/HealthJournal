using HealthJournal.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HealthJournal.Services
{
    public class DessertService
    {
        private readonly IMongoCollection<Dessert> _desserts;

        public DessertService(IOptions<DatabaseSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _desserts = database.GetCollection<Dessert>(settings.Value.DessertCollectionName);
        }

        public async Task<List<Dessert>> GetDessertsAsync()
        {
            var dessertResults = await _desserts.FindAsync(_ => true);
            var desserts = await dessertResults.ToListAsync();
            Console.WriteLine("Desserts found: " + desserts.Count);
            return desserts;
        }

        public async Task CreateDessertAsync(Dessert newDessert)
        {
            await _desserts.InsertOneAsync(newDessert);
        }
    }
}

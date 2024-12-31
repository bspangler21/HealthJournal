using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthJournal.Models
{
    public class Dessert
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string? _id { get; set; }

        [BsonElement("name")]
        public string name { get; set; } = null!;

        [BsonElement("quantity")]
        public int quantity { get; set; }

        [BsonElement("mealId")]
        public string mealId { get; set; } = null!;
    }
}

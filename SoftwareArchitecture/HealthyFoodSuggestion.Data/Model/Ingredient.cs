using HealthyFoodSuggestion.Model.Enum;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthyFoodSuggestion.Data.Model
{
    public class Ingredient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public byte Group { get; set; }
        public string Name { get; set; }
    }
}
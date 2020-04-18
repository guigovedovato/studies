using System;
using HealthyFoodSuggestion.Domain.Enum;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthyFoodSuggestion.Data.Model
{
    public class Ingredient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public FoodGroup Group { get; set; }
        public string Name { get; set; }
    }
}
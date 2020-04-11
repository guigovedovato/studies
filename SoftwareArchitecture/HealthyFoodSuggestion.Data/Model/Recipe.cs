using System.Collections.Generic;
using HealthyFoodSuggestion.Model.Enum;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthyFoodSuggestion.Data.Model
{
    public class Recipe
    {
        public Recipe()
        {
            this.Ingredients = new List<Ingredient>();
        }
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public byte Type { get; set; }       
        public string Description { get; set; }
    }
}
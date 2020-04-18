using System;
using System.Collections.Generic;
using HealthyFoodSuggestion.Domain.Enum;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HealthyFoodSuggestion.Data.Model
{
    public class Recipe
    {
        public Recipe() => this.Ingredients = new List<Ingredient>();

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public RecipeType Type { get; set; }     
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
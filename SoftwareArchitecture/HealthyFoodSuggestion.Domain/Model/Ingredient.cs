using System;
using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Domain.Model
{
    public class Ingredient
    {
        public Guid Id { get; set; }
        public FoodGroup Group { get; set; }
        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Domain.Model
{
    public class Recipe
    {
        public Recipe() => this.Ingredients = new List<Ingredient>();

        public Guid Id { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public RecipeType Type { get; set; }     
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
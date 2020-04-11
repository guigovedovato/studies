using System.Collections.Generic;
using HealthyFoodSuggestion.Model.Enum;

namespace HealthyFoodSuggestion.Model.Business
{
    public class Recipe
    {
        public Recipe()
        {
            this.Ingredients = new List<Ingredient>();
        }
        
        public int Id { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public RecipeType Type { get; set; }     
        public string Description { get; set; }
    }
}
using System.Linq;
using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Model.Enum;

namespace HealthyFoodSuggestion.Data.Model
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IEnumerable<Recipe> recipes;

        public RecipeRepository()
        {
            this.recipes = new List<Recipe>
            {
                new Recipe 
                { 
                    Id = 1,
                    Type = RecipeType.Vegan,
                    Description = "Bla Bla Bla",
                    Ingredients = new List<Ingredient> 
                    {
                        new Ingredient { Id = 1, Name = "beterraba", Group = FoodGroup.Vegetables }
                    }
                }
            };
        }

        public IEnumerable<Recipe> RetrieveRecipes(Ingredient ingredient, RecipeType type)
        {
            return this.recipes
                            .Where(r => r.Ingredients.Where(i => i.Id == ingredient.Id).Any() && r.Type == type)
                            .ToList();
        }
    }
}
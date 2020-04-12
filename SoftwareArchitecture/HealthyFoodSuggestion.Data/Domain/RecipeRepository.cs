using System.Linq;
using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Domain.Business;
using HealthyFoodSuggestion.Domain.Enum;
using System.Threading.Tasks;

namespace HealthyFoodSuggestion.Data.Domain
{
    internal class RecipeRepository : IRecipeRepository
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

        public async Task<IEnumerable<Recipe>> RetrieveRecipesAsync(Ingredient ingredient, RecipeType type)
        {
            return this.recipes
                            .Where(r => 
                                    r.Ingredients.Where(i => i.Id == ingredient.Id).Any() && 
                                    r.Type == type)
                            .ToList();
        }
    }
}
using System.Linq;
using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Data.Model;
using HealthyFoodSuggestion.Domain.Enum;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Data.Mapper;

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
                    Type = (byte)RecipeType.Vegan,
                    Description = "Bla Bla Bla",
                    Ingredients = new List<Ingredient> 
                    {
                        new Ingredient { Id = 1, Name = "beterraba", Group = (byte)FoodGroup.Vegetables }
                    }
                }
            };
        }

        public async Task<IEnumerable<HealthyFoodSuggestion.Domain.Model.Recipe>> RetrieveRecipesAsync(HealthyFoodSuggestion.Domain.Model.Ingredient ingredient, RecipeType type)
        {
            return this.recipes
                            .Where(r => 
                                    r.Ingredients.Where(i => i.Id == ingredient.Id).Any() && 
                                    r.Type == (byte)type)
                            .ToList().ToDomain();
        }
    }
}
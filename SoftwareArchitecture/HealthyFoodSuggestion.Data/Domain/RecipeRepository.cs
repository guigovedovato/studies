using System;
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
            => this.recipes = new List<Recipe>
                {
                    new Recipe
                    {
                        Id = Guid.NewGuid(),
                        Type = RecipeType.Vegetarian,
                        Description = "Bla Bla Bla",
                        Ingredients = new List<Ingredient>
                        {
                            new Ingredient
                            {
                                Id = Guid.Parse("505eb5c9-52e2-4d8a-a05c-cdf0e8ebf158"),
                                Name = "beterraba",
                                Group = FoodGroup.Vegetables
                            }
                        }
                    }
                };

        public async Task<IEnumerable<HealthyFoodSuggestion.Domain.Model.Recipe>> RetrieveRecipesAsync(HealthyFoodSuggestion.Domain.Model.Ingredient ingredient, RecipeType type) 
            => this.recipes
                    .Where(r =>
                            r.Ingredients.Where(i => i.Id.Equals(ingredient.Id)).Any() &&
                            r.Type == type)
                    .ToList().ToDomain();
    }
}
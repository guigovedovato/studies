using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Model;

namespace HealthyFoodSuggestion.Data.Mapper
{
    public static class RecipeExtension
    {
        public static IEnumerable<HealthyFoodSuggestion.Domain.Model.Recipe> ToDomain(this IEnumerable<Recipe> data)
        {
            foreach (var recipe in data)
            {
                yield return new HealthyFoodSuggestion.Domain.Model.Recipe
                {
                    Description = recipe.Description,
                    Id = recipe.Id,
                    Type = recipe.Type,
                    Ingredients = GetIngredient(recipe.Ingredients)
                };
            }
        }

        private static IEnumerable<HealthyFoodSuggestion.Domain.Model.Ingredient> GetIngredient(IEnumerable<Ingredient> ingredients)
        {
            foreach (var item in ingredients)
            {
                yield return item.ToDomain();
            }
        }
    }
}
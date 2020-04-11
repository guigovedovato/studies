using System;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Model.Enum;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Business.Recipe
{
    public class RecipeServiceCreator : IRecipeCreator
    {
        private readonly IRecipeRepository recipeRepository;

        public RecipeServiceCreator(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository ?? throw new ArgumentNullException(nameof(recipeRepository));
        }

        public IRecipeService Create(RecipeType type)
        {
            switch (type)
            {
                case RecipeType.Vegan:
                    return new VeganRecipeService(recipeRepository);
                case RecipeType.Vegetarian:
                    return new VegetarianRecipeService(recipeRepository);
                case RecipeType.Omnivore:
                    return new OmnivoreRecipeService(recipeRepository);
                default:
                    throw new ApplicationException("Recipe Type unknown");
            }
        }
    }
}
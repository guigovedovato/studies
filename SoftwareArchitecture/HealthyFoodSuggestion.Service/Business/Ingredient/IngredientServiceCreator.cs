using System;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Business.Ingredient
{
    internal class IngredientServiceCreator : IIngredientCreator
    {
        private readonly IIngredientRepository ingredientRepository;

        public IngredientServiceCreator(IIngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository ?? throw new ArgumentNullException(nameof(ingredientRepository));
        }

        public IIngredientService Create()
        {
            return new IngredientService(ingredientRepository);
        }
    }
}
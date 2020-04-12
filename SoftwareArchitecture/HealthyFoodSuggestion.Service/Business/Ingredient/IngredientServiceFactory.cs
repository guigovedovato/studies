using System;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Business.Ingredient
{
    internal class IngredientServiceFactory : IIngredientFactory
    {
        private readonly IIngredientRepository ingredientRepository;

        public IngredientServiceFactory(IIngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository ?? throw new ArgumentNullException(nameof(ingredientRepository));
        }

        public IIngredientService Create()
        {
            return new IngredientService(ingredientRepository);
        }
    }
}
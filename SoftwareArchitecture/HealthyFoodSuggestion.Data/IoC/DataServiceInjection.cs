using HealthyFoodSuggestion.Data.Domain;
using HealthyFoodSuggestion.Data.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace HealthyFoodSuggestion.Data.IoC
{
    public static class DataServiceInjection
    {
        public static IServiceCollection DataRegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IIngredientRepository, IngredientRepository>();
            services.AddSingleton<IRecipeRepository, RecipeRepository>();
            return services;
        }
    }
}
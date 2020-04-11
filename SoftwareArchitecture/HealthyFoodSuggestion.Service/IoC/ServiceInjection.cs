using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Data.Domain;
using HealthyFoodSuggestion.Service.Business.Ingredient;
using HealthyFoodSuggestion.Service.Business.Recipe;
using HealthyFoodSuggestion.Service.Command;
using HealthyFoodSuggestion.Service.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace HealthyFoodSuggestion.Service.IoC
{
    public static class ServiceInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IIngredientRepository, IngredientRepository>();
            services.AddSingleton<IRecipeRepository, RecipeRepository>();
            services.AddScoped<ISuggestion, Suggestion>();
            services.AddScoped<IRecipeCreator, RecipeServiceCreator>();
            services.AddScoped<IIngredientCreator, IngredientServiceCreator>();
            return services;
        }
    }
}
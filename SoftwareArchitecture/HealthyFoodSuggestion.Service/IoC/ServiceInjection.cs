using HealthyFoodSuggestion.Data.IoC;
using HealthyFoodSuggestion.Service.Business.Ingredient;
using HealthyFoodSuggestion.Service.Business.Recipe;
using HealthyFoodSuggestion.Service.Domain;
using HealthyFoodSuggestion.Service.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace HealthyFoodSuggestion.Service.IoC
{
    public static class ServiceInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ISuggestion, Suggestion>();
            services.AddScoped<IRecipeFactory, RecipeServiceFactory>();
            services.AddScoped<IIngredientFactory, IngredientServiceFactory>();
            services.DataRegisterServices();
            return services;
        }
    }
}
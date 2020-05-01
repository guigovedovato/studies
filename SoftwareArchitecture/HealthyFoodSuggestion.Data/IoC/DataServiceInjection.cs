using System;
using AutoMapper;
using HealthyFoodSuggestion.Data.Domain;
using HealthyFoodSuggestion.Data.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace HealthyFoodSuggestion.Data.IoC
{
    public static class DataServiceInjection
    {
        public static IServiceCollection DataRegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            return services;
        }
    }
}
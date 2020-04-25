using AutoMapper;
using HealthyFoodSuggestion.Domain.Dto;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.API.Profiles
{
    public class RecipesProfile : Profile
    {
        public RecipesProfile()
        {
            CreateMap<Recipe, RecipeDto>();
        }
    }
}
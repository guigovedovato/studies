using AutoMapper;
using HealthyFoodSuggestion.Domain.Dto;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.API.Profiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<Ingredient, IngredientDto>();
        }
    }
}
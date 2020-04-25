using AutoMapper;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.Data.Profiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<Model.Ingredient, Ingredient>();
            CreateMap<Ingredient, Model.Ingredient>();
        }
    }
}
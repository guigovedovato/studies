using AutoMapper;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.Data.Profiles
{
    public class RecipesProfile : Profile
    {
        public RecipesProfile()
        {
            CreateMap<Model.Recipe, Recipe>();
            CreateMap<Recipe, Model.Recipe>();
        }
    }
}
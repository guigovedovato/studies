using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Service.Extensions
{
    public static class RecipeTypeExtension
    {
        public static RecipeType MapToModel(this byte type)
        {
            return (RecipeType)type;
        }
    }
}
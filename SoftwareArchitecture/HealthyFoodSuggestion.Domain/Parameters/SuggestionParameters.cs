using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Domain.Parameters
{
    public class SuggestionParameters
    {
        public RecipeType Type { get; set; }
        public string Ingredient { get; set; }
    }
}
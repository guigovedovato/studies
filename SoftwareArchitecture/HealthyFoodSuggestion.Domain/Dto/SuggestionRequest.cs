using System.ComponentModel.DataAnnotations;
using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Domain.Dto
{
    public class SuggestionRequest
    {
        [Required]
        public RecipeType Type { get; set; }
        [Required]
        public string Ingredient { get; set; }
    }
}
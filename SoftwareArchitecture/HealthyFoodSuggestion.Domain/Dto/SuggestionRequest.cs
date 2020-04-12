using System.ComponentModel.DataAnnotations;

namespace HealthyFoodSuggestion.Domain.Dto
{
    public class SuggestionRequest
    {
        [Required]
        public byte Type { get; set; }
        [Required]
        public string ingredient { get; set; }
    }
}
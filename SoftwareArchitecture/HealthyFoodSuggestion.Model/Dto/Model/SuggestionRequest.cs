using System.ComponentModel.DataAnnotations;

namespace HealthyFoodSuggestion.Model.Dto.Model
{
    public class SuggestionRequest
    {
        [Required]
        public byte Type { get; set; }
        [Required]
        public string ingredient { get; set; }
    }
}
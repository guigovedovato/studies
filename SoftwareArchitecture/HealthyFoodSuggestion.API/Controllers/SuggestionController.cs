using HealthyFoodSuggestion.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodSuggestion.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class SuggestionController : ControllerBase
    {
        private readonly ISuggestion suggestion;

        public SuggestionController(ISuggestion suggestion)
        {
            this.suggestion = suggestion ?? throw new System.ArgumentNullException(nameof(suggestion));
        }

        [HttpGet("{type}/{ingredient}")]
        public IActionResult Get(byte type, string ingredient)
        {
            return Ok(this.suggestion.RetrieveSuggestions(ingredient, type));
        }
    }
}
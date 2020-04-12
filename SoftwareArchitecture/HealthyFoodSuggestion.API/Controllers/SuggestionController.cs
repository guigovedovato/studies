using System.Threading.Tasks;
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
        public async Task<IActionResult> GetAsync(byte type, string ingredient)
        {
            return Ok(await this.suggestion.RetrieveSuggestionsAsync(ingredient, type));
        }
    }
}
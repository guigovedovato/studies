using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Enum;
using HealthyFoodSuggestion.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodSuggestion.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuggestionController : ControllerBase
    {
        private readonly ISuggestion suggestion;

        public SuggestionController(ISuggestion suggestion) 
            => this.suggestion = 
                suggestion ?? 
                throw new System.ArgumentNullException(nameof(suggestion));

        [HttpGet("v1/{type}/{ingredient}")]
        public async Task<IActionResult> GetAsync(RecipeType type, string ingredient)
        {
            if(type == RecipeType.Unknown || string.IsNullOrWhiteSpace(ingredient))
            {
                return BadRequest();
            }

            var response = await this.suggestion.RetrieveSuggestionsAsync(ingredient, type);

            if (response is null)
            {
                return NotFound();
            }

            return Ok(response);
        }
    }
}
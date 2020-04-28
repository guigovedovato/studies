using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HealthyFoodSuggestion.Domain.Dto;
using HealthyFoodSuggestion.Domain.Enum;
using HealthyFoodSuggestion.Domain.Parameters;
using HealthyFoodSuggestion.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodSuggestion.API.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class SuggestionsController : ControllerBase
    {
        private readonly ISuggestion suggestion;
        private readonly IMapper mapper;

        public SuggestionsController(ISuggestion suggestion, IMapper mapper) 
        {
            this.suggestion = suggestion ?? 
                throw new ArgumentNullException(nameof(suggestion));
            this.mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [HttpHead]
        public async Task<ActionResult<IEnumerable<RecipeDto>>> GetAsync(
            [FromQuery] SuggestionParameters suggestionParameters)
        {
            if (suggestionParameters?.Type == RecipeType.Unknown)
            {
                return BadRequest();
            }

            var suggestionsFromRepo = await this.suggestion.GetAllAsync(suggestionParameters);

            if (suggestionsFromRepo is null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<IEnumerable<RecipeDto>>(suggestionsFromRepo));
        }

        [HttpOptions]
        public IActionResult GetOptions()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS");
            return Ok();
        }
    }
}
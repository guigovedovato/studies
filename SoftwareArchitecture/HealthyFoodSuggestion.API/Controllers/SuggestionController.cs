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
    [Route("api/suggestions")]
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

        [HttpGet("v1")]
        [HttpHead("v1")]
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
    }
}
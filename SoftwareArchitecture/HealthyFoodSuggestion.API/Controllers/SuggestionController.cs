using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using HealthyFoodSuggestion.Domain.Dto;
using HealthyFoodSuggestion.Domain.Enum;
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
        public async Task<ActionResult> GetAsync()
        {
            var suggestionsFromRepo = await this.suggestion.GetAllAsync();

            return Ok(mapper.Map<IEnumerable<RecipeDto>>(suggestionsFromRepo));
        }

        [HttpGet("v1/{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            if (id.Equals(Guid.Empty))
            {
                return BadRequest();
            }

            var suggestionFromRepo = await this.suggestion.GetByIdAsync(id);

            if (suggestionFromRepo is null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RecipeDto>(suggestionFromRepo));
        }
    }
}
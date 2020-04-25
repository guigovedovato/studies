using System;
using System.Collections.Generic;

namespace HealthyFoodSuggestion.Domain.Dto
{
    public class RecipeDto
    {
        public Guid Id { get; set; }
        public IEnumerable<IngredientDto> Ingredients { get; set; }  
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
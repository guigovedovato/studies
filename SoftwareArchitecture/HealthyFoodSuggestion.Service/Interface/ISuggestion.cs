using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;
using HealthyFoodSuggestion.Domain.Parameters;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface ISuggestion
    {
        Task<IEnumerable<Recipe>> GetAllAsync(SuggestionParameters suggestionParameters);
    }
}
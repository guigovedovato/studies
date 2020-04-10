using System.Collections.Generic;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Model.Enum;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface ISuggestion
    {
         IEnumerable<Recipe> RetrieveSuggestions(string ingredient, byte type);
    }
}
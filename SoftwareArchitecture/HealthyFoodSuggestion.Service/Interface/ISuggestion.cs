using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface ISuggestion
    {
        Task<IEnumerable<Recipe>> GetAllAsync();
         
        Task<Recipe> GetByIdAsync(Guid id);
    }
}
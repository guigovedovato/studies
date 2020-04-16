using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface IIngredientService
    {
         Task<Ingredient> GetIngredientAsync(string name);
    }
}
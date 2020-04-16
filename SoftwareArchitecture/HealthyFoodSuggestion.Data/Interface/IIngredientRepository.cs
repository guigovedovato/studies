using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.Data.Interface
{
    public interface IIngredientRepository
    {
         Task<Ingredient> GetIngredientAsync(string name);
    }
}
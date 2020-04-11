using System.Threading.Tasks;
using HealthyFoodSuggestion.Model.Business;

namespace HealthyFoodSuggestion.Data.Interface
{
    public interface IIngredientRepository
    {
         Task<Ingredient> GetIngredientAsync(string name);
    }
}
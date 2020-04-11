using System.Threading.Tasks;
using HealthyFoodSuggestion.Model.Business;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface IIngredientService
    {
         Task<Ingredient> GetIngredientAsync(string name);
    }
}
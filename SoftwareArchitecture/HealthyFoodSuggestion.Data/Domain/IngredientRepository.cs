using System.Linq;
using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Data.Model;
using HealthyFoodSuggestion.Domain.Enum;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Data.Mapper;

namespace HealthyFoodSuggestion.Data.Domain
{
    internal class IngredientRepository : IIngredientRepository
    {
        private readonly IEnumerable<Ingredient> ingredients;

        public IngredientRepository()
        {
            this.ingredients = new List<Ingredient>
            {
                new Ingredient { Id = 1, Name = "beterraba", Group = (byte)FoodGroup.Vegetables },
                new Ingredient { Id = 1, Name = "manteiga", Group = (byte)FoodGroup.Dairy },
                new Ingredient { Id = 1, Name = "banana", Group = (byte)FoodGroup.Fruit },
                new Ingredient { Id = 1, Name = "feijão", Group = (byte)FoodGroup.Grain },
                new Ingredient { Id = 1, Name = "peito de frango", Group = (byte)FoodGroup.Meat },
                new Ingredient { Id = 1, Name = "camarão", Group = (byte)FoodGroup.Seafood }
            };
        }

        public async Task<HealthyFoodSuggestion.Domain.Model.Ingredient> GetIngredientAsync(string name)
        {
            return this.ingredients.FirstOrDefault(i => i.Name.Equals(name)).ToDomain();
        }
    }
}
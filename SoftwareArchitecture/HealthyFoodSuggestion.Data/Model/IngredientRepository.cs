using System.Linq;
using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Model.Enum;

namespace HealthyFoodSuggestion.Data.Model
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly IEnumerable<Ingredient> ingredients;

        public IngredientRepository()
        {
            this.ingredients = new List<Ingredient>
            {
                new Ingredient { Id = 1, Name = "beterraba", Group = FoodGroup.Vegetables },
                new Ingredient { Id = 1, Name = "manteiga", Group = FoodGroup.Dairy },
                new Ingredient { Id = 1, Name = "banana", Group = FoodGroup.Fruit },
                new Ingredient { Id = 1, Name = "feijão", Group = FoodGroup.Grain },
                new Ingredient { Id = 1, Name = "peito de frango", Group = FoodGroup.Meat },
                new Ingredient { Id = 1, Name = "camarão", Group = FoodGroup.Seafood }
            };
        }

        public Ingredient GetIngredient(string name)
        {
            return this.ingredients.FirstOrDefault(i => i.Name.Equals(name));
        }
    }
}
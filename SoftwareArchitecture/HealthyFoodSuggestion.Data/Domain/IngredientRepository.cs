using System.Linq;
using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Data.Model;
using HealthyFoodSuggestion.Domain.Enum;
using System.Threading.Tasks;
using System;
using AutoMapper;

namespace HealthyFoodSuggestion.Data.Domain
{
    internal class IngredientRepository : IIngredientRepository
    {
        private readonly IEnumerable<Ingredient> ingredients;
        private readonly IMapper mapper;

        public IngredientRepository(IMapper mapper)
        {
            ingredients = new List<Ingredient>
                {
                    new Ingredient { Id = Guid.Parse("505eb5c9-52e2-4d8a-a05c-cdf0e8ebf158"), Name = "beterraba", Group = FoodGroup.Vegetables },
                    new Ingredient { Id = Guid.NewGuid(), Name = "manteiga", Group = FoodGroup.Dairy },
                    new Ingredient { Id = Guid.NewGuid(), Name = "banana", Group = FoodGroup.Fruit },
                    new Ingredient { Id = Guid.NewGuid(), Name = "feijão", Group = FoodGroup.Grain },
                    new Ingredient { Id = Guid.NewGuid(), Name = "peito de frango", Group = FoodGroup.Meat },
                    new Ingredient { Id = Guid.NewGuid(), Name = "camarão", Group = FoodGroup.Seafood }
                };

            this.mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<HealthyFoodSuggestion.Domain.Model.Ingredient> GetIngredientAsync(string name) 
            => await Task.FromResult(this.mapper.Map<HealthyFoodSuggestion.Domain.Model.Ingredient>(this.ingredients
                    .SingleOrDefault(i => i.Name.ToLower().Equals(name))));
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Data.Model;
using HealthyFoodSuggestion.Domain.Enum;
using System.Threading.Tasks;
using AutoMapper;

namespace HealthyFoodSuggestion.Data.Domain
{
    internal class RecipeRepository : IRecipeRepository
    {
        private readonly IEnumerable<Recipe> recipes;
        private readonly IMapper mapper;

        public RecipeRepository(IMapper mapper)
        {
            recipes = new List<Recipe>
                {
                    new Recipe
                    {
                        Id = Guid.NewGuid(),
                        Type = RecipeType.Vegetarian,
                        Description = "Bla Bla Bla",
                        Ingredients = new List<Ingredient>
                        {
                            new Ingredient
                            {
                                Id = Guid.Parse("505eb5c9-52e2-4d8a-a05c-cdf0e8ebf158"),
                                Name = "beterraba",
                                Group = FoodGroup.Vegetables
                            }
                        }
                    },
                    new Recipe
                    {
                        Id = Guid.NewGuid(),
                        Type = RecipeType.Vegetarian,
                        Description = "Bla Bla Bla",
                        Ingredients = new List<Ingredient>
                        {
                            new Ingredient
                            {
                                Id = Guid.NewGuid(),
                                Name = "berinjela",
                                Group = FoodGroup.Vegetables
                            }
                        }
                    },
                    new Recipe
                    {
                        Id = Guid.NewGuid(),
                        Type = RecipeType.Vegan,
                        Description = "Bla Bla Bla",
                        Ingredients = new List<Ingredient>
                        {
                            new Ingredient
                            {
                                Id = Guid.NewGuid(),
                                Name = "Nabo",
                                Group = FoodGroup.Vegetables
                            }
                        }
                    }
                };

            this.mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<HealthyFoodSuggestion.Domain.Model.Recipe>> RetrieveRecipesAsync(RecipeType type, HealthyFoodSuggestion.Domain.Model.Ingredient ingredient) 
        {
            var query = this.recipes.AsQueryable();

            if (!type.Equals(RecipeType.Unknown))
            {
                query = query.Where(r => r.Type == type);
            }
            
            if (!(ingredient is null))
            {
                query = query.Where(r => r.Ingredients.Any(i => ingredient.Id.ToString() == i.Id.ToString()));
            }

            return await Task.FromResult(
                this.mapper.Map<IEnumerable<HealthyFoodSuggestion.Domain.Model.Recipe>>(query.ToList()));
        }
    }
}
namespace HealthyFoodSuggestion.Data.Mapper
{
    public static class IngredientExtension
    {
        public static HealthyFoodSuggestion.Domain.Model.Ingredient ToDomain(this Model.Ingredient data) 
            => new HealthyFoodSuggestion.Domain.Model.Ingredient
                {
                    Name = data.Name,
                    Id = data.Id,
                    Group = data.Group
                };

        public static Model.Ingredient ToData(HealthyFoodSuggestion.Domain.Model.Ingredient domain) 
            => new Model.Ingredient
                {
                    Name = domain.Name,
                    Id = domain.Id,
                    Group = domain.Group
                };
    }
}
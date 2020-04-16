namespace HealthyFoodSuggestion.Data.Mapper
{
    public static class IngredientExtension
    {
        public static HealthyFoodSuggestion.Domain.Model.Ingredient ToDomain(this Model.Ingredient data)
        {
            return new HealthyFoodSuggestion.Domain.Model.Ingredient
            {
                Name = data.Name,
                Id = data.Id,
                Group = (HealthyFoodSuggestion.Domain.Enum.FoodGroup)data.Group
            };
        }

        public static Model.Ingredient ToData(HealthyFoodSuggestion.Domain.Model.Ingredient domain)
        {
            return new Model.Ingredient
            {
                Name = domain.Name,
                Id = domain.Id,
                Group = (byte)domain.Group
            };
        }
    }
}
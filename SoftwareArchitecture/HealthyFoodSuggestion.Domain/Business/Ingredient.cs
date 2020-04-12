using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Domain.Business
{
    public class Ingredient
    {
        public int Id { get; set; }
        public FoodGroup Group { get; set; }
        public string Name { get; set; }
    }
}
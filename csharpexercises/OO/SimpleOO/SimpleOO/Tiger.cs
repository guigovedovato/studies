using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleOO
{
    public class Tiger : Mammal, ICarnivore
    {
        private List<IAnimal> Foods;

        public Tiger() : base(typeof(Tiger).Name)
        {
            FoodType = FOODTYPE.Carnivore;
            Foods = new List<IAnimal>();
        }

        public void Diet(IAnimal food)
        {
            if (!Foods.Any(x => x == food))
                Foods.Add(food);
        }

        public override void Eat()
        {
            if (Foods.Count > 0)
                Console.WriteLine($"The { Name } is eating { Hunt(Foods) }");
            else
                Console.WriteLine($"The { Name } is not hungry!");
        }

        public IAnimal Hunt(List<IAnimal> targets)
        {
            Console.WriteLine($"The { Name } is hanting...");
            var target = targets.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            Console.WriteLine($"The { Name } caught a { target }");
            Diet(target);
            return target;
        }
    }
}

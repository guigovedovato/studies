using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleOO
{
    public class Kangaroo : Mammal
    {
        private List<HERBIVOREFOOD> Foods;

        public Kangaroo() : base(typeof(Kangaroo).Name)
        {
            FoodType = FOODTYPE.Herbivore;
            Foods = new List<HERBIVOREFOOD>();
        }

        public void Diet(HERBIVOREFOOD food)
        {
            Foods.Add(food);
        }

        public override void Eat()
        {
            if (Foods.Count > 0)
                Console.WriteLine($"The { Name } is eating { Foods.OrderBy(x => Guid.NewGuid()).FirstOrDefault() }");
            else
                Console.WriteLine($"The { Name } is not hungry!");
        }

        public override void Walk()
        {
            Console.WriteLine($"The { Name } is jumping.");
        }
    }
}

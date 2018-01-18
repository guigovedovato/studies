using System;

namespace SimpleOO
{
    public abstract class Mammal : IAnimal
    {
        protected string Name { get; set; }
        protected FOODTYPE FoodType { get; set; }

        protected Mammal(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public abstract void Eat();

        public virtual void Walk()
        {
            Console.WriteLine($"The Mammal Animal { Name } is walking.");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

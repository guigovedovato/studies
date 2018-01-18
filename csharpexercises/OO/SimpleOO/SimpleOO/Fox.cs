using System;
using System.Collections.Generic;

namespace SimpleOO
{
    public class Fox : Mammal, ICarnivore
    {
        public Fox() : base(typeof(Fox).Name)
        {
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public IAnimal Hunt(List<IAnimal> targets)
        {
            throw new NotImplementedException();
        }
    }
}

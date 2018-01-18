using System;

namespace SimpleOO
{
    public class Rabbit : Mammal
    {
        public Rabbit() : base(typeof(Rabbit).Name)
        {
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}

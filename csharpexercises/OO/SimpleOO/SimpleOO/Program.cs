using System;
using System.Collections.Generic;

namespace SimpleOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = new Kangaroo();
            Console.WriteLine($"There is a {k}.");
            k.Eat();
            k.Diet(HERBIVOREFOOD.Fruit);
            k.Diet(HERBIVOREFOOD.Leaf);
            k.Walk();
            k.Eat();

            var t = new Tiger();
            Console.WriteLine($"There is a {t}.");
            t.Eat();
            t.Diet(k);
            t.Eat();
            t.Walk();
            t.Hunt(new List<IAnimal> { new Fox() });
            t.Eat();
            t.Diet(new Rabbit());
            t.Eat();
        }
    }
}

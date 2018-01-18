using System.Collections.Generic;

namespace SimpleOO
{
    interface ICarnivore
    {
        IAnimal Hunt(List<IAnimal> targets);
    }
}

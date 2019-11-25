using System;
using System.Collections.Generic;
using DesignPatterns.Model;

namespace DesignPatterns.Creational.Builder.Functional
{
    public class PersonFunctionalBuilder
    {
        public readonly List<Action<Person>> Actions = new List<Action<Person>>();

        public Person Build()
        {
            Person person = new Person();
            Actions.ForEach(action => action(person));
            return person;
        }
    }
}
using System;
using DesignPatterns.Model;

namespace DesignPatterns.Creational.Builder.Fluent
{
    public class PersonBuilder
    {
        private Person Person;

        public PersonBuilder() => this.Person = new Person();

        public Person Build() => this.Person;

        public PersonBuilder AddName(string name)
        {
            this.Person.Name = name;
            return this;
        }

        public PersonBuilder AddSurname(string surname)
        {
            this.Person.Surname = surname;
            return this;
        }

        public PersonBuilder AddDateOfBirth(DateTime dateOfBirth)
        {
            this.Person.DateOfBirth = dateOfBirth;
            return this;
        }

        public PersonBuilder AddPosition(Model.Enum.Position position)
        {
            this.Person.Position = position;
            return this;
        }
    }
}
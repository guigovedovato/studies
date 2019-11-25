using System;
using DesignPatterns.Model;

namespace DesignPatterns.Creational.Builder.Fluent
{
    public class PersonFluentBuilder
    {
        private Person Person;

        public PersonFluentBuilder() => this.Person = new Person();

        public Person Build() => this.Person;

        public PersonFluentBuilder AddName(string name)
        {
            this.Person.Name = name;
            return this;
        }

        public PersonFluentBuilder AddSurname(string surname)
        {
            this.Person.Surname = surname;
            return this;
        }

        public PersonFluentBuilder AddDateOfBirth(DateTime dateOfBirth)
        {
            this.Person.DateOfBirth = dateOfBirth;
            return this;
        }

        public PersonFluentBuilder AddPosition(Model.Enum.Position position)
        {
            this.Person.Position = position;
            return this;
        }
    }
}
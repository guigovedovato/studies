using System;
using DesignPatterns.Model;

namespace DesignPatterns.Creational.Builder.Faceted
{
    public class PersonFacetedBuilder
    {
        protected Person Person = new Person();

        public PersonFacetedPersonalBuilder Is => new PersonFacetedPersonalBuilder(Person);
        public PersonFacetedAddressBuilder Lives => new PersonFacetedAddressBuilder(Person);
        public PersonFacetedJobBuilder Works => new PersonFacetedJobBuilder(Person);

        public static implicit operator Person(PersonFacetedBuilder personFacetedBuilder)
        {
            return personFacetedBuilder.Person;
        }
    }

    public class PersonFacetedAddressBuilder : PersonFacetedBuilder
    {
        public PersonFacetedAddressBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonFacetedAddressBuilder At(string streetAddress)
        {
            Person.Address.StreetAddress = streetAddress;
            return this;
        }

        public PersonFacetedAddressBuilder WithPostcode(string postcode)
        {
            Person.Address.Postcode = postcode;
            return this;
        }

        public PersonFacetedAddressBuilder In(string city)
        {
            Person.Address.City = city;
            return this;
        }
    }

    public class PersonFacetedJobBuilder : PersonFacetedBuilder
    {
        public PersonFacetedJobBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonFacetedJobBuilder At(string company)
        {
            Person.Job.Company = company;
            return this;
        }

        public PersonFacetedJobBuilder AsA(Model.Enum.Position position)
        {
            Person.Job.Position = position;
            return this;
        }   
    }

    public class PersonFacetedPersonalBuilder : PersonFacetedBuilder
    {
        public PersonFacetedPersonalBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonFacetedPersonalBuilder Called(string name)
        {
            Person.Name = name;
            return this;
        }

        public PersonFacetedPersonalBuilder WithLastName(string surname)
        {
            Person.Surname = surname;
            return this;
        }

        public PersonFacetedPersonalBuilder BirthAt(DateTime dateOfBirth)
        {
            Person.DateOfBirth = dateOfBirth;
            return this;
        }
    }
}
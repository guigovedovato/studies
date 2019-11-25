using System;

namespace DesignPatterns.Creational.Builder.Functional
{
    public static class PersonFunctionalBuilderExtensions
    {
        public static PersonFunctionalBuilder AddName(this PersonFunctionalBuilder builder, string name)
        {
            builder.Actions.Add(person => { person.Name = name; });
            return builder;
        }

        public static PersonFunctionalBuilder AddSurname(this PersonFunctionalBuilder builder, string surname)
        {
            builder.Actions.Add(person => { person.Surname = surname; });
            return builder;
        }

        public static PersonFunctionalBuilder AddDateOfBirth(this PersonFunctionalBuilder builder, DateTime dateOfBirth)
        {
            builder.Actions.Add(person => { person.DateOfBirth = dateOfBirth; });
            return builder;
        }

        public static PersonFunctionalBuilder AddPosition(this PersonFunctionalBuilder builder, Model.Enum.Position position)
        {
            builder.Actions.Add(person => { person.Position = position; });
            return builder;
        }
    }
}
using System;

namespace DesignPatterns.Creational.Builder.Functional
{
    public static class PersonFunctionalDateTimeBuilderExtensions
    {
        public static PersonFunctionalBuilder AddDateOfBirth(this PersonFunctionalBuilder builder, DateTime dateOfBirth)
        {
            builder.Actions.Add(person => { person.DateOfBirth = dateOfBirth; });
            return builder;
        }
    }
}
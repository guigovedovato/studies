namespace DesignPatterns.Creational.Builder.Functional
{
    public static class PersonFunctionalStringBuilderExtensions
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
    }
}
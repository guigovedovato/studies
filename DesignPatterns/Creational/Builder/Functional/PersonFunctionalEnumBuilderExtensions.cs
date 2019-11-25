namespace DesignPatterns.Creational.Builder.Functional
{
    public static class PersonFunctionalEnumBuilderExtensions
    {
        public static PersonFunctionalBuilder AddPosition(this PersonFunctionalBuilder builder, Model.Enum.Position position)
        {
            builder.Actions.Add(person => { person.Position = position; });
            return builder;
        }
    }
}
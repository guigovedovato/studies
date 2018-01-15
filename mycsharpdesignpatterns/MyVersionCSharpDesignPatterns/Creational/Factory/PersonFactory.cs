namespace MyVersionCSharpDesignPatterns.Creational.Factory
{
    public class PersonFactory
    {
        private int id = 0;

        public Person CreatePerson(string name)
        {
            return new Person { Id = id++, Name = name };
        }
    }
}

namespace MyVersionCSharpDesignPatterns.Creational.Factory
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"Id: {Id} - Name: {Name}";
    }
}

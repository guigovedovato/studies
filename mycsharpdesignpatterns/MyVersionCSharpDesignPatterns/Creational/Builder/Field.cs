namespace MyVersionCSharpDesignPatterns.Creational.Builder
{
    public class Field
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"public {Type} {Name}";
    }
}

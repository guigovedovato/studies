namespace MyVersionCSharpDesignPatterns.Structural.Bridge
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer strategy) : base(strategy)
        {
            Name = "Triangle";
        }
    }
}

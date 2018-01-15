namespace MyVersionCSharpDesignPatterns.Structural.Bridge
{
    public class Square : Shape
    {
        public Square(IRenderer rendering) : base(rendering)
        {
            Name = "Square";
        }
    }
}

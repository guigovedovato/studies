namespace MyVersionCSharpDesignPatterns.Behavioral.Visitor
{
    public class Value : Expression
    {
        public readonly int TheValue;

        public Value(int value)
        {
            TheValue = value;
        }

        public override void Visit(ExpressionVisitor ev)
        {
            ev.Accept(this);
        }
    }
}

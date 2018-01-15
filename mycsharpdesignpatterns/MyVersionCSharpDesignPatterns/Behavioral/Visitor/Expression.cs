namespace MyVersionCSharpDesignPatterns.Behavioral.Visitor
{
    public abstract class Expression
    {
        public abstract void Visit(ExpressionVisitor ev);
    }
}

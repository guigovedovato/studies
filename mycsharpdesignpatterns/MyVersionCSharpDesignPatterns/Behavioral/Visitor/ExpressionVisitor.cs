namespace MyVersionCSharpDesignPatterns.Behavioral.Visitor
{
    public abstract class ExpressionVisitor
    {
        public abstract void Accept(Value value);
        public abstract void Accept(AdditionExpression ae);
        public abstract void Accept(MultiplicationExpression me);
    }
}

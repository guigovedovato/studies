namespace MyVersionCSharpDesignPatterns.Behavioral.Visitor
{
    public class AdditionExpression : Expression
    {
        public readonly Expression LHS, RHS;

        public AdditionExpression(Expression lhs, Expression rhs)
        {
            LHS = lhs;
            RHS = rhs;
        }

        public override void Visit(ExpressionVisitor ev)
        {
            ev.Accept(this);
        }
    }
}

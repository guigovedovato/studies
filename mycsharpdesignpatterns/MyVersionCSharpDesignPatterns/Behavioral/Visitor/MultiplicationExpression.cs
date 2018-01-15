namespace MyVersionCSharpDesignPatterns.Behavioral.Visitor
{
    public class MultiplicationExpression : Expression
    {
        public readonly Expression LHS, RHS;

        public MultiplicationExpression(Expression lhs, Expression rhs)
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

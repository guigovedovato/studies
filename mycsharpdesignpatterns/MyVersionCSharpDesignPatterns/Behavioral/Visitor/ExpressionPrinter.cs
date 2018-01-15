using System.Text;

namespace MyVersionCSharpDesignPatterns.Behavioral.Visitor
{
    public class ExpressionPrinter : ExpressionVisitor
    {
        private StringBuilder sb = new StringBuilder();

        public override void Accept(Value value)
        {
            sb.Append(value.TheValue);
        }

        public override void Accept(AdditionExpression ae)
        {
            sb.Append("(");
            ae.LHS.Visit(this);
            sb.Append("+");
            ae.RHS.Visit(this);
            sb.Append(")");
        }

        public override void Accept(MultiplicationExpression me)
        {
            me.LHS.Visit(this);
            sb.Append("*");
            me.RHS.Visit(this);
        }

        public override string ToString()
        {
            return sb.ToString();
        }
    }
}

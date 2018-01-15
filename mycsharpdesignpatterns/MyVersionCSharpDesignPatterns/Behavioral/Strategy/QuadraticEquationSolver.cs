using System;
using System.Numerics;

namespace MyVersionCSharpDesignPatterns.Behavioral.Strategy
{
    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            var disc = new Complex(strategy.CalculateDiscriminant(a, b, c), 0);
            var rootDisc = Complex.Sqrt(disc);
            return Tuple.Create(
              (-b + rootDisc) / (2 * a),
              (-b - rootDisc) / (2 * a)
            );
        }
    }
}

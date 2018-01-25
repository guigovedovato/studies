using System;

namespace FibonacciSerie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fibonacci.CalculateSerie(length));
        }
    }
}

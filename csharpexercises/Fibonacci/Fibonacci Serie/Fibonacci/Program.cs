using System;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {
        /*
         * Fibonacci series is a sequence of numbers in below order:
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34… The next number is found by adding up the two numbers before it.

            The formula for calculating these numbers is:

            F(n) = F(n-1) + F(n-2)

            where:

            F(n) is the term number.
            F(n-1) is the previous term (n-1).
            F(n-2) is the term before that (n-2).

            it starts either with 0 or 1.
        */

        static int FibonacciSeriesIterative(int number)
        {
            int result = 0, firstNumber = 0, secondNumber = 1;

            if ((number == 0) || (number == 1)) return number;

            for (int i = 2; i <= number; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }

        static int FibonacciSeriesRecursive(int number)
        {
            if ((number == 0) || (number == 1)) return number;

            return FibonacciSeriesRecursive(number - 1) + FibonacciSeriesRecursive(number - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeriesIterative(i));
            }
            sw.Stop();
            Console.WriteLine("Fibonacci Iterative: {0}ms", sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            sw.Start();
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeriesRecursive(i));
            }
            sw.Stop();
            Console.WriteLine("Fibonacci Recursive: {0}ms", sw.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}

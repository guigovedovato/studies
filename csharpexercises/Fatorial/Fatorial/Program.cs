using System;
using System.Diagnostics;

namespace Fatorial
{
    class Program
    {
        static int FatorialIterative(int number)
        {
            int result = number;

            if (number == 0) result++;

            while (number > 1)
                result *= --number;

            return result;
        }

        static int FatorialRecursive(int number)
        {
            return number == 0 ? 1 : number * FatorialRecursive(number - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the Fatorial number: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i <= length; i++)
            {
                Console.Write("{0} ", FatorialIterative(i));
            }
            sw.Stop();
            Console.WriteLine("\nFatorial Iterative: {0}ms", sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            sw.Start();
            for (int i = 0; i <= length; i++)
            {
                Console.Write("{0} ", FatorialRecursive(i));
            }
            sw.Stop();
            Console.WriteLine("\nFatorial Recursive: {0}ms", sw.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}

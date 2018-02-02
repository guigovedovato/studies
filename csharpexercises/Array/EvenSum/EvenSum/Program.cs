using System;
using System.Diagnostics;
using System.Linq;

namespace EvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateArray();

            Stopwatch sw = Stopwatch.StartNew();
            int sumFor = SumFor(arr);
            sw.Stop();
            Console.WriteLine($"SumFor: {sumFor}, in: {sw.Elapsed.TotalMilliseconds}ms");
            sw.Reset();
            sw.Start();
            int sumArray = SumArray(arr);
            sw.Stop();
            Console.WriteLine($"SumArray: {sumArray}, in: {sw.Elapsed.TotalMilliseconds}ms");
        }

        private static int SumArray(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).Sum();
        }

        private static int SumFor(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    sum += arr[i];
            }
            return sum;
        }

        private static int[] CreateArray()
        {
            Random r = new Random();

            int[] arr = Enumerable.Range(1, r.Next(5,1000)).OrderBy(i => r.Next()).ToArray();

            return arr;
        }
    }
}

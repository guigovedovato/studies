using System;

namespace SplitArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int[] b;
            Console.WriteLine($"The sum is: {Partition.SplitArray(new int[] { 1, 3, 3, 4, 5 }, out a, out b)}, int[] a = [{string.Join(",", a)}], int[] b = [{string.Join(",", b)}]");
            Console.WriteLine($"The sum is: {Partition.SplitArray(new int[] { 1, 3, 4, 5 }, out a, out b)}, int[] a = [{a}], int[] b = [{b}]");
            Console.WriteLine($"The sum is: {Partition.SplitArray(new int[] { 2, 3, 5 }, out a, out b)}, int[] a = [{string.Join(",", a)}], int[] b = [{string.Join(",", b)}]");
        }
    }
}

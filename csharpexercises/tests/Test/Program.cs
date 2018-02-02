using System;
using System.Linq;

namespace Test
{
    class Program
    {
        public static int find_it(int[] seq)
        {
            Array.Sort(seq);
            int result = 0;
            int count = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                if (result != seq[i])
                {
                    if (count % 2 != 0)
                        break;
                    result = seq[i];
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            return result;
        }

        public static int FindEvenIndex(int[] arr)
        {
            //Code goes here!
            int odd = 0, even = arr.Sum();

            for (int i = 0; i < arr.Length; ++i)
            {
                even -= arr[i];

                if (odd == even)
                {
                    return i;
                }

                odd += arr[i];
            }

            return -1;
        }

        static void Main(string[] args)
        {
            //find_it
            //Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));

            //FindEvenIndex
            //Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            //Console.WriteLine(FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 }));
            //Console.WriteLine(FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 }));
            //Console.WriteLine(FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 }));


        }
    }
}

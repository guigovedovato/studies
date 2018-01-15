using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        /*
         * A palindrome has the same letters on both ends of the string. ex: kayak
        */
        static readonly string[] words = { "civic",
            "deleveled",
            "Hannah",
            "kayak",
            "level",
            "examiron",
            "racecar",
            "radar",
            "refer",
            "reviver",
            "easywcf",
            "rotator",
            "rotor",
            "sagas",
            "solos",
            "stats",
            "tenet",
            "coconut",
            ""
        };

        public static bool PalindromeWhileLoop(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while(true)
            {
                if (min > max) return true;
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b)) return false;
                min++;
                max--;
            }
        }

        public static bool PalindromeReverseWord(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }

        public static bool PalindromeHalfWord(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1]) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome by while loop");
            Stopwatch sw = Stopwatch.StartNew();
            foreach (var item in words)
            {
                Console.WriteLine("{0} = {1}", item, PalindromeWhileLoop(item));
            }
            sw.Stop();
            Console.WriteLine("length: {0}ms", sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.WriteLine("Palindrome by reverse word");
            sw.Start();
            foreach (var item in words)
            {
                Console.WriteLine("{0} = {1}", item, PalindromeReverseWord(item));
            }
            sw.Stop();
            Console.WriteLine("length: {0}ms", sw.Elapsed.TotalMilliseconds);
            sw.Reset();
            Console.WriteLine("Palindrome by half word");
            sw.Start();
            foreach (var item in words)
            {
                Console.WriteLine("{0} = {1}", item, PalindromeHalfWord(item));
            }
            sw.Stop();
            Console.WriteLine("length: {0}ms", sw.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}

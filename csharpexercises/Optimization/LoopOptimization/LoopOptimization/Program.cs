using System;
using System.Text;

namespace LoopOptimization
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 100001;
            var sb = new StringBuilder();
            for (int i = 1; i < length; i++)
            {
                bool div5 = i % 5 == 0;
                bool div7 = i % 7 == 0;
                if (div5 && div7)
                    sb.Append("FiveAndSeven, ");
                else if (div5)
                    sb.Append(i == (length - 1) ? "Five" : "Five, ");
                else if (div7)
                    sb.Append("Seven, ");
                else
                    sb.Append(i + ", ");
            }
            Console.Write(sb.ToString());
            Console.WriteLine();
        }
    }
}

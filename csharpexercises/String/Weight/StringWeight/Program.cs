using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringWeight
{
    //You are provided a string containing a list of positive integers separated by a space(" ") and the list can be empty. 
    //Take each value and calculate the sum of its digits, which we call it's "weight". Then return 
    //the list in ascending order by weight, as a string joined by a space.

    //For example 99 will have "weight" 18, 100 will have "weight"
    //1 so in the ouput 100 will come before 99.

    //Example:

    //"56 65 74 100 99 68 86 180 90" ordered by numbers weights becomes:
    //"100 180 90 56 65 74 68 86 99"

    //100 is before 180 because its "weight" (1) is less than the one of 180 (9)
    //and 180 is before 90 since, having the same "weight" (9) it comes before as a string.
    class Program
    {
        static string CalcWeight(string weights)
        {
            if (string.IsNullOrEmpty(weights) || weights.Length == 1)
                return weights;

            var weight = weights.Split(' ');
            KeyValuePair<int, string>[] sums = new KeyValuePair<int, string>[weight.Length];

            for (int i = 0; i < weight.Length; i++)
            {
                var sum = 0;
                for (int j = 0; j < weight[i].Length; j++)
                {
                    sum += int.Parse(weight[i][j].ToString());
                }
                sums[i] = new KeyValuePair<int, string>(sum, weight[i]);
            }

            var order = sums.OrderBy(x => x.Value);
            var sb = new StringBuilder();

            foreach (var item in order.OrderBy(x => x.Key))
            {
                sb.Append(item.Value);
                sb.Append(" ");
            }

            sb.Length--;
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            //"100 180 90 56 65 74 68 86 99"
            Console.WriteLine(CalcWeight("56 65 74 100 99 68 86 180 90"));

            //"11 11 2000 22 147000 444444 9999"
            Console.WriteLine(CalcWeight("2000 147000 444444 11 22 9999 11"));

            //""
            Console.WriteLine(CalcWeight(""));

            //" "
            Console.WriteLine(CalcWeight(" "));
        }
    }
}

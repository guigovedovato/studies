using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSVSort
{
    //myjinxin2015; raulbc777;  smile67;    Dentzil;    SteffenVogel_79\n
    //17945;        10091;      10088;      3907;       10132\n
    //2;            12;         13;         48;         11
    class Program
    {
        static KeyValuePair<int, int>[] GetOrder(string[] disorder)
        {
            string[] arrange = new string[disorder.Length];
            Array.Copy(disorder, arrange, disorder.Length);
            Array.Sort(arrange, StringComparer.OrdinalIgnoreCase);
            var result = new KeyValuePair<int, int>[disorder.Length];

            for (int i = 0; i < disorder.Length; i++)
            {
                for (int j = 0; j < arrange.Length; j++)
                {
                    if (!disorder[i].Equals(arrange[j]))
                        continue;
                    result[i] = new KeyValuePair<int, int>(j, i);
                }
            }

            return result;
        }

        static string[] SetOrder(string[] toOrder, KeyValuePair<int, int>[] order)
        {
            var result = new string[toOrder.Length];
            for (int i = 0; i < toOrder.Length; i++)
            {
                result[i] = toOrder[order.FirstOrDefault(o => o.Key == i).Value];
            }
            return result;
        }

        static string CSVSort(string original)
        {
            var parts = original.Split("\n");
            var order = GetOrder(parts[0].Split(';'));

            var sb = new StringBuilder();
            for (int i = 0; i < parts.Length; i++)
            {
                sb.Append(String.Join(';', SetOrder(parts[i].Split(';'), order)));
                sb.Append("\n");
            }

            sb.Length--;
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CSVSort("myjinxin2015;raulbc777;smile67;Dentzil;SteffenVogel_79\n"+
                                      "17945;10091;10088;3907;10132\n"+
                                      "2;12;13;48;11"));
        }
    }
}

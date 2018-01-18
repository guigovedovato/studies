using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(int n, int[] ar)
        {
            // Complete this function
            var qtd = new Dictionary<int, int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (!qtd.ContainsKey(ar[i]))
                    qtd.Add(ar[i], 1);
                else
                    qtd[ar[i]]++;
            }
            var max = qtd.Where(i => qtd.Any(t => t.Key != i.Key && t.Value == i.Value)).ToDictionary(i => i.Key, i => i.Value);
            if(max.Count > 0)
            {
                if (max.Values.Max() == qtd.Values.Max())
                {
                    var result = max.Where(x => x.Value == qtd.Values.Max()).ToDictionary(i => i.Key, i => i.Value);
                    return result.Keys.Min();
                }
                else
                {
                    return qtd.FirstOrDefault(x => x.Value == qtd.Values.Max()).Key;
                }
            }
            else
            {
                return qtd.FirstOrDefault(x => x.Value == qtd.Values.Max()).Key;
            }
        }

        static void Main(string[] args)
        {
            int result = migratoryBirds(6, new int[] { 2, 4, 3, 2, 3, 1, 2, 1, 3, 3 });
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

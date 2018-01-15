using System;
using System.Collections.Generic;
using System.Linq;
using LINQSort.Model;
using System.Diagnostics;

namespace LINQSort
{
    class Program
    {
        /*
         * Sort the list according to surname value
         * 
         * Output:
         * Bueno
         * Lemos
         * Marques
         * Passos
         * Vedovato
        */
        static List<Customer> CreateCustomerList()
        {
            return new List<Customer> { new Customer() { Name = "Rodrigo", Surname = "Vedovato" },
                                        new Customer() { Name = "Gabriel", Surname = "Lemos" },
                                        new Customer() { Name = "Vanessa", Surname = "Passos" },
                                        new Customer() { Name = "Giovana", Surname = "Marques" },
                                        new Customer() { Name = "Alberto", Surname = "Bueno" } };
        }

        static void Main(string[] args)
        {
            List<Customer> customers = CreateCustomerList();

            //LINQ.OrderBy
            Console.WriteLine("List sort by GroupBy clause");
            Stopwatch sw = Stopwatch.StartNew();
            var listSorted = customers.OrderBy(item => item.Surname).ToList();
            sw.Stop();
            Console.WriteLine("List sorted: {0}ms", sw.Elapsed.TotalMilliseconds);
            foreach (var item in listSorted)
            {
                Console.WriteLine(item.Surname);
            }

            Console.WriteLine("");
            sw.Reset();

            //LINQ.Sort
            Console.WriteLine("List sort by Sort clause");
            sw.Start();
            customers.Sort((x, y) => String.Compare(x.Surname, y.Surname));
            sw.Stop();
            Console.WriteLine("List sorted: {0}ms", sw.Elapsed.TotalMilliseconds);
            foreach (var item in customers)
            {
                Console.WriteLine(item.Surname);
            }

            Console.ReadLine();
        }
    }
}

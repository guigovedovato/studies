using System;

namespace DataString
{
    class Program
    {
        static String text;
        static DateTime date;

        static void Main(string[] args)
        {
            Console.WriteLine(text == null ? "string is null" : text);
            Console.WriteLine(date == null ? "date is null" : date.ToString());
        }
    }
}

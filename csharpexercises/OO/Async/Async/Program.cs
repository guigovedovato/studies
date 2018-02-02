using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static string address;

        static void Main(string[] args)
        {
            doSomething();
            Console.WriteLine(address);
        }

        private static async Task<string> doSomething()
        {
            await Task.Delay(5);
            //Thread.Sleep(5);
            address = "address";
            return "something";
        }
    }
}

using Xunit;
using FibonacciSerie;

namespace UnitTest
{
    public class FibonacciTest
    {
        [Fact]
        public void Test_0()
        {
            var fb = new Fibonacci(0);
            fb.CalculateSerie();

            string expected = "0";

            Assert.Equal(expected, fb.ToString());
        }

        [Fact]
        public void Test_1()
        {
            var fb = new Fibonacci(1);
            fb.CalculateSerie();

            string expected = "0";

            Assert.Equal(expected, fb.ToString());
        }

        [Fact]
        public void Test_2()
        {
            var fb = new Fibonacci(2);
            fb.CalculateSerie();

            string expected = "0 1";

            Assert.Equal(expected, fb.ToString());
        }

        [Fact]
        public void Test_9()
        {
            var fb = new Fibonacci(9);
            fb.CalculateSerie();

            string expected = "0 1 1 2 3 5 8 13 21";

            Assert.Equal(expected, fb.ToString());
        }

        [Fact]
        public void Test_16()
        {
            var fb = new Fibonacci(16);
            fb.CalculateSerie();

            string expected = "0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610";

            Assert.Equal(expected, fb.ToString());
        }
    }
}

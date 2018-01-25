using Xunit;
using FibonacciSerie;

namespace UnitTest
{
    public class FibonacciTest
    {
        [Fact]
        public void Test_0()
        {
            string expected = "0";

            Assert.Equal(expected, Fibonacci.CalculateSerie(0).ToString());
        }

        [Fact]
        public void Test_1()
        {
            string expected = "0";

            Assert.Equal(expected, Fibonacci.CalculateSerie(1).ToString());
        }

        [Fact]
        public void Test_2()
        {
            string expected = "0 1";

            Assert.Equal(expected, Fibonacci.CalculateSerie(2).ToString());
        }

        [Fact]
        public void Test_9()
        {
            string expected = "0 1 1 2 3 5 8 13 21";

            Assert.Equal(expected, Fibonacci.CalculateSerie(9).ToString());
        }

        [Fact]
        public void Test_16()
        {
            string expected = "0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610";

            Assert.Equal(expected, Fibonacci.CalculateSerie(16).ToString());
        }
    }
}

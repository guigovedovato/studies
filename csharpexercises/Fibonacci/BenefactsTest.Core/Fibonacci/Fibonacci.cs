using System.Text;

namespace FibonacciSerie
{
    public class Fibonacci
    {
        private readonly int _serie;
        private string _sequence;

        public Fibonacci(int number)
        {
            _serie = number;
        }

        public void CalculateSerie()
        {
            if ((_serie == 0) || (_serie == 1))
            {
                _sequence = "0";
                return;
            }

            var sb = new StringBuilder();

            for (int i = 0; i < _serie; i++)
            {
                sb.Append(FibonacciSeries(i));
                sb.Append(" ");
            }

            sb.Length--;
            _sequence = sb.ToString();
        }

        private int FibonacciSeries(int num)
        {
            return ((num == 0) || (num == 1)) ? num : 
                FibonacciSeries(num - 1) + FibonacciSeries(num - 2);
        }

        public override string ToString()
        {
            return _sequence;
        }
    }
}

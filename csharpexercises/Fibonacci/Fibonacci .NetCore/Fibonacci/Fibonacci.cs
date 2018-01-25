using System.Text;

namespace FibonacciSerie
{
    public class Fibonacci
    {
        public static string CalculateSerie(int serie)
        {
            if ((serie == 0) || (serie == 1)) return "0";

            var sb = new StringBuilder();

            for (int i = 0; i < serie; i++)
            {
                sb.Append(FibonacciSeries(i));
                sb.Append(" ");
            }

            sb.Length--;
            return sb.ToString();
        }

        private static int FibonacciSeries(int num)
        {
            return ((num == 0) || (num == 1)) ? num : 
                FibonacciSeries(num - 1) + FibonacciSeries(num - 2);
        }
    }
}

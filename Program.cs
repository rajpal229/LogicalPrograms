namespace LogicalProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("1. FibonacciSeries");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.CheckFibonacciNumber();
                        break;
                }
            }
        }
    }
}
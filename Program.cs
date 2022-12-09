namespace LogicalProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("1. FibonacciSeries\n2. PerfectNumber\n3. Prime Number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.CheckFibonacciNumber();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.CheckPerfectNumber();
                        break;
                    case 3:
                        PrimeNumber primenumber = new PrimeNumber();
                        primenumber.primeNumber();
                        break;
                    default:
                        Console.WriteLine("Enter Valid Input");
                        break;
                }
            }
        }
    }
}
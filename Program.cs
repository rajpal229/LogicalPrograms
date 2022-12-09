namespace LogicalProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool Flag = true;
            while (Flag)
            {
                Console.WriteLine("1. FibonacciSeries\n2. PerfectNumber\n3. Prime Number" +
                    "\n4. Reverse A Number\n5. Coupon Numbers");
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
                    case 4:
                        Reverse_A_Number reverse_A_Number = new Reverse_A_Number();
                        reverse_A_Number.reverse();
                        break;
                    case 5:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        couponNumbers.GenerateCoupon(10);
                        break;
                    default:
                        Console.WriteLine("Enter Valid Input");
                        break;
                }
            }
        }
    }
}
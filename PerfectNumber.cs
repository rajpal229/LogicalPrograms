using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PerfectNumber
    {
        public void CheckPerfectNumber()
        {
            int n, i, sum;

            Console.WriteLine("\n\n");
            Console.WriteLine("Check whether a given number is perfect number or not:\n");
            Console.WriteLine("\n\n");

            Console.WriteLine("Input the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.WriteLine("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}  ", i);
                }
            }
            Console.WriteLine("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.WriteLine("\nSo, the number is perfect.");
            else
                Console.WriteLine("\nSo, the number is not perfect.");
            Console.WriteLine("\n");
        }
    }
}

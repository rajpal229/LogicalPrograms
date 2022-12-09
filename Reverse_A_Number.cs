using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Reverse_A_Number
    {
        public void reverse()
        {
            int num, reverse = 0, reminder;

            Console.Write("Enter a number: ");

            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10;
            }
            Console.WriteLine(reverse);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class CouponNumbers
    {
        public static int GenerateRandom()
        {
            Random random = new Random();
            int randomNum = random.Next(0, 11);
            return randomNum;
        }
        public void GenerateCoupon(int num)
        {
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                int random = GenerateRandom();
                for (int j = 0; j < num; j++)
                {
                    if (arr[j] == random)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    arr[i] = random;
                }
            }
            Console.WriteLine("The coupon Numbers are ");
            foreach (var data in arr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}

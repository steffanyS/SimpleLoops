using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която въвежда 2*n цели числа
            // и проверява дали сумата на първите n числа (лява сума) е равна
            // на сумата на вторите n числа (дясна сума). При равенство печата
            //"Yes" + сумата; иначе печата "No" + разликата. 
            // Разликата се изчислява като положително число (по абсолютна стойност). 

            int leftSum = 0;
            int rightSum = 0;

            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n*2; i++)
            {
                if(i<n)
                {
                    leftSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    rightSum += int.Parse(Console.ReadLine());
                }
            }

            if(leftSum==rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}

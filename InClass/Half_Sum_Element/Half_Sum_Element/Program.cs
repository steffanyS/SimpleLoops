using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers= new int[n];

            int maxNum = numbers[0];
            int sum = 0;

            for (int i=0; i<n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            for(int i=0; i<n; i++)
            {
                if(numbers[i]>maxNum)
                {
                    maxNum = numbers[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if(numbers[i]!=maxNum)
                {
                    sum += numbers[i];
                }
                if(n==2 && numbers[0]==numbers[1])
                {
                    sum=maxNum;
                }
            }

            if(sum==maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxNum-sum));
            }
        }
    }
}

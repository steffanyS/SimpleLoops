using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numbers;
            int maxNum=int.Parse(Console.ReadLine());
            int num = 0;

            for(int i=0; i<n-1; i++)
            {
                num = int.Parse(Console.ReadLine());
                if(num>maxNum)
                {
                    maxNum = num;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}

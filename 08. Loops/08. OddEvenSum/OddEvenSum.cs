using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;
            int oddNum;
            int evenNum;

            for (int i = 1; i < n + 1; i++)
            {
                if (i % 2 == 0)
                {
                    evenNum = int.Parse(Console.ReadLine());
                    evenSum += evenNum;
                }
                else
                {
                    oddNum = int.Parse(Console.ReadLine());
                    oddSum += oddNum;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes\nSum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}

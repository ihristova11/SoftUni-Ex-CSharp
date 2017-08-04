using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.Parse(Console.ReadLine());
            int num;


            for (int i = 1; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    sum += max;
                    max = num;
                }
                else
                {
                    sum += num;
                }
            }

            if (max == sum)
            {
                Console.WriteLine("Yes\nSum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(max - sum));
            }
        }
    }
}

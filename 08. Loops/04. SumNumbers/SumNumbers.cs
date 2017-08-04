using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int k;

            for (int i = 1; i <= n; i++)
            {
                k = int.Parse(Console.ReadLine());
                sum += k;
            }

            Console.WriteLine(sum);
        }
    }
}

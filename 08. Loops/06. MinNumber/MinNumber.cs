using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int j;

            for (int i = 0; i < n - 1; i++)
            {
                j = int.Parse(Console.ReadLine());

                if (j < min)
                {
                    min = j;
                }

            }
            Console.WriteLine(min);
        }
    }
}
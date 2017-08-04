using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double times = 0.75 * (48 - h) + (2.0 / 3 * p) + h;
            //Console.WriteLine(times);
            if (year == "leap")
            {
                times = times + times * 0.15;
            }
            //Console.WriteLine(times);
            Console.WriteLine(Math.Floor(times));
        }
    }
}

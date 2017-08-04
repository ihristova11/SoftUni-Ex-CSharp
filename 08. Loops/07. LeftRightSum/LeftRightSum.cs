using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LeftRightSum
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            int leftNum;
            int rightNum;

            for (int i = 1; i <= n; i++)
            {
                leftNum = int.Parse(Console.ReadLine());
                left += leftNum;
            }

            for (int j = n + 1; j <= 2 * n; j++)
            {
                rightNum = int.Parse(Console.ReadLine());
                right += rightNum;
            }

            if (right == left)
            {
                Console.WriteLine("Yes, sum = {0}", left);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(left - right));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            type = type.ToLower();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double premiere = 12;
            double normal = 7.5;
            double discount = 5;
            double income = 0;

            switch (type)
            {
                case "premiere":
                    income = premiere * row * col;
                    break;

                case "normal":
                    income = normal * row * col;
                    break;

                case "discount":
                    income = discount * row * col;
                    break;
            }

            Console.WriteLine("{0:F2} leva", income);
        }
    }
}

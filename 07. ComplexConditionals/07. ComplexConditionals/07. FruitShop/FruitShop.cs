using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Sunday" || day == "Saturday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.7 * quantity);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.25 * quantity);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.9 * quantity);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.6 * quantity);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 3 * quantity);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.6 * quantity);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 4.2 * quantity);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if(day == "Monday" || day == "Tuesday"|| day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch(fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.5 * quantity);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.2 * quantity);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.85 * quantity);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.45 * quantity);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 2.7 * quantity);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.5 * quantity);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 3.85 * quantity);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

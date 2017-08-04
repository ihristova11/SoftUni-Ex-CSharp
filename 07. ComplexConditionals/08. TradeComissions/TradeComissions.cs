using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double s = double.Parse(Console.ReadLine());
            double comission = 0;

            switch (city)
            {
                case "Sofia":
                    if (s >= 0 && s <= 500)
                    {
                        comission = 0.05;
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        comission = 0.07;
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        comission = 0.08;
                    }
                    else if (s > 10000)
                    {
                        comission = 0.12;
                    }
                    else
                    {
                        comission = -1;
                    }
                    break;

                case "Varna":
                    if (s >= 0 && s <= 500)
                    {
                        comission = 0.045;
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        comission = 0.075;
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        comission = 0.1;
                    }
                    else if (s > 10000)
                    {
                        comission = 0.13;
                    }
                    else
                    {
                        comission = -1;
                    }
                    break;

                case "Plovdiv":
                    if (s >= 0 && s <= 500)
                    {
                        comission = 0.055;
                    }
                    else if (s > 500 && s <= 1000)
                    {
                        comission = 0.08;
                    }
                    else if (s > 1000 && s <= 10000)
                    {
                        comission = 0.12;
                    }
                    else if (s > 10000)
                    {
                        comission = 0.145;
                    }
                    else
                    {
                        comission = -1;
                    }
                    break;

                default:
                    city = "";
                    break;
            }
            if (comission != -1 && city != "")
            {
                Console.WriteLine("{0:F2}", comission * s);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

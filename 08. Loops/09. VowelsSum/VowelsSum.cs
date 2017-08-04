using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;
            int sum = 0;

            for (int j = 0; j < text.Length; j++)
            {
                switch (text[j])
                {
                    case 'a':
                        sum += a;
                        break;
                    case 'e':
                        sum += e;
                        break;
                    case 'i':
                        sum += i;
                        break;
                    case 'o':
                        sum += o;
                        break;
                    case 'u':
                        sum += u;
                        break;
                    default:
                        sum += 0;
                        break;
                           
                }
            }
            Console.WriteLine(sum);
        }
    }
}

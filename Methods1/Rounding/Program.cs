using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input value: ");
            string money = Console.ReadLine();
            char[] characters = money.ToCharArray();
            double last = double.Parse(characters[characters.Length - 1].ToString());
            Console.WriteLine($"{Round(last)}");
            Console.ReadLine();
        }
        static double Round(double input)
        {
            double x;
            switch (input)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                x = 0;
                break;
            default:
                x = 10;
                break;
            }
            return x;
        }
    }
}

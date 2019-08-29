using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Input modulus: ");
            string mod = Console.ReadLine();
            Console.WriteLine($"Answer: {Math(num1, num2, mod)}");
            Console.ReadLine();
        }
        static double Math(double num1, double num2, string mod)
        {
            double x = 0;
            if (mod == "+") x = num1 + num2;
            else if (mod == "-") x = num1 - num2;
            else if (mod == "*") x = num1 * num2;
            else if (mod == "/") x = num1 / num2;
            else if (mod == "%") x = num1 % num2;
            return x;
        }
    }
}

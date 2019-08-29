using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number in Kilometres: ");
            double kilo = double.Parse(Console.ReadLine());
            Console.WriteLine($"{kilo} Kilometres is equal to {Mile(kilo)} miles");
            Console.ReadLine();
        }
        static double Mile(double result)
        {
            return result * 0.621371;
        }
    }
}

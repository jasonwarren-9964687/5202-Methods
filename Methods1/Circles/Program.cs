using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circle circumference equals {Circum(radius)} units.");
            Console.WriteLine($"Circle area equals {Area(radius)} units squared.");
            Console.ReadLine();
        }
        static double Circum(double result)
        {
            return result * 2 * Math.PI;
        }
        static double Area(double result)
        {
            return result * result * Math.PI;
        }
    }
}

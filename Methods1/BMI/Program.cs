using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Input height in metres: ");
            double height = double.Parse(Console.ReadLine());
            double result = BMI(weight, height);
            Console.WriteLine($"Your BMI is {result}.");
            Console.WriteLine($"Your Range is {range(result)}.");
            Console.ReadLine();
        }
        static double BMI(double num1, double num2)
        {
            return num1 / (num2 * num2);
        }
        static string range(double result)
        {
            string x = "";
            if (result < 18.5) x="Underweight";
            else if(result >= 30) x="Obese";
            else if(result >= 18.5 && result < 25) x="Normal";
            else if (result >= 25 && result < 30) x="Overweight";
            return x;
        }
    }
}

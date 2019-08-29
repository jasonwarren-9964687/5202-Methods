using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input weekday number (1 to 7): ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine($"Day equals {Day(day)}");
            Console.ReadLine();
        }
        static string Day(int input)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            return day [input-1];
        }
    }
}

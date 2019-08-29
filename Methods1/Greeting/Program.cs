using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 = Maori");
            Console.WriteLine("2 = Japanese");
            Console.WriteLine("3 = Hindi");
            Console.WriteLine("4 = French");
            Console.WriteLine("5 = Samoan");
            Console.Write("Input number to call language: ");
            int lan = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Day(lan)}");
            Console.ReadLine();
        }
        static string Day(int input)
        {
            string[] Lan = { "Kia Ora", "Konnichiwa", "Namaste", "Bonjour", "Talofa" };
            return Lan[input - 1];
        }
    }
}

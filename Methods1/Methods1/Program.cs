using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Changesign(number)}");
            Console.ReadLine();
        }
        static int Changesign(int result)
        {
            return result*-1;
        }
    }
}

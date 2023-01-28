using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeOrZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Entered number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Entered number is negative");
            }
            else
            {
                Console.WriteLine("Entered number is zero");
            }
            Console.ReadLine();





        }
    }
}

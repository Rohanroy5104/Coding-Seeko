using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyFloatingPointNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Input the first number : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            b = Convert.ToDouble(Console.ReadLine());
            x = a * b;
            Console.WriteLine("Result is : " + x);
            Console.ReadLine();

        }
    }
}

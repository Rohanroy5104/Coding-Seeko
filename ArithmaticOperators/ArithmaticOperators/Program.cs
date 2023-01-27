using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition : "+(a + b));
            Console.WriteLine("Substraction : "+(a - b));
            Console.WriteLine("Multiplication : "+(a * b));
            Console.WriteLine("Division : "+(a / b));
            Console.ReadLine();
        }
    }
}

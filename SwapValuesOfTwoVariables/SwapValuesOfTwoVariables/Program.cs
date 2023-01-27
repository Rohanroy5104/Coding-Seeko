using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapValuesOfTwoVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Input the first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("\nAfter swapping valuess");
            Console.WriteLine("Value of number1 : "+a);
            Console.WriteLine("Value of number2 : "+b);
            Console.ReadLine();
            
        }
    }
}

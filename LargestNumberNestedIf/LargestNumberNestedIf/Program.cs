using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberNestedIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter three numbers : \n");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2)
            {
                if (num1 >= num3)
                    Console.WriteLine(num1 + " is the Largest number");
                else
                    Console.WriteLine(num3 + " is the Largest number");
            }
            else if (num2 >= num3)
                Console.WriteLine(num2 + " is the Largest number");
            else
                Console.WriteLine(num3 + " is the Largest number");
            Console.ReadLine();






        }
    }
}

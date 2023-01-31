using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i <= num; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of all odd number from 1 to " + num + " = " + sum);
            Console.ReadLine();
      
        }
    }
}

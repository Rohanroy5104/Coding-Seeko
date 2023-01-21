using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            Console.Write("\n\n");
            Console.Write("Check whether the number is perfect number or not ? : \n");
            Console.Write("\n\n");
            Console.Write("Input the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive number : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0} ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", sum);
            if (sum == 0)
                Console.Write("\nSo, the number is perfect");
            else
                Console.Write("\nSo, the number is not perfect");
            Console.Write("\n");

                Console.ReadLine();
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TotalCoffeeCost = 0;
            //Start:
            Console.WriteLine("Please select your Coffee size : 1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 55;
                    break;
                case 2:
                    TotalCoffeeCost += 75;
                    break;
                case 3:
                    TotalCoffeeCost += 95;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    break;
            }
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
            Console.ReadLine();
        

            
                    
            

                
                 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNameOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int week;
            Console.WriteLine("Enter week number from 1 - 7 : ");
            week = Convert.ToInt32(Console.ReadLine());
            if (week == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (week == 2)
            {
                Console.WriteLine("Tueday");
            }
            else if (week == 3)
            {
                Console.WriteLine("Wednessday");
            }
            else if (week == 4)
            {
                Console.WriteLine("Thusday");
            }
            else if (week == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (week == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (week == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Input ! Please enter week in between 1-7. ");
            }
            Console.ReadLine();






        }
    }
}

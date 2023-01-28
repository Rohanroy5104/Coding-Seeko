using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year % 4 == 0 ? "Entered year is a Leap year" : "Not leap year");
            Console.ReadLine();





        }
    }
}

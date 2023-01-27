using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFeetToMeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double meter, feet;
            Console.WriteLine("Input the number in feet : ");
            feet = Convert.ToInt32(Console.ReadLine());
            meter = feet / 3.2808399;
            Console.WriteLine("\nFeet in meter : " + meter);
            Console.ReadLine();
        }
    }
}

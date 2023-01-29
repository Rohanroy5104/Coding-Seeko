using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EligibilityAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("The cadidate is not eligible to caste vote");
            }
            else
            {
                Console.WriteLine("The candidate is eligible to caste vote");
            }
            Console.ReadLine();





        }
    }
}

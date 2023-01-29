using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            Console.WriteLine("Enter the average marks of PCM : ");
            marks = Convert.ToInt32(Console.ReadLine());
            if (marks > 63)
            {
                Console.WriteLine("Entered marks is eligible for an engineering course");
            }
            if (marks < 63)
            {
                Console.WriteLine("Entered marks is not eligible for an engineering course");
            }
                
                Console.ReadLine();






            }
        }
    }



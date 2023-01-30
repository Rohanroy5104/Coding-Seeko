using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i <= 255; i++)
            {
                Console.WriteLine("ASCII values of " + i + " = " + i);
            }
            Console.ReadLine();




        }
    }
}

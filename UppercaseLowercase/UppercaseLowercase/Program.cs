using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseLowercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine(ch + " is lowercase alphabet");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + "is uppercase alphabet");
            }
            else
            {
                Console.WriteLine(ch + "is not an alphabet");
            }
            Console.ReadLine();







        }
    }
}

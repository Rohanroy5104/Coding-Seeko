using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Alphabets from a - z are: ");
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                Console.Write(ch + "\n");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVowelOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Input an Alphabet A - Z or a - z : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("you entered a number, Please enter an alphabet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("Alphabet is not vowel");
                        break;
                }
            }
            Console.ReadLine();





        }
    }
}

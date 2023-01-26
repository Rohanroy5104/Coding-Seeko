using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeOrNot
{
    internal class Program
    {
        public static bool checkPalindrome(string inputString)
        {
            char[] c = inputString.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(inputString);
        }
        public static void Main()
        {
            Console.WriteLine(checkPalindrome("aaa"));
            Console.WriteLine(checkPalindrome("abc"));
            Console.WriteLine(checkPalindrome("madam"));
            Console.WriteLine(checkPalindrome("121121"));
            Console.ReadLine();
        }





        }
    }


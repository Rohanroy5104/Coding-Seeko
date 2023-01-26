using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 7, 8, 6 };
            Console.WriteLine("\nOriginal array : [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if an array contains an odd number ? " + even_odd(nums));
            Console.ReadLine();
        }
        public static bool even_odd(int[] nums)
        {
            foreach (var n in nums)
            {
                if (n % 2 != 0)
                    return true;
            }
            return false;
        }




        }
    }


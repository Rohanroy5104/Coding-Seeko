using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 4, 5 };
            Console.WriteLine("\nArray1 : [{0}]", string.Join(", ", array1));
            int[] array2 = { 2, 4, 9 };
            Console.WriteLine("\nArray2 : [{0}]", string.Join(", ", array2));
            int[] array3 = { 3, 3, 7 };
            Console.WriteLine("\nArray3 : [{0}]", string.Join(", ", array3));
            int[] new_array = { array1[1], array2[1], array3[1] };
            Console.WriteLine("\nNew array : [{0}]", string.Join(", ", new_array));
            Console.ReadLine();


        }
    }
}

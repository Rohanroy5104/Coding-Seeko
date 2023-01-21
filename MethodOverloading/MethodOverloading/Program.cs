using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace MethodOverloading
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN, out int sum)
        {
            Console.WriteLine("sum = {0}", FN + SN);
            sum = FN + SN;
        }

        Console.ReadLine();
    

    }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}

//Console.ReadLine();


namespace DefaultAndExplicit
{
    public class Program : I1, I2 
    {
        public static void Main(string[] args)
        {
            Program P = new Program();
            P.InterfaceMethod();
            ((I2)P).InterfaceMethod();
        }
        public void InterfaceMethod()
        {
            Console.WriteLine("Interface1 Method");
        }
        void I2.InterfaceMethod()
        { 
            Console.WriteLine("Interface2 Method");
            Console.ReadLine();
        }
       

        
    }
}

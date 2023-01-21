using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Explicit
{
    internal class Program : I1, I2
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            ((I1)P).InterfaceMethod();
            ((I2)P).InterfaceMethod();
        }
        void I1.InterfaceMethod()
            {
            Console.WriteLine("I1 interface method implementation");
            
        }
        void I2.InterfaceMethod()
            { Console.WriteLine("I2 interface method implementation"); }
        
    }
}
interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();

    //Console.ReadLine();
}




           
        
    


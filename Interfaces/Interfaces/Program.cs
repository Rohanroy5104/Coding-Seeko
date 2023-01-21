using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ICustomer1
{
    void Print1();
}
interface ICustomer2 : ICustomer1
{
    void Print2();
}
public class Customer : ICustomer2
{
    public void Print2()
    {
        Console.WriteLine("Roy");
    }
    public void Print1()
    { Console.WriteLine("Rohan"); }

}


namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();
           
            

            Console.ReadLine();

        }
    }
}

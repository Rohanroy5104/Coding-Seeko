using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Customer
{
    private int _id;
    private string _name;
    public string Name
    {
        get
        { return _name; }
        set { _name = value; }
    }
    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }
    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    

    }
    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);
    }
}

namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Rohan");
            C1.PrintDetails();
            Customer C2 = new Customer();
            C2.ID = 102;
            C2.Name = "John";
            C2.PrintDetails();
            Customer C3 = new Customer();
            C3.ID = 103;
            C3.Name = "Rob";
            C3.PrintDetails();
        
            
            Console.ReadLine();

        }
    }
}

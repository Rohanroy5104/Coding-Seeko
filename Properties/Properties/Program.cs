using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    private int _id;
    private string _Name;
    private int _age = 18;
    public int GetAge()
    {
        return this._age;
    }
    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name cannot be Null or Empty");
        }
        this._Name = Name;
    }
    public string GetName()
    {
        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
    }
    public void SetId(int Id)
    {
        if (Id <= 0)
        {
            throw new Exception("Student Id cannot be negative");
        }
        this._id = Id;
    }
    public int GetId()
    {
        return this._id;
    }
}

namespace Properties
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetId(52);
            C1.SetName("Rohan");
            Console.WriteLine("Student Id = {0}", C1.GetId());
            Console.WriteLine("Student Name = {0}", C1.GetName());
            Console.WriteLine("Age = {0}", C1.GetAge());

           

            Console.ReadLine();
        }
    }
}

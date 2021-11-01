using System;

namespace Tutlane
{
    // Base Class
    public class Users
    {
        public string name = "Monzurul Islam";
        public string location = "Dhaka";
        public int age = 24;
        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }
    // Derived Class
    public class Details : Users
    {
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Age: {0}", base.age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            d.GetInfo();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
    //  ***Here is Base KeyWord with Constructor***
/*using System;

namespace Tutlane
{
    // Base Class
    public class BClass
    {
       public BClass()
       {
          Console.WriteLine("Welcome to Tutlane");
       }
       public BClass(string a, string b)
       {
          Console.WriteLine("Name: {0}", a);
          Console.WriteLine("Location: {0}", b);
       }
    }
    // Derived Class
    public class DClass : BClass
    {
        // This constructor will call default constructor
        public DClass(): base()
        {
            Console.WriteLine("First Constructor");
        }

       // This constructor will call parameterized constructor
       public DClass(string x, string y): base(x, y)
       {
           Console.WriteLine("Second Constructor");
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
           DClass dClass1 = new DClass();
           DClass dClass2 = new DClass("Monzurul Islam", "Dhaka");
           Console.WriteLine("\nPress Enter Key to Exit..");
           Console.ReadLine();
        }
    }
}
 */

using System;

class Role_of_parameter_Using_Array
{
    private string str = "The Sun Infosystems";
    public void Display()
    {
        Console.WriteLine("You are in Display method");
        Display(100, "Rupesh");

        Console.WriteLine("------");
        Display(200, "Rupesh", "Ajit");

        Console.WriteLine("------");
        Display(300, "Rupesh", "Vaibhav", "Sam");
    }
    public void Display(int a, params string[] parameterArray)
    {
        foreach (string str in parameterArray)
            Console.WriteLine(str + " " + a);
    }
    static void Main(string[] args)
    {
        Role_of_parameter_Using_Array obj = new Role_of_parameter_Using_Array();
        obj.Display();
        Console.ReadLine();
    }
}   

/*using System;

namespace Tutlane
{
    // Declare Delegate
    public delegate void SampleDelegate(int a, int b);
    class MathOperations
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add Result: {0}", a + b);
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract Result: {0}", x - y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Delegate Example****");
            MathOperations m = new MathOperations();
            // Instantiate delegate with add method
            SampleDelegate dlgt;
            dlgt = m.Add;

            dlgt(10, 90);
            // Instantiate delegate with subtract method
            dlgt = m.Subtract;
            dlgt(10, 90);
            Console.ReadLine();
        }
    }
}*/
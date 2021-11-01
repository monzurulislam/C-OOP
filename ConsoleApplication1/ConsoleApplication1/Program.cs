using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate void Mydelegate(string msg);

    class Program
    {
        static void Main(string[] args)
        {
           
           Mydelegate del = A.MethodA;
            del("Hello World");
            InovkeDelegate(del);

            del = B.MethodB;
            del("Hello World");
            InovkeDelegate(del);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");
            InovkeDelegate(del);

            Console.ReadKey();
        }

        static void InovkeDelegate(Mydelegate del)
        {
            del("Hello World");
        }
    }

    class A
    {
       public static void MethodA(string message)
        {
            Console.WriteLine("This is ClassA: " + message); 
        }
    }

    class B
    {
       public static void MethodB(string message)
        {
            Console.WriteLine("This is ClassB: " + message);
           // Console.ReadKey();

        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace MyNamespace
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            var result = Calculator.Add(new List<int> () {10,20,30});

            Console.WriteLine("Sum is = {0}",result);
            Console.ReadKey();
        }
    }

    class Calculator
    {
        [Obsolete("Use Add(List<int>Numbers) Method",true)]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;

            foreach (int Number in Numbers )
            {
                sum += Number;
            }
              
            return sum;
        }
    }
}*/




 




       





























#define hello
using System.Diagnostics;
using System;
/// Conditional Attributes ///

namespace Attributes
{
    public class Myclass
    {
        [Conditional("hello")]

        public static void Message(string msg)
        {
            Console.WriteLine("msg");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Function1()
        {
            Console.WriteLine("In Function one");
            Function2();
            
        }

        static void Function2()
        {
            Console.WriteLine("In Function two");
        }

        static void Main(string[] args)
        {
            Myclass.Message("string");

            Console.WriteLine("In Main functon");

            Function1();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance;
            singleton.PrintDetails("First Object");

            Singleton singleton2 = Singleton.GetInstance;
            singleton2.PrintDetails("Second Object");

            Console.ReadKey();
        }
    }
}

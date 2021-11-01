using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphism;

///Compile Time Polymorphism

/*namespace Polymorphism 
    public class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }

        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }

    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculate calculate = new Calculate();
        calculate.AddNumbers(7,9);
        calculate.AddNumbers(400,600,500);

        Console.ReadKey();
    }
}
*/
/// Compile Time Polymorphism

namespace Polymorphism
{
    public class User
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("This is Base Class");
        }
    }

    public class Details : User
    {
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("This Sub Class");
            Console.ReadKey();
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Details details = new Details();
            details.GetInfo();
        }
    }

}
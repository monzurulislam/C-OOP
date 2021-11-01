using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticMemberAndMethod;


namespace StaticMemberAndMethod
{
    class StaticMethod
    {
        public static int number;

        public void count()
        {
            number++;
        }

        public static int getNumber()
        {
            return number;
        }
    }
    
}

class Execution
{
    static void Main(string[] args)
    {
        StaticMethod staticMethod = new StaticMethod();

        staticMethod.count();
        staticMethod.count();
        staticMethod.count();
        staticMethod.count();
        
        Console.WriteLine("The value of first object is: {0}",StaticMethod.getNumber());

        Console.ReadKey();
    }
}








































/*namespace StaticMemberAndMethod
{
    class StaticClass  
    {
        public static int number;

        public void count()
        {
            number++;
        }

        public int getNumber()
        {
            return number;
        }

    }
}

class Execution
{
    static void Main(string[] args)
    {
        StaticClass staticClass1 = new StaticClass();
        StaticClass staticClass2 = new StaticClass();

        staticClass1.count();
        Console.WriteLine("value of first object: {0}",staticClass1.getNumber());

        staticClass2.count();
        Console.WriteLine("value of 2nd object is: {0}",staticClass2.getNumber());

        Console.WriteLine("value of first object: {0}", staticClass1.getNumber());

        Console.ReadKey();
    }
}*/

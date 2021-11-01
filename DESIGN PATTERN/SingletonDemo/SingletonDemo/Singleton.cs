using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Singleton
    {
       private static int Counter = 0;

       private static Singleton _instance = null;

       public static Singleton GetInstance
       {
           get
           {
               if (_instance == null)
                   _instance = new Singleton();

               return _instance;
           }
       }

       private Singleton()
        {
            Counter++;
            Console.WriteLine("Counter Value = " + Counter.ToString());
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

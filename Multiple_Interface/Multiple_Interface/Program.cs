using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Interface
{
    interface IName
    {
        void GetName(string name);
    }

    interface IAge
    {
        void GetAge(String age);
    }

    interface ILocation
    {
        void GetLocation(string locatoin);
    }

    class User : IName, IAge, ILocation
    {
        public void GetName(string name)
        {
            Console.WriteLine("Name: {0}", name);
        }

        public void GetAge(string age)
        {
            Console.WriteLine("Age: {0}",age);
        }

        public void GetLocation(string location)
        {
            Console.WriteLine("Location: {0}",location);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.GetName("Monzurul Islam");
            user.GetAge("24");
            user.GetLocation("Dhaka, Bangladesh");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Iuser
    {
        void GetDetails();
    }

    class User1 : Iuser
    {
        public void GetDetails()
        {
            Console.WriteLine("Name: Monzurul Islam");
        }
    }

    class User2 : Iuser
    {
        public void GetDetails()
        {
            Console.WriteLine("Location: Dhaka, Bangladesh");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User1 user = new User1();
            user.GetDetails();

            User2 user2 = new User2();
            user2.GetDetails();

            Console.ReadKey();
        }
    }
}

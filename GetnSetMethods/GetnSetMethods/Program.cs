/*
   ### Read Only Properties ### 

using System;

namespace Tutlane
{
    class User
    {
        private string name;
        private string location;
  
        public User(string a, string b)
        {
            name = a;
            location = b;
        }
  
        public string Name
        {
            get
            {
                return name;
            }
        }
  
        public string Location
        {
            get
            {
                return location;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Monzurul Islam", "Dhaka");
            // compile error
            // u.Name = "Rohini";
            // get accessor will invoke
            Console.WriteLine("Name: " + u.Name);
            // get accessor will invoke
            Console.WriteLine("Location: " + u.Location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}*/


 //  ### Write Only Properties ###//
 
using System;

namespace Tutlane
{
     class User
     {
        private string name;

        public string Name
        {
           set
           {
              name = value;
           }
        }
  
        private string location;
 
        public string Location
        {
            set
            {
                location = value;
            }
        }
        public void GetUserDetails()
        {
           Console.WriteLine("Name: " + name);
           Console.WriteLine("Location: " + location);
        }
     }
     class Program
     {
         static void Main(string[] args)
         {
              User u = new User();
              u.Name = "Monzurul Islam";
              u.Location = "Dhaka";
              // compile error
              //Console.WriteLine(u.Name);
              u.GetUserDetails();
              Console.WriteLine("\nPress Enter Key to Exit..");
              Console.ReadLine();
         }
     }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GetnSetMethods
{
    class User
    {

        private string location;
        private string name = "Monzurul Islam";

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Name
        {
            get
            {
                return name.ToUpperInvariant();
            }
            set
            {
                if (value == "Monzurul")
                {
                    name = value;
                    Console.WriteLine("ok");
                }

                Console.WriteLine("ok");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            // set accessor will invoke
            user.Name = "Monzurulfsfd";

            // set accessor will invoke
            user.Location = "Dhaka";

            // get accessor will invoke
            Console.WriteLine("Name: " + user.Name);

            // get accessor will invoke
            Console.WriteLine("Location: " + user.Location);

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}*/


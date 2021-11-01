using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encasulation
{
    class Information
    {
        private string _name;
        private string _location;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Information information = new Information();
            information.Name = "Monzurul Islam";
            information.Location = "Dhaka";

            Console.WriteLine("Name: " + information.Name);
            Console.WriteLine("Location: " + information.Location);

            Console.ReadKey();
        }
    }
}

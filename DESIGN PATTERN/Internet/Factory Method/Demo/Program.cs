using CustomerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{

    class Program
    {
        static void Main(string[] args)
        {
            //Client Code
            BaseCustomerFactory c = new GoldCustomerFactory();// Or new SilverCustomerFactory();
            ICustomer objCust = c.GetCustomer();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public interface ICustomer
    {
        void AddPoints();
        void AddDiscount();
    }

    public class GoldCustomer : ICustomer
    {
        public void AddPoints()
        {
            Console.WriteLine("Gold Customer - Points Added");
        }

        public void AddDiscount()
        {
            Console.WriteLine("Gold Customer - Discount Added");
        }

        public void GoldOperation()
        {
            Console.WriteLine("Operation specific to Gold Customer");
        }
    }

    public class SilverCustomer : ICustomer
    {
        public void AddPoints()
        {
            Console.WriteLine("Silver Customer -  Points Added");
        }

        public void AddDiscount()
        {
            Console.WriteLine("Silver Customer - Discount Added");
        }

        public void SilverOperation()
        {
            Console.WriteLine("Operation specific to Silver Customer");
        }
    }
}

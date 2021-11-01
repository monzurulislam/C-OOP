using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("101", "A");
            ht.Add("102", "B");
            ht.Add("103", "C");
            ht.Add("104", "D");
            ht.Add("105", "E");


            if (ht.ContainsKey("106"))
            {
                Console.WriteLine("This value already in Hash Table");
            }
            else
            {
                ht.Add("106", "F");
            }
            
            ICollection key = ht.Keys;
            

            foreach (string i in key)
            {
                Console.WriteLine(i + " "+ ht[i]);
            }

            Console.ReadKey();
        }
    }
}

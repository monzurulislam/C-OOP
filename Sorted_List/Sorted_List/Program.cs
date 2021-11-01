using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(1, 101);
            sortedList.Add(2, 102);
            sortedList.Add(3, 103);
            sortedList.Add(4, 104);
            sortedList.Add(5, 105);

            if (!sortedList.ContainsKey(6))
            {
                sortedList.Add(6, 106);
            }
            else
            {
                Console.WriteLine("The value is already in List");
            }

            ICollection key = sortedList.Keys;

            foreach (int i in key)
            {
                Console.WriteLine(i + " " + sortedList[i]);
            }

            Console.ReadKey();
        }
    }
}

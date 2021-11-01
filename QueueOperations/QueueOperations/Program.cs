using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue('A');
            queue.Enqueue('M');
            queue.Enqueue('G');
            queue.Enqueue('W');

            Console.WriteLine("Current queue: ");
            foreach (char c in queue) Console.Write(c + " ");

            Console.WriteLine();

            queue.Enqueue('V');
            queue.Enqueue('H');

            Console.WriteLine("Current queue: ");
            foreach (char c in queue) Console.Write(c + " ");

            Console.WriteLine();

            Console.WriteLine("Removing some values ");

            char ch = (char)queue.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);

            ch = (char)queue.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
           
            Console.WriteLine();

            Console.WriteLine("Current queue: ");
            foreach (char c in queue) Console.Write(c + " ");

            Console.WriteLine();

            Console.WriteLine("The Total element of Queue = " + queue.Count);

            Console.ReadKey();
        }
    }
}

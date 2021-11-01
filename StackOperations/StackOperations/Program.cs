using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            stack.Push('E');

            foreach (char c in stack)
                Console.WriteLine(c + " ");

            Console.WriteLine(" ");

            stack.Push('F');
            stack.Push('G');

            Console.WriteLine("Peak value of Stack = " + stack.Peek());
            Console.WriteLine(" ");
            Console.WriteLine("Current Stack");

            foreach (char c in stack)
                Console.WriteLine(c + " ");

            stack.Pop();
            stack.Pop();

            Console.WriteLine(" ");
            Console.WriteLine("After Stack Pop ");

            foreach (char c in stack)
            {
                Console.WriteLine(c + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Total element of Stack = " + stack.Count);
            Console.ReadKey();
        }
    }
}

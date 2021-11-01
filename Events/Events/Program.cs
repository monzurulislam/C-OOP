using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Math
    {
        //public delegate void SampleDegate();

        public event Action SampleEvent;

        public void Add(int a, int b)
        {
            if (SampleEvent != null)
            {
                SampleEvent();
                Console.WriteLine("Add result: {0}", a + b);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }

        public void Subtract(int x, int y)
        {
            if (SampleEvent != null)
            {
                SampleEvent();
                Console.WriteLine("Subtract Answer: {0}",x-y);
            }
            else
            {
                Console.WriteLine("Not Subscribed to Event");
            }
        }

    }

    class Operations
    {
        Math math = new Math();
        public int a;
        public int b;

        public Operations(int x, int y)
        {
            math.SampleEvent += SampleEventHandler;
            a = x;
            b = y;
        }

        public void SampleEventHandler()
        {
            Console.WriteLine("SampleEvent Handler: Calling Method");

        }

        public void AddOperaton()
        {
            math.Add(a,b);
        }

        public void Substract()
        {
            math.Subtract(a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Event Testing");
            Operations operations = new Operations(10,20);

            operations.AddOperaton();
            operations.Substract();
            Console.ReadKey();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        private double length;

        public Program(double len)
        {
            Console.WriteLine("Object is being created, length = {0}", len);
             length = len;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Program program = new Program(50.32);
            program.setLength(6.23);
            Console.WriteLine("Length of line : {0}", program.getLength());

            Console.WriteLine("The value of length is: {0}",program.getLength());
            Console.ReadKey();
        }
    }
}

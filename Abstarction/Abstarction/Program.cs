using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstarction
{
     abstract class Shape
    {
        public abstract int Area();
    }

    class Rectangle : Shape
    {
        private int length;  
        private int width;

        public Rectangle(int a, int b)
        {
            Console.WriteLine("Object is Created");
            length = a;
            width = b;
        }

        public override int Area()
        {
             //Console.WriteLine("The Rectangle class area = ");
                 return length * width;
        }
    }       


    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5,8);
            //rectangle.Area(6, 7);
            //int a = rectangle.Area();
            Console.WriteLine("The Area = {0}",rectangle.Area());
            Console.ReadKey();
         }
    }
}
                           
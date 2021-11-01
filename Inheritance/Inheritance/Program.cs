using System;
using ClassLibrary1;

namespace MyNamespace
{
    class Rectangle
    {
        private readonly int _length;
        private readonly int _width;

        public Rectangle(int l, int w)
        {
            _length = l;
            _width = w;
        }

        public int GetArea()
        {
            return _length * _width;
        }

        public virtual void Display()
        {
            Console.WriteLine("The length = {0}",_length);
            Console.WriteLine("The width = {0}",_width);
            Console.WriteLine("The Area = {0}",GetArea());
            
        }
    }

    class Inheritance : Rectangle
    {
        private int cost;
        public Inheritance(int l, int w) : base(l,w){ }

        public int getCost()
        {
            int cost;
            cost = GetArea() * 70;
            return cost;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Cost = {0}",getCost());
        }

    }

    public class Class2 : Class1
    {
        public int GetArea()
        {
            return base.Area();
        }
    }

    class Execute
    {
        static void Main(string[] args)
        {
            Inheritance inheritance = new Inheritance(5,7);
            inheritance.Display();

            //Console.ReadKey();

            Class1 class1 = new Class1();
            class1.Length();
            Console.WriteLine(class1.Length());

            Class2 class2 = new Class2();
            class2.GetArea();

            Console.WriteLine(class2.GetArea());
            Console.ReadKey();
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        public void SetLength(int l)
        {
            length = l;
        }

        protected int width;
        protected int height;
        protected int length;
    }

    class Rectangle : Shape
    {
        public int getArea()
        {
            return width * length;
        }
    }

    class Cube : Shape
    {
        public int GetVolume()
        {
            return length * width * height;
        }
    }

    class Base
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Cube cube = new Cube();

            rectangle.SetLength(10);
            rectangle.SetWidth(5);

            cube.SetLength(4);
            cube.SetWidth(5);
            cube.SetHeight(5);

            Console.WriteLine("The Area of Rectangle = {0}",rectangle.getArea());
            Console.WriteLine("The Volume of Cube = {0}",cube.GetVolume());
            Console.ReadKey();


        }
    }
}*/

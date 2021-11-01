using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
       public int Area()
        {
            return 5;
        }

        public double Length()
        {
            return 6.3;
        }
    }

    public class program
    {
        public program()
        {
            Class1 class1 = new Class1();
            class1.Area();
        }
    }
}

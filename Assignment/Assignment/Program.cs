using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public interface IInterface
    {
        void Calculation(double a, double b);
    }

   public class FirstPerson : IInterface
    {
        public void Calculation(double a, double b)
        {
            int x = (int)a + (int)b;
            
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }

   public class SecondPerson : IInterface
    { 
        public void Calculation(double a, double b)
        {
            double x = a + b;
            Console.WriteLine(string.Format("{0:F2}", x));
            Console.ReadKey();
        }
    }

   public class ThirdPerson : IInterface
    {
        public void Calculation(double a, double b)
        {
            double x = a + b;
            Console.WriteLine(string.Format("{0:F3}", x));
            Console.ReadKey();
        }
    }

   public class Thirty : IInterface
    {
        public void Calculation(double a, double b)
        {
            double x = a + b;
            Console.WriteLine(string.Format("{0:F10}", x));
            Console.ReadKey();
        }
    }

   public class DecimalFactory
   {
       public IInterface GetCalculation(string str)
       {
           if (str == "three")
           {
                return new ThirdPerson();
           }

           else
           {
               return null;
           }
       }
   }

    class Program
    {
        static void Main(string[] args)
        {
            double n=3.38, m=5.4986;
            var method = "three";
           
            new DecimalFactory().GetCalculation(method).Calculation(n,m);
        }
    }
}

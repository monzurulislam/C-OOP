using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tutlane
{
    // Base Class
    public class BClass
    {
        public virtual string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# Tutorial");
        }
    }

    // Derived Class
    public class DClass : BClass
    {
        private string name;

        public override string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "No Value";
                }
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine("Welcome to Tutlane");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DClass dClass = new DClass();
            dClass.GetInfo();

            BClass bClass = new BClass();
            bClass.GetInfo();

            bClass.Name = "Monzur";
            Console.WriteLine(bClass.Name);

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetMethods_2
{
    abstract class Student
    {
        public abstract string Name
        {
            get;
            set;
        }

        public abstract int Age
        {
            get;
            set;
        }
    }

    class Person : Student
    {
        private string code;
        private string name;
        private int age;

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public override string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public override int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + "  Name = " + Name + "  Age = " + Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Code = "101";
            person.Name = "Al Amin";
            person.Age = 24;

            Console.WriteLine("Studnet Info: {0}",person);

            person.Code = "101";
            person.Name = "Sunny";
            person.Age = 24;

            Console.WriteLine("Student Info: {0}",person);
            Console.ReadKey();
        }
    }
}

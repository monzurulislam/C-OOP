using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }

    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        } 

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    public interface IAbstractProductA
    {
        string UsefullFunctionA();
    }

    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefullFunctionA()
        {
            return " The Result of Product A1. ";
        }
    }

    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefullFunctionA()
        {
            return " The Result of Product A2. ";
        }
    }

    public interface IAbstractProductB
    {
        string UsefullFunctionB();

        string AnotherUsefullFunctionB(IAbstractProductA collaborator);
    }

    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefullFunctionB()
        {
            return " The Result of Product B1. ";
        }

        public string AnotherUsefullFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefullFunctionA();

           return string.Format(" The result of the B1 collaborating with the ({0})", result);
        }
    }

    class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefullFunctionB()
        {
            return " The Result of Product B2. ";
        }

        public string AnotherUsefullFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefullFunctionA();

            return string.Format(" The result of the B2 collaborating with the ({0})", result);

        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine(" Clien: Testing client code with the first factory type.....");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();
            
            Console.WriteLine(" Clien: Testing client code with the first factory type.....");
            ClientMethod(new ConcreteFactory2());
            Console.WriteLine();
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var ProductA = factory.CreateProductA();
            var ProductB = factory.CreateProductB();

            Console.WriteLine(ProductA.UsefullFunctionA());
            //Console.WriteLine(ProductA.AnotherUsefullFunctionA(ProductA));
        }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            new Client().Main();
            Console.ReadKey();

        }
    }
}

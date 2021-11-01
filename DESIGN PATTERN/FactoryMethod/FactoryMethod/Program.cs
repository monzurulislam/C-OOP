﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();
            var result = " Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }
    }

    class ConcreteCreator1 : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct1();
            }
        }

        class ConcreteCreator2 : Creator
        {
            public override IProduct FactoryMethod()
            {
                return new ConcreteProduct2();
            }
        }

        public interface IProduct
        {
            string Operation();
        }

        class ConcreteProduct1 : IProduct
        {
            public string Operation()
            {
                return " { Result of CreatorProduct1 }";
            }
        }

        class ConcreteProduct2 : IProduct
        {
            public string Operation()
            {
                return " { Result of CreatorProduct2 }";
            }
        }

        class Client
        {
            public void Main()
            {
                Console.WriteLine(" APP Lanuch with ConcreteCreator1");
                ClientCode(new ConcreteCreator1());

                Console.WriteLine();

                Console.WriteLine(" APP Lanuch with ConcreteCreator1");
                ClientCode(new ConcreteCreator2());

            }

            public void ClientCode(Creator creator)
            {
                Console.WriteLine("Clien: I am not aware of the creator's class, " + "but it still works.\n" +
                                  creator.SomeOperation());
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

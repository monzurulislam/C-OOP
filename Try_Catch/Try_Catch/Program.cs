using System;

namespace TutlaneExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter x value:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter y value:");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(x / y);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input string was not in a correct format.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Not a valid numbers to perform operation");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide By Zero");
            }
            Console.ReadLine();
        }
    }
}
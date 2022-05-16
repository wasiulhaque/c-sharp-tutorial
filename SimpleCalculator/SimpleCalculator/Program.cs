using System;
using System.Linq;
using System.Transactions;
using Microsoft.VisualBasic.CompilerServices;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double mod = 0;
            string operation = "";

            Console.WriteLine("Welcome to the Simple Calculator\n");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n1.Addition\n" +
                              "2.Subtraction\n" +
                              "3.Multiplication\n" +
                              "4.Division\n");
            Console.Write("Enter the operation you want to perform: ");
            int userInput = Convert.ToInt16(Console.ReadLine());
            switch (userInput)
            {
                default:
                    Console.WriteLine("\nNot a valid input.");
                    break;
                case 1:
                    operation = "addition";
                    result = num1 + num2;
                    break;
                case 2:
                    operation = "subtraction";
                    result = num1 - num2;
                    break;
                case 3:
                    operation = "multiplication";
                    result = num1 * num2;
                    break;
                case 4:
                    operation = "division";
                    result = num1 / num2;
                    mod = num1 % num2;
                    break;
            }

            if (operation.Length != 0)
            {
                Console.Write("\nResult of the " +
                              operation +
                              " operation: ");
                Console.WriteLine(result);
                if (operation == "division" && mod != 0)
                {
                    Console.Write("Mod of the division operation: ");
                    Console.WriteLine(mod);
                }
            }

            Console.WriteLine("\nThank you for using this calculator.");
        }
    }
}

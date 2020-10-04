using System;
using System.ComponentModel.DataAnnotations;
using static PerfectNumberLibrary.PerfectNumber;

namespace PerfectNumberProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task \"Perfect number\"\n");

            try
            {
                Console.Write("Enter natural number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Answer: " + IsPerfectNumber(number));
            }
            catch (ValidationException)
            {
                Console.WriteLine("\nError: ValidationException");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: FormatException");
            }
        }
    }
}
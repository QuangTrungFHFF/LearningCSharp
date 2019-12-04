using System;

namespace NumberConversionV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with method and class. Please choose the problem!");
            Console.WriteLine("1. Write a method that prints the digits of a given decimal number in a reversed order.");
            int chooseProblem = int.Parse(Console.ReadLine());
            
            switch(chooseProblem)
            {
                case 1: //Method> 7. Write a method that prints the digits of a given decimal number in a reversed order.For example 256, must be printed as 652.
                    Console.WriteLine("Please enter an interger number!");
                    string inputString = Console.ReadLine();
                    int inputNumber = int.Parse(inputString);
                    Converter newInt = new Converter();
                    int result = newInt.ReverseNumber(inputNumber);
                    Console.WriteLine(result);
                    break;
            }
            
            

        }
    }
}

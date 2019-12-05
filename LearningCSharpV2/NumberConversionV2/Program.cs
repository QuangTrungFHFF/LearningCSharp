using System;

namespace NumberConversionV2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Working with method and class. Please choose the problem!");
            Console.WriteLine("1. Write a method that prints the digits of a given decimal number in a reversed order.");
            Console.WriteLine("2. Sum of two very long positive integer numbers.");
            Console.WriteLine("3. Finds the biggest element of an array. Use that method to implement sorting in descending order.");
            int chooseProblem = int.Parse(Console.ReadLine());

            switch (chooseProblem)
            {
                case 1: //Method> 7. Write a method that prints the digits of a given decimal number in a reversed order.For example 256, must be printed as 652.

                    Console.WriteLine("Please enter an interger number!");
                    string inputString = Console.ReadLine();
                    int inputNumber = int.Parse(inputString);
                    Converter newInt = new Converter();
                    int result = newInt.ReverseNumber(inputNumber);
                    Console.WriteLine(result);
                    break;

                case 2: //Method> 8.Sum of two very long positive integer numbers.                 

                    Console.WriteLine("Please enter the first number!");
                    string firstNumInt = Console.ReadLine();
                    Console.WriteLine("Please enter the second number!");
                    string secondNumInt = Console.ReadLine();

                    Converter con = new Converter();
                    int[] firstNum = con.ParseStringToDigitArray(firstNumInt);
                    int[] secondNum = con.ParseStringToDigitArray(secondNumInt);
                    int[] sumResult = con.GetSumOfDigitArray(firstNum, secondNum);

                    Console.WriteLine("");
                    foreach (int j in sumResult)
                    {
                        Console.Write(j + " ");
                    }
                    break;

                case 3: //Method> 9.Finds the biggest element of an array. Use that method to implement sorting in descending order.

                    Random ran = new Random();
                    //Generate a random input array
                    int[] numArray = new int[20];
                    for(int i =0; i<20;i++)
                    {
                        numArray[i] = ran.Next(0, 100);
                    }
                    
                    foreach (int j in numArray)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to get the biggest element!");
                    Console.ReadKey(true);

                    Converter conv = new Converter();
                    int maxElement = conv.GetMaxElement(numArray);
                    Console.WriteLine("The biggest element:" + maxElement);
                    conv.SortArray(numArray);
                    Console.ReadKey(true);

                    break;
            }
        }
    }
}
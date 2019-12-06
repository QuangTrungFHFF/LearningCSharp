using System;

namespace OOPLearningV1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Chap 11> Please choose a problem!");
            Console.WriteLine("1. Check leap year.");
            Console.WriteLine("2. Generates and prints on the console 10 random numbers in the range [100, 200].");

            int chooseInput = int.Parse(Console.ReadLine());
            switch (chooseInput)
            {
                //1. Check leap year
                case 1:
                    Console.WriteLine("Please enter a year!");
                    string inputS = Console.ReadLine();
                    //Checking valid input or not
                    while (!int.TryParse(inputS, out year))
                    {
                        Console.WriteLine("Invalid year! Please enter a new value!");
                        inputS = Console.ReadLine();
                    }
                    //Checking Leap Year or not
                    Calendar.isLeapYear(year);
                    break;
                //2. Generates and prints on the console 10 random numbers in the range [100, 200].
                case 2:
                    int randomInt;
                    RandomValues rand = new RandomValues();
                    for (int i = 0; i < 10; i++)
                    {
                        randomInt = rand.GetRandomInt(100, 200);
                        Console.Write(" {0}", randomInt);
                    }
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}
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
            Console.WriteLine("3. Write a program, which prints, on the console which day of the week is today.");
            Console.WriteLine("4. standard output the count of days, hours, and minutes, which have passes since the computer is started until the moment of the program execution.");
            Console.WriteLine("5. Finds the hypotenuse of a right triangle.");

            int chooseInput = int.Parse(Console.ReadLine());
            Calendar calendar = new Calendar();
            Calculator calculator = new Calculator();
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
                //3. Write a program, which prints, on the console which day of the week is today.
                case 3:
                    Console.WriteLine("Current date and time is: ");
                    Console.WriteLine(calendar.GetCurrentDateTime());
                    Console.WriteLine("Today is: " + calendar.GetDayOfWeekToday());
                    break;
                //4. Standard output the count of days, hours, and minutes, which have passes since the computer is started until the moment of the program execution.
                case 4:
                    Console.WriteLine("Current date and time is: ");
                    Console.WriteLine(calendar.GetCurrentDateTime());
                    Console.WriteLine("Computer uptime : " + calendar.GetUpTime());
                    Console.ReadKey(true);
                    break;
                //5. Finds the hypotenuse of a right triangle.
                case 5:
                    //Enter the first side of the triangle
                    Console.WriteLine("Please enter the first side: ");
                    string sSideA = Console.ReadLine();
                    double sideA;
                    while(!double.TryParse(sSideA,out sideA))
                    {
                        Console.WriteLine("Invalid input. Please enter again!");
                        sSideA = Console.ReadLine();
                    }
                    //Enter the second side of the triangle
                    Console.WriteLine("Please enter the second side: ");
                    string sSideB = Console.ReadLine();
                    double sideB;
                    while (!double.TryParse(sSideB, out sideB))
                    {
                        Console.WriteLine("Invalid input. Please enter again!");
                        sSideB = Console.ReadLine();
                    }
                    double hypotenuse = calculator.GetHypotenuse(sideA, sideB);
                    Console.WriteLine("Hypotenuse is: {0:N2}",hypotenuse);
                    Console.ReadKey(true);
                    break;
            }
        }
    }
}
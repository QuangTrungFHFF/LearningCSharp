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
            Console.WriteLine("4. standard output the count of days, hours, and minutes, which have passes since the computer is started.");
            Console.WriteLine("5. Finds the hypotenuse of a right triangle.");
            Console.WriteLine("6. Calculates the area of a triangle.");
            Console.WriteLine("7.Split string");
            

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
                //6. Calculates the area of a triangle.
                case 6:
                    Console.WriteLine("What do u have?");
                    Console.WriteLine("1> Three sides;");
                    Console.WriteLine("2> Side and the altitude to it");
                    Console.WriteLine("3> Two sides and the angle between them in degrees.");
                    int chooseMethod = int.Parse(Console.ReadLine());
                    double area;
                    
                    switch (chooseMethod)
                    {
                        case 1:
                            //Enter the first side of the triangle
                            Console.WriteLine("Please enter the first side: ");
                            string sSideAx = Console.ReadLine();
                            double sideAx;
                            while (!double.TryParse(sSideAx, out sideAx))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sSideAx = Console.ReadLine();
                            }
                            //Enter the second side of the triangle
                            Console.WriteLine("Please enter the second side: ");
                            string sSideBx = Console.ReadLine();
                            double sideBx;
                            while (!double.TryParse(sSideBx, out sideBx))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sSideBx = Console.ReadLine();
                            }
                            //Enter the third side of the triangle
                            Console.WriteLine("Please enter the third side: ");
                            string sSideCx = Console.ReadLine();
                            double sideCx;
                            while (!double.TryParse(sSideCx, out sideCx))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sSideCx = Console.ReadLine();
                            }
                            area = calculator.GetAreaFromThreeSide(sideAx, sideBx, sideCx);
                            Console.WriteLine("Area of the triangle is: {0:N2}",area);
                            break;
                        case 2:
                            //Enter the first side of the triangle
                            Console.WriteLine("Please enter the first side: ");
                            string sSideF = Console.ReadLine();
                            double sideF;
                            while (!double.TryParse(sSideF, out sideF))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sSideF = Console.ReadLine();
                            }
                            //Enter the altitude of that side
                            Console.WriteLine("Please enter the altitude: ");
                            string sAltitude = Console.ReadLine();
                            double altitude;
                            while (!double.TryParse(sAltitude, out altitude))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sAltitude = Console.ReadLine();
                            }
                            area = calculator.GetAreaFromSideAndAltitude(sideF,altitude);
                            Console.WriteLine("Area of the triangle is: {0:N2}", area);
                            break;
                        case 3:
                            //Enter the first side of the triangle
                            Console.WriteLine("Please enter the first side: ");
                            string sSideFirst = Console.ReadLine();
                            double sideFirst;
                            while (!double.TryParse(sSideFirst, out sideFirst))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sSideFirst = Console.ReadLine();
                            }
                            //Enter the second side of the triangle
                            Console.WriteLine("Please enter the second side: ");
                            string sSideSecond = Console.ReadLine();
                            double sideSecond;
                            while (!double.TryParse(sSideSecond, out sideSecond))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sSideSecond = Console.ReadLine();
                            }
                            //Enter the angle between those 2 sides
                            Console.WriteLine("Please Enter the angle between those 2 sides ");
                            string sAngle = Console.ReadLine();
                            double angle;
                            while (!double.TryParse(sAngle, out angle))
                            {
                                Console.WriteLine("Invalid input. Please enter again!");
                                sAngle = Console.ReadLine();
                            }
                            area = calculator.GetAreaFromSideAndAngle(sideFirst, sideSecond, angle);
                            Console.WriteLine("Area of the triangle is: {0:N2}", area);
                            break;
                    }
                    break;
                    //Chap 11> 9.Split string
                case 7:
                    string rawString = "25 47 85 632 541 87 52 145 23 65 ";
                    Console.WriteLine("String: "+rawString);
                    char[] separator = new char[] { ' ' };
                    string[] resultString = rawString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    int sum = 0;
                    foreach(string s in resultString)
                    {
                        sum += int.Parse(s);
                    }
                    Console.WriteLine("Sum of the string is: {0}", sum);
                    break;
            }
        }
    }
}
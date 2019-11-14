using System;
using Nakov.IO;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace IntroToCSharp
{
    class HelloCSharp
    {
        static DateTime thisDate = DateTime.Now;

        static void Main(string[] args)
        {
            /*double d = Math.Sqrt(12345);
            double k = Math.Round(d, 3);
            string ageinput;
            int age;
            System.Console.WriteLine("Current time:");
            System.Console.WriteLine("(f) Full date/short time: . . {0:f}\n",thisDate);
            /*System.Console.WriteLine("Square root of 12345 is:  "+ k);

            double a = 2;           
            for (int i=0; i<99; i++)
            {
                if (a % 2 == 0)
                {
                    System.Console.Write(a + " ");
                }
                else
                {
                    System.Console.Write(a * (-1) + " ");
                }
                a++;
            }

            System.Console.WriteLine("Please input your age:");
            ageinput = System.Console.ReadLine();
            bool isInterger = int.TryParse(ageinput, out age);
            if(isInterger!=false)
            {
                age = age + 10;
                System.Console.WriteLine("Your age next 10 years is: " + age);
            }
            else
            {
                System.Console.WriteLine("Invalid input!");
            }
            System.Console.ReadLine();*/


            /*Console.WriteLine("Please input your weigh:");
            int w = Int32.Parse(Console.ReadLine());
            double wMoon = w * 0.17;
            Console.WriteLine("Your weigh in the moon is: " + wMoon+" kg");*/

            //*********check if point inside triangle*********//
            /*Console.WriteLine("Please input x:");
            double xp = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input y:");
            double yp = Double.Parse(Console.ReadLine());
            double d = Math.Sqrt(xp * xp + yp * yp);
            Console.WriteLine(d <= (double)5 ? "The point is within the circle" : "The point is outside the circle");
            double[] x = { 0,  -1, 5 };
            double[] y = { 0, 5, 5 };
            //barycentric coordinate system
            double a = ((y[1] - y[2]) * (xp - x[2]) + (x[2] - x[1]) * (yp - y[2])) / ((y[1] - y[2]) * (x[0] - x[2]) + (x[2] - x[1]) * (y[0] - y[2]));
            double b = ((y[2] - y[0]) * (xp - x[2]) + (x[0] - x[2]) * (yp - y[2])) / ((y[1] - y[2]) * (x[0] - x[2]) + (x[2] - x[1]) * (y[0] - y[2]));
            double c = 1 - a - b;
            double i = ((y[1] - y[2]) * (x[0] - x[2]) + (x[2] - x[1]) * (y[0] - y[2]));
            Console.WriteLine(i);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            bool checkInside = ((0 <= a&&a <= 1) && (0 <= b&&b <= 1) && (0 <= c&&c <= 1)) ? true : false;
            Console.WriteLine(checkInside==false ? "The point is outside the rectangular" : "The point is inside the rectangular");*/

            /*Console.WriteLine("Please input a four-digit number."); //abcd
            int num=0;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine(isInterger);
            /*if (num>10000 || num<999)
            {
                Console.WriteLine("Invalid number.");
            }
            else
            {
                //Calculates the sum of the digits//
                int a = num / 1000;
                int b = (num / 100) % 10;
                int c = (num / 10) % 10;
                int d = num % 10;
                int sumResult = a + b + c + d;
                Console.WriteLine("Sum of the digits: "+sumResult);

                //Prints on the console the number in reversed order: dcba
                Console.WriteLine("The number in reversed order: " + d+c+b+a);

                //Puts the last digit in the first position: dabc
                Console.WriteLine("Last digit in the first position: " + d + a + b + c);

                //Exchanges the second and the third digits
                Console.WriteLine("Exchanges the second and the third digits " + a + c + b + d);
            }*/

            //************11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number********
            /*
            Console.WriteLine("Please input a number n"); 
            int num = 0;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("Please input a position p");
            int pos = 0;
            isInterger = Int32.TryParse(Console.ReadLine(), out pos);
            int newNum = num >> pos;
            bool isOne = (newNum & 1) == 1? true:false;
            Console.WriteLine(isOne == true ? "The bit in the position " + pos + " is: 1" : "The bit in the position " + pos + " is: 0");
            */
            //**********13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v.***//
            /*Console.WriteLine("Please input a number n");
            int num = 0;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("Please input a position p");
            int pos = 0;
            isInterger = Int32.TryParse(Console.ReadLine(), out pos);
            Console.WriteLine("Please input a value v");
            int val = 1;
            isInterger = Int32.TryParse(Console.ReadLine(), out val);
            int i = 1;
            int newI = i << pos;
            bool isOne = (num & newI) != 0 ? true : false;
            
            Console.WriteLine(isOne == true ? "The bit in the position " + pos + " is: 1" : "The bit in the position " + pos + " is: 0");
            if (((isOne==true)&&(val == 1))|| ((isOne == false) && (val == 0)))
            {
                Console.WriteLine("New number: " +num);
            }
            else if((isOne == true) && (val == 0))
            {
                num = num ^ newI;
                Console.WriteLine("New number: " + num);
            }
            else if ((isOne == false) && (val == 1))
            {
                num |= (newI);
                Console.WriteLine("New number: " + num);
            }
            else
            {
                Console.WriteLine("Error");
            }
            */

            //******14. Write a program that checks if a given number n (1 < n < 100) is a prime number******//
            /*
            Console.WriteLine("Please input a number n ( 1 < n < 100)");
            int num = 0;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out num);
            if ((num<2)||(num>99))
            {
                Console.WriteLine("Invalid number");
            }
            else if (num ==2)
            {
                Console.WriteLine(num + " is a Prime number");
            }
            else
            {
                int a = 0;
                int iMax = (int)Math.Ceiling(Math.Sqrt(num));
                for (int i = 2;i<= iMax;i++)
                {
                    if (num%i ==0)
                    {
                        ++a;
                    }
                    else
                    {
                        a += 0;
                    }
                }
                Console.WriteLine(a==0?num +" is a Prime number": num+" is not a Prime number");
            }
            */

            //******15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32 - bit unsigned integer.******//

            /*Console.WriteLine("Please input a number n");
            int num = 0;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("Please input a number p");
            int pos = 0;
            isInterger = Int32.TryParse(Console.ReadLine(), out pos);
            Console.WriteLine("Please input a number q");
            int qop = 0;
            isInterger = Int32.TryParse(Console.ReadLine(), out qop);
            Console.WriteLine("Please input a number k");
            int k = 0;
            isInterger = Int32.TryParse(Console.ReadLine(), out k);
            for(int i =0;i<k;i++)
            {
                string numS = Convert.ToString(num, 2);
                Console.WriteLine(numS);
                int bitp = (num >> pos) & 1;
                int bitq = (num >> qop) & 1;
                Console.WriteLine(bitp);
                Console.WriteLine(bitq);
                num = num & (~(1 << qop)) | (bitp << qop);
                numS = Convert.ToString(num, 2);
                Console.WriteLine(numS);
                num = num & (~(1 << pos)) | (bitq << pos);
                numS = Convert.ToString(num, 2);
                Console.WriteLine(numS);
                pos++;
                qop++;
            }
            
            int result = 0;
            Console.WriteLine("Please input 3 numbers");
            for (int i =0;i<3;i++)
            {
                result += Int32.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Sum of 3 numbers is: {0:0.00}",result);
            
            int hexNum = 2013;
            Console.Write("|0x{0,-8:X}|", hexNum);
            double fractNum = -1.856;
            Console.Write("|{0,-10:f2}|", fractNum);
            double fractNum2 = 1.856;
            Console.WriteLine("|{0,-10:f2}|", fractNum2);
            
            
            Console.WriteLine("Please input first number:");
            int firstInt = 0;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out firstInt);
            int secondInt = 10;
            isInterger = Int32.TryParse(Console.ReadLine(), out secondInt);
            if(firstInt==secondInt)
            {
                Console.WriteLine("There are 0 number between {0} and {1}.", firstInt, secondInt);
            }
            else if (firstInt<secondInt)
            {
                int result = 0;
                for(int i = firstInt;i<secondInt;i++)
                {
                    if(i%5==0)
                    {
                        result += 1;
                    }
                    else { }
                }
                Console.WriteLine("There are {0} number between {1} and {2} such that the remainder of their division by 5 is 0.", result, firstInt, secondInt);
            }
            else
            {
                int result = 0;
                for (int i = secondInt; i < firstInt; i++)
                {
                    if (i % 5 == 0)
                    {
                        result += 1;
                    }
                    else { }
                }
                Console.WriteLine("There are {0} number between {2} and {1} such that the remainder of their division by 5 is 0.", result, firstInt, secondInt);
            }
            
            int[] num = new int[2];
            Console.WriteLine("Please input first number:");            
            bool isInterger = Int32.TryParse(Console.ReadLine(), out num[0]);            
            isInterger = Int32.TryParse(Console.ReadLine(), out num[1]);
            Array.Sort(num);
            Array.Reverse(num);
            foreach(int i in num)
            {
                Console.Write(" "+i);
            }
            */
            //******9.Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.******//
            /*
            Console.WriteLine("Please input n:");
            int n = 5;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out n);
            int inputTimes=0;
            int result = 0;
            int[] numArray = new int[n];
            bool incorrect = true;
            while(incorrect||inputTimes<n )
            {
                Console.WriteLine("Please input [{0}] number:",(inputTimes+1));
                isInterger = Int32.TryParse(Console.ReadLine(), out numArray[inputTimes]);
                if (isInterger==true)
                {
                    result += numArray[inputTimes];
                    inputTimes++;
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Please input a valid number!");
                    incorrect = true;
                }
            }
            Console.WriteLine("Sum of all the number is:"+result);
            Array.Sort(numArray);
            Array.Reverse(numArray);
            Console.WriteLine("The biggest number is:" + numArray[0]);
            */
            //******10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.******//
            /*
            Console.WriteLine("Please input n:");
            int n = 1;
            bool isInterger = Int32.TryParse(Console.ReadLine(), out n);
            int[] numArray = new int[n];
            for(int i =0;i<n;i++)
            {
                numArray[i] = i + 1;
            }
            foreach(int j in numArray)
            {
                Console.WriteLine(j);
            }
            */
            //******11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …******//
            /*
            decimal[] fibonacciArray = new decimal[100];
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;
            for(int i =2;i<100;i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }
            foreach(decimal j in fibonacciArray)
            {
                Console.Write(" " + j);
            }
            */
            /*
            double result = 1;
            int i = 2;
            bool isTrue = true;
            while(isTrue)
            {
                double oldResult = result;
                if (i%2==0)
                {
                    result += 1 / (double)i;
                    i++;
                }
                else
                {
                    result -= 1 / (double)i;
                    i++;
                }
                isTrue = (Math.Abs(result - oldResult) > 0.001) ? true : false;

            }
            Console.WriteLine(result);
            */

            /*
            Console.WriteLine("Please input first number:");
            int firstNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please input second number:");
            int secondNum = Int32.Parse(Console.ReadLine());
            if (firstNum>secondNum)
            {
                int oldNum = firstNum;
                firstNum = secondNum;
                secondNum = oldNum;
                Console.WriteLine("First number: " +firstNum);
                Console.WriteLine("Second number: " + secondNum);
            }
            else
            {
                Console.WriteLine("First number: " + firstNum);
                Console.WriteLine("Second number: " + secondNum);
            }
            */
            /*
            double[] num = new double[3];
            int countNegative = 0;
            Console.WriteLine("Please input first number:");
            num[0] = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input second number:");
            num[1]  = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input third number:");
            num[2]  = Double.Parse(Console.ReadLine());
            for(int i=0;i<3;i++)
            {
                if(num[i]==0)
                {
                    countNegative = 4;
                }
                else if (num[i]<0)
                {
                    countNegative++;
                }
                else
                {

                }
            }
            if(countNegative>=4)
            {
                Console.WriteLine("The result is: 0");
            }
            else if (countNegative%2 ==0)
            {
                Console.WriteLine("The result is positive");
            }
            else
            {
                Console.WriteLine("The result is negative");
            }
            */
            /*
            Console.WriteLine("Please input a number from 0 to 9.");
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            */
            //******6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax2 + bx + c,******//
            /*
            Console.WriteLine("Please input a:");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input b:");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please input c:");
            double c = Double.Parse(Console.ReadLine());
            double[] result = new double[5];
            double delta = (b * b) - (4 * a * c);
            if(delta<0)
            {
                Console.WriteLine("The quadratic equation have no real root.");
            }
            else if(delta==0)
            {
                Console.WriteLine("The quadratic equation have one real root.");
                result[0] = b / (2 * a);
                Console.WriteLine("x = {0:F2}",result[0]);
            }
            else
            {
                Console.WriteLine("The quadratic equation have two real root.");
                result[0] = (-b+Math.Sqrt(delta)) / (2 * a);
                result[1] = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = {0:F2}", result[0]);
                Console.WriteLine("x2 = {0:F2}", result[1]);
            }
            */
            /*
            double[] numArray = new double[5];
            //bool isCorrect = true;
            int inputTimes = 0;
            while(inputTimes<5)
            {
                Console.WriteLine("Please input [{0}] number.!",(inputTimes+1));
                bool isDouble = Double.TryParse(Console.ReadLine(), out numArray[inputTimes]);
                if(isDouble != true)
                {
                    Console.WriteLine("Invalid input");
                    
                }
                else
                {
                    inputTimes++;
                }
            }
            Array.Sort(numArray);
            Array.Reverse(numArray);
            Console.WriteLine("The greatest number is: {0:F2}.",numArray[0]);
            */
            //******Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.******//
            /*             
            Console.WriteLine("Please input something!");
            double num=0;
            int count = 0;
            string inputS = Console.ReadLine();
            bool isNum = Double.TryParse(inputS, out num);
            count = isNum == true ? (count + 1) : (count + 0);
            switch(count)
            {
                case 1:
                    Console.WriteLine((num + 1));
                    break;
                case 0:
                    Console.WriteLine("*");
                    break;
                default:
                    Console.WriteLine("why?");
                    break;
            }
            */
            /*Random rand = new Random();
            int[] numArray = new int[5];
            int[] numArray2 = { -5, 56, -3, 10, -7 } ;
            int a = 0;
            int[] numTwoSum = new int[10];
            int sum = 1;
            for (int i=0;i<5;i++)
            {
                numArray[i] = rand.Next(0,100) + (-50);
                Console.Write(numArray[i] + " ");
            }
            numTwoSum[0] = numArray2[0] + numArray2[1];
            numTwoSum[1] = numArray2[0] + numArray2[2];
            numTwoSum[2] = numArray2[0] + numArray2[3];
            numTwoSum[3] = numArray2[0] + numArray2[4];
            numTwoSum[4] = numArray2[1] + numArray2[2];
            numTwoSum[5] = numArray2[1] + numArray2[3];
            numTwoSum[6] = numArray2[1] + numArray2[4];
            numTwoSum[7] = numArray2[2] + numArray2[3];
            numTwoSum[8] = numArray2[2] + numArray2[4];
            numTwoSum[9] = numArray2[3] + numArray2[4];*/
            /*
            Console.WriteLine("Please input score!");
            int number = 0;
            bool isGood = false;
            while(!isGood)
            {
                if(int.TryParse(Console.ReadLine(),out number))
                {
                    isGood = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again!");
                }
            }
            if (number <0 || number>9)
            {
                Console.WriteLine("You're cheating!");
            }
            else if (number>0 && number<=3)
            {
                number *= 10;
                Console.WriteLine("Final score:" + number);
            }
            else if (number > 3 && number <7)
            {
                number *= 100;
                Console.WriteLine("Final score:" + number);
            }
            else
            {
                number *= 1000;
                Console.WriteLine("Final score:" + number);
            }
            */
            /*
            string[] strArray = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] strArrayTy = { "one", "two", "three", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] strSpecial = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifthteen", "sixteen", "seventeen", "eighteen", "nine teen","twenty", "thirdty" };
            Console.WriteLine("Please input a number!");
            int number = 0;//abc
            bool isGood = false;
            while (!isGood)
            {
                if (int.TryParse(Console.ReadLine(), out number)&& number>0 && number<1000)
                {
                    isGood = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again!");
                }
            }
            int a = number / 100;
            int b = (number / 10) % 10;
            int c = number % 10;
            string sentence = "";
            if (a != 0 && b == 0 && c==0)
            {
                sentence = sentence + strArray[a - 1] + " hundred ";
            }
            else if (a != 0 && (b != 0 || c != 0))
            {
                sentence = sentence + strArray[a - 1] + " hundred and ";
            }

            switch (b)
            {
                case 0:
                    break;                    
                case 1:
                    if (c == 0)
                    {
                        sentence = sentence + strSpecial[0];
                        break;
                    }
                    else
                    {
                        sentence = sentence + strSpecial[c]+ " ";
                        break;
                    }
                case 2:
                    sentence = sentence + strSpecial[10] + " ";
                    break;
                case 3:
                    sentence = sentence + strSpecial[11] + " ";
                    break;
                default:
                    sentence = sentence + strArrayTy[b - 1] ;
                    break;
            }

            if (b!=1 && c>0)
            {
                sentence = sentence + strArray[c - 1] ;
            }

            Console.WriteLine(sentence);
            
            int a = 2;
            BigInteger k = 1;
            while(k<50000000000000)
            {
                k *= a;
                Console.WriteLine(k);
            }
           */

            /*Console.WriteLine("Please input n:");
            int num=0;
            string inputS = Console.ReadLine();
            while(!int.TryParse(inputS, out num))
            {
                Console.WriteLine("Invalid input! Please try again!");
                inputS = Console.ReadLine();
            }
            for(int i=1;i<=num;i++)
            {
                Console.Write(" "+i);
            }
            */

            /*Console.WriteLine("Please input n!");
            int num = 0;
            string inputS = Console.ReadLine();
            while(!int.TryParse(inputS,out num))
            {
                Console.WriteLine("Invalid input! Please try again!");
                inputS = Console.ReadLine();

            }
            for(int i =1; i<=num;i++)
            {
                if (i%21 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            */
            //******Write a program that reads from the console a series of integers and prints the smallest and largest of them.******//
            /*int n = 0;
            int[] numArray = new int[25];
            string inputS = "notend";
            while(inputS !="end")
            {
                Console.WriteLine("Please input an interger! Type \"end\" if you are finish!");
                int num = 0;
                inputS = Console.ReadLine();
                while (!int.TryParse(inputS, out num)&& inputS !="end")
                {
                    Console.WriteLine("Invalid input! Please try again!");
                    inputS = Console.ReadLine();
                }
                numArray[n] = num;
                n++;
            }
            int[] numArray2 = new int[n-1];
            for (int i = 0; i < (n-1);i++)
            {
                numArray2[i] = numArray[i];
            }
            Array.Sort(numArray2);
            Array.Reverse(numArray2);
            foreach(int j in numArray2)
            {
                Console.Write(" " + j);
            }
            Console.WriteLine("");
            Console.WriteLine("The biggest number is: " + numArray2[0]);
            Array.Reverse(numArray2);
            Console.WriteLine("The smallest number is: " + numArray2[0]);
            */

            /*
            List<string> myintList = new List<string>() {"2","3","4","5", "6", "7", "8", "9", "10", "J", "Q","K","Ace" };
            List<string> myTypeCards = new List<string>(4) { "Spades", "Heart", "Diamond", "Club" };
            int n = myintList.Count;
            for (int i =0; i<n;i++)
            {
                foreach (string j in myTypeCards)
                {
                    string outString = myintList[i] + " " + j;
                    Console.WriteLine(outString);
                }
            }
            */

            /*Console.WriteLine("Please input n!");
            int num = 0;
            var bigIntegers = new List<System.Numerics.BigInteger>();
            BigInteger newInt = 0;
            string inputS = Console.ReadLine();
            while(!int.TryParse(inputS,out num)|| num > 100)
            {
                Console.WriteLine("Invalid input! Please enter again!");
                inputS = Console.ReadLine();
            }
            bigIntegers.Add(0);
            bigIntegers.Add(1);
            for (int i = 2;i<num;i++)
            {
                newInt = bigIntegers[i - 2] + bigIntegers[i - 1];
                bigIntegers.Add(newInt);
            }
            var sum = bigIntegers.Aggregate(BigInteger.Add);
            Console.WriteLine(sum);
            */
            //******Find factorial number******//
            /*int N = 0;
            Console.WriteLine("Please input N:");
            string inputN = Console.ReadLine();
            while(!int.TryParse(inputN,out N)||N<3)
            {
                Console.WriteLine("Invalid input N. Please try again!");
                inputN = Console.ReadLine();
            }
            int K = 0;
            Console.WriteLine("Please input K:");
            string inputK = Console.ReadLine();
            while (!int.TryParse(inputK, out K)|| K>N || K<2)
            {
                Console.WriteLine("Invalid input K. Please try again!");
                inputK = Console.ReadLine();
            }
            IEnumerable<int> nArray = Enumerable.Range(1, N);
            IEnumerable<int> kArray = Enumerable.Range(1, K);
            int factorialN = nArray.Aggregate((f, s) => f * s);
            int factorialK = kArray.Aggregate((f, s) => f * s);
            double result = (double)factorialN / factorialK;
            Console.WriteLine(factorialN);
            Console.WriteLine(factorialK);
            Console.WriteLine("The result is: "+ result);
            */
            /*
            Console.WriteLine("Please input n!");
            int num = 0;
            int l = 0;
            string inputS = Console.ReadLine();
            while(!int.TryParse(inputS,out num))
            {
                Console.WriteLine("Invalid input. Please input n!");
                inputS = Console.ReadLine();
            }
            List<int> intList = new List<int>(num - 1);
            for(int i =0; i<num;i++)
            {
                
                for(int k =i; k<(num+i); k++ )
                {
                    Console.Write("{0} ",(k+1));
                }
                Console.WriteLine(Environment.NewLine);
                   
            }
            */
            //********calculates with how many zeroes the factorial of a given number ends********//
            /*Console.WriteLine("Please input n!");
            BigInteger num = 0;            
            string inputS = Console.ReadLine();
            BigInteger result = 0;
            int count=0;
            while(!BigInteger.TryParse(inputS,out num))
            {
                Console.WriteLine("Invalid input.Please input n again!");
                inputS = Console.ReadLine();
            }
            var factorialN = new List<BigInteger>();
            for(int i=0;i<num;i++)
            {
                factorialN.Add((i + 1));
            }
            result = factorialN.Aggregate<BigInteger>((f, s) => f * s);
            Console.WriteLine("n! = {0}",result);
            while(result>0 && result%10 ==0)
            {
                result /= 10;
                count++;
            }
            Console.WriteLine("There are {0} zeros at the end of {1}!", count,num);
            */
            //********Convert decimal to binary*********//
            /*
            Console.WriteLine("Please input n!");
            int num = 0;
            string inputS = Console.ReadLine();
            while(!int.TryParse(inputS,out num))
            {
                Console.WriteLine("Invalid input. Please input n!");
                inputS = Console.ReadLine();
            }
            string output = Convert.ToString(num,2);
            Console.WriteLine(output);
            */
            /*
            Console.WriteLine("Please input n!");
            int num = 0;
            string inputS = Console.ReadLine();
            while (!int.TryParse(inputS, out num))
            {
                Console.WriteLine("Invalid input. Please input n!");
                inputS = Console.ReadLine();
            }
            List<int> myList = new List<int>(Enumerable.Range(1, num));
            for (int i = 0; i < myList.Count(); i++)
            {
                Console.Write("{0} ", myList[i]);
            }
            myList.Shuffle();
            Console.WriteLine();
            for (int i = 0; i < myList.Count(); i++)
            {
                Console.Write("{0} ", myList[i]);
            }
            */
            /*
            Console.WriteLine("Please input a!");
            int numA = 0;
            string inputSA = Console.ReadLine();
            while (!int.TryParse(inputSA, out numA)||(numA==0))
            {                
                Console.WriteLine("Invalid input. Please input n!");
                inputSA = Console.ReadLine();
            }
            Console.WriteLine("Please input b!");
            int numB = 0;
            string inputSB = Console.ReadLine();
            while (!int.TryParse(inputSB, out numB) || (numB == 0))
            {
                Console.WriteLine("Invalid input. Please input n!");
                inputSB = Console.ReadLine();
            }
            int t = numA;
            if (numA<numB)
            {                
                numA = numB;
                numB = t;
            }
            while(numB!=0)
            {
                t = numB;
                numB = numA % numB;
                numA = t;
            }
            Console.WriteLine("Great common divisor(GCD) is: {0}",numA);
            */
            /*
            Console.WriteLine("Please input n!");
            int num = 0;
            string inputS = Console.ReadLine();
            while (!int.TryParse(inputS, out num) || (num == 0))
            {
                Console.WriteLine("Invalid input. Please input n!");
                inputS = Console.ReadLine();
            }
            int count = num * num;
            int[,] matrix = new int[num, num];
            int posX = 0;
            int posY = 0;
            int direction = 0;
            int stepPos = num-1; 
            int stepChange = 1;
            int stepCount = 1;
            //Fill the first row with value
            for (int i = 1; i <= num; i++)
            {
                matrix[posY, posX] = i;
                posX++;
            }

            posX--;
            posY++;
            for(int i =(num+1);i<=count;i++)
            {
                matrix[posY, posX] = i;

                //Check direction
                if(stepCount<stepPos)
                {
                    stepCount++;
                }
                else
                {
                    if(stepChange>1)
                    {
                        stepPos--;
                        stepChange = 1;
                    }
                    else
                    {
                        stepChange++;
                    }
                    
                    stepCount = 1;
                    if(direction==3)
                    {
                        direction = 0;
                    }
                    else
                    {
                        direction++;
                    }
                }
                switch (direction)
                {
                    case 0://down
                        posY++;
                        break;
                    case 1://left
                        posX--;
                        break;
                    case 2://up
                        posY--;
                        break;
                    case 3://right
                        posX++;
                        break;
                }
            }

            for (int i =0; i<num;i++)
            {
                for(int j =0; j<num;j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);                    
                }
                Console.WriteLine();
            }
            */
            /*
            int[] myArray = new int[20];
            for(int i=0;i<20;i++)
            {
                myArray[i] = i * 5;
            }
            foreach(int j in myArray)
            {
                Console.Write(" " + j);                
            }
            Console.WriteLine(myArray.Length);
            */
            /*
            int[] myArray = { 1, 1, 2, 2, 2, 5, 2, 3, 4, 2, 1, 8, 8, 8, 8, 6, 9, 7, 4, 1 };
            int length = myArray.Length;
            int pos = myArray[0];
            int seq = 1;
            int maxSeq = 1;
            int maxPos=0;
            for(int i=1; i<length;i++)
            {
                if(myArray[i]==pos)
                {
                    seq++;
                    if(seq>maxSeq)
                    {
                        maxSeq = seq;
                        maxPos = pos;
                    }

                }
                else
                {
                    pos = myArray[i];
                    seq = 1;
                }
            }
            int[] resultArray = new int[maxSeq];
            for(int i=0;i<maxSeq;i++)
            {
                resultArray[i] = maxPos;
            }
            foreach(int j in resultArray)
            {
                Console.Write(" " + j);
            }
            */
            /*
            int[] myArray = new int[30];
            int[] result = new int[myArray.Length];
            int counter = 0, tempIndex, tempCounter;
            Random rand = new Random();
            for(int i=0;i<myArray.Length;i++)
            {
                myArray[i] = rand.Next(10);
            }
            foreach(int j in myArray)
            {
                Console.Write(" " + j);
            }

            for(int i =0;i<myArray.Length;i++)
            {
                int[] tempResult = new int[myArray.Length];
                tempIndex = tempCounter = 1;
                tempResult[0] = myArray[i];

                for(int j = i+1;j<myArray.Length;j++)
                {
                    if(myArray[j]>tempResult[tempIndex-1])
                    {
                        tempResult[tempIndex] = myArray[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex>1&&myArray[j]>tempResult[tempIndex-2]&&myArray[j]<tempResult[tempIndex-1])
                    {
                        tempResult[tempIndex - 1] = myArray[j];
                    }

                    if(counter<tempCounter)
                    {
                        counter = tempCounter;
                        result = tempResult;
                    }


                }
                


            }
            Console.WriteLine("ssssss");
            for (int i = 0; i < counter; i++)
            { Console.Write("{0},", result[i]); }
            }
        */
            /*
                Console.WriteLine("Please input N.");
                int numN, numK = 0;
                int sum = 0;
                int pos = 0;
                string inputS = Console.ReadLine();
                while (!int.TryParse(inputS, out numN))
                {
                    Console.WriteLine("Invalid input! Please input N.");
                    inputS = Console.ReadLine();
                }
                Console.WriteLine("Please input K.(K < N)");
                inputS = Console.ReadLine();
                while (!int.TryParse(inputS, out numK) || numK > numN)
                {
                    Console.WriteLine("Invalid input! Please input K.");
                    inputS = Console.ReadLine();
                }

                int[] arrayN = new int[numN];
                Random rand = new Random();

                for (int i = 0; i < numN; i++)
                {
                    arrayN[i] = rand.Next(101);
                }
                Console.WriteLine("Default array: ");
                foreach (int k in arrayN)
                {
                    Console.Write(" " + k);
                }

                for (int i = 0; i < (numN - numK); i++)
                {
                    int tempSum = 0;
                    for (int j = i; j < (i + numK); j++)
                    {
                        tempSum += arrayN[j];
                    }
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        pos = i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Result array: ");
                for (int i = pos; i < pos + numK; i++)
                {
                    Console.Write(" " + arrayN[i]);
                }
                */
            /*
        int[] arrayN = new int[40];
        Random rand = new Random();

        for (int i = 0; i < 40; i++)
        {
            arrayN[i] = rand.Next(10);
        }
        foreach (int k in arrayN)
        {
            Console.Write(" " + k);
        }
        Array.Sort(arrayN);
        Console.WriteLine();
        foreach (int k in arrayN)
        {
            Console.Write(" " + k);
        }
        int result=arrayN[0];
        int count = 1;
        int countMax = 1;
        for(int i =1; i<arrayN.Length;i++)
        {
            if(arrayN[i]==arrayN[i-1])
            {
                count++;                    
            }
            else
            {
                count = 1;
            }
            if(count>countMax)
            {
                countMax = count;
                result = arrayN[i];
            }

        }
        Console.WriteLine();
        Console.WriteLine("There are {0} elements {1} in the array and that's the result.",countMax,result);
        */
            /*
                int[] arrayN = new int[40];
                Random rand = new Random();

                for (int i = 0; i < 40; i++)
                {
                    arrayN[i] = rand.Next(15);
                }
                foreach (int k in arrayN)
                {
                    Console.Write(" " + k);
                }
                int num=0;
                int sum = 0;
                int pos = 0;
                int count = 1;
                bool found = false;
                string inputS = Console.ReadLine();
                while (!int.TryParse(inputS, out num))
                {
                    Console.WriteLine("Invalid input! Please input N.");
                    inputS = Console.ReadLine();
                }

                for (int i = 0; i < 40; i++)
                {
                    pos = i;
                    sum = arrayN[i];
                    count = 1;
                    for(int j =i+1;j<40;j++)
                    {
                        sum += arrayN[j];
                        if (sum == num)
                        {
                            found = true;
                            j = 50;
                        }
                        else if (sum < num)
                        {

                            count++;
                        }
                        else
                        {
                            j = 50;
                            found = false;
                        }                    
                    }
                    if (found == true)
                    {
                        i = 50;
                    }


                }
                Console.WriteLine();
                Console.WriteLine("Result: ");
                for (int i =pos; i<=pos+count;i++)
                {
                    Console.Write(" " + arrayN[i]);
                }
                */
            /*
        Random rand = new Random();
        int[] myArray = new int[40];
        for (int i =0; i<40;i++)
        {
            myArray[i] = rand.Next(101);
        }
        foreach(int j in myArray)
        {
            Console.Write(" " + j);
        }
        Console.WriteLine();
        Array.Sort(myArray);
        foreach (int j in myArray)
        {
            Console.Write(" " + j);
        }
        Console.WriteLine();
        Console.WriteLine("Please input n!");
        int n = int.Parse(Console.ReadLine());
        int L = 0;
        int R = myArray.Length - 1;
        int m;
        while(L<=R)
        {
            m = (L + R) / 2;
            if(myArray[m]<n)
            {
                L = m + 1;
            }
            else if (myArray[m]>n)
            {
                R = m - 1;
            }
            else if (myArray[m]==n)
            {
                Console.WriteLine("Found! The result is {0}", m);
                L = R + 1;
            }
        }
        */
            int[] myArray = new int[1000000 - 1];
            int count = 0;
            for(int i=2;i<=1000000;i++)
            {
                myArray[i - 2] = i;
            }
           
            /*foreach (int j in myArray)
            {
                if (j != 0)
                {
                    Console.Write(" " + j);
                }
            }*/
            int p = 2;
            int indexAt = 0;
            bool limitedReach = false;
            while(!limitedReach)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    int v = myArray[i];
                    if (v % p == 0 && v != p)
                    {
                        myArray[i] = 0;
                    }
                    
                }
                do
                {
                    p = myArray[++indexAt];
                    if (indexAt >= myArray.Length-1)
                    {
                        limitedReach = true;
                        break;
                    }
                } while (p == 0);
            }
            Console.WriteLine();
            Console.WriteLine("Result:");
            foreach(int j in myArray)
            {
                if(j!=0)
                {
                    count++;
                    Console.Write(" " + j);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Result: " + count );


        }
    }
    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;
        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }
    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}

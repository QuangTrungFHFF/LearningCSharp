using System;

namespace NumberConversion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Number conversion.");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("What do u want to do?");
            Console.WriteLine("1> Convert Decimal to Binary.");
            Console.WriteLine("2> Convert Binary to Decimal.");
            Console.WriteLine("3> Convert Decimal to Hexadecimal.");
            Console.WriteLine("4> Convert Binary to Hexadecimal.");
            Console.WriteLine("5> Convert Hexadecimal to Decimal.");
            Console.WriteLine("6> Convert Hexadecimal to Binary.");
            Console.WriteLine("7> Convert Roman digits to Arabic.");
            Console.WriteLine("8> Convert Arabic to Roman.");

            string choiceS = Console.ReadLine();
            int num = 0;
            string inputK = null;
            if (int.Parse(choiceS) < 5)
            {
                Console.WriteLine("-------------------------------------------------");

                // [Marked] Input and Check a number.
                Console.WriteLine("Please enter a number!");
                string inputS = Console.ReadLine();

                while (!int.TryParse(inputS, out num))
                {
                    Console.WriteLine("Invalid input. Please try again!");
                    Console.WriteLine("Please enter a number!");
                    inputS = Console.ReadLine();
                }
                //[/Marked]
            }
            else
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Please enter a number!");
                string inputS = Console.ReadLine();
                inputK = inputS;
            }

            switch (choiceS)
            {
                // [Marked] Decimal to binary.
                case "1":
                    if (num < 0)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        string result = "";
                        int remainder;
                        while (num > 0)
                        {
                            remainder = num % 2;
                            num /= 2;
                            result = result + remainder.ToString();
                        }
                        Calculator rev = new Calculator();
                        result = rev.ReverseText(result);
                        Console.WriteLine(result);
                    }
                    break;
                // [/Marked]

                // [Marked] Binary to Decimal.
                case "2":
                    if (num < 0)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        int resultD = 0;
                        int count = 0;
                        int remainder;
                        Calculator pow = new Calculator();

                        while (num > 0)
                        {
                            remainder = num % 2;
                            if (remainder == 1)
                            {
                                resultD += pow.pow(2, count);
                            }
                            count++;
                            num /= 10;
                        }

                        Console.WriteLine(resultD);
                    }
                    break;
                // [/Marked]

                // [Marked] Decimal to Hex.
                case "3":
                    if (num < 0)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        string result = null;
                        int remainder;
                        Calculator hex = new Calculator();

                        while (num > 0)
                        {
                            remainder = num % 16;
                            num /= 16;
                            result += hex.hexTrans(remainder);
                        }
                        result = hex.ReverseText(result);
                        Console.WriteLine(result);
                    }
                    break;
                // [/Marked]

                // [Marked] Binary to Hexadecimal.
                case "4":
                    if (num < 0)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        //string inputB = num.ToString();
                        string result = null;
                        Calculator pow = new Calculator();
                        string remainder;
                        while (num > 0)
                        {
                            remainder = (num % 10000).ToString();
                            result += pow.hexTransReverseBinary(remainder);
                            num /= 10000;
                        }
                        result = pow.ReverseText(result);
                        Console.WriteLine(result);
                    }
                    break;
                // [/Marked]

                // [Marked] Hexadecimal to Decimal.
                case "5":
                    if (inputK == null)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        int count = 0;
                        int resultD = 0;
                        Calculator pow = new Calculator();
                        inputK = pow.ReverseText(inputK);

                        foreach (char c in inputK)
                        {
                            resultD += pow.hexTransReverse(c) * pow.pow(16, count);
                            count++;
                        }
                        Console.WriteLine(resultD);
                    }
                    break;
                // [/Marked]

                // [Marked] Hexadecimal to Binary.
                case "6":
                    if (inputK == null)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        string result = null;
                        Calculator pow = new Calculator();
                        //inputK = pow.ReverseText(inputK);

                        foreach (char c in inputK)
                        {
                            result += pow.hexTransReverseBinary(c);
                        }
                        Console.WriteLine(result);
                    }
                    break;
                // [/Marked]

                // [Marked] Roman digits to Arabic.
                case "7":
                    if (inputK == null)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        int result = 0;
                        int saveNum = 0;
                        int preNum = 0;
                        Calculator trans = new Calculator();
                        //inputK = trans.ReverseText(inputK);
                        int length = inputK.Length - 1;
                        for (int i = length; i >= 0; i--)
                        {
                            preNum = saveNum;
                            saveNum = trans.Roman_Parse(inputK[i].ToString());

                            if (saveNum >= preNum)
                            {
                                result += saveNum;
                            }
                            else
                            {
                                result -= saveNum;
                            }
                        }

                        Console.WriteLine(result);
                    }
                    break;
                // [/Marked]

                // [Marked] Arabic to Roman.
                case "8":
                    if (inputK == null)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        int inNum = int.Parse(inputK);

                        string result = null;

                        Calculator trans = new Calculator();
                        if (inNum > 3999)
                        {
                            Console.WriteLine("This number is too big");
                        }
                        else
                        {
                            result += trans.Ara_Parse(inNum);
                        }

                        Console.WriteLine(result);
                    }
                    break;
                    // [/Marked]
            }
        }
    }
}
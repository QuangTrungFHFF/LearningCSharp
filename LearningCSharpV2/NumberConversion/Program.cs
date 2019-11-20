using System;

namespace NumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number conversion.");
            Console.WriteLine("-------------------------------------------------");            
            Console.WriteLine("What do u want to do?");
            Console.WriteLine("1> Convert Decimal to Binary.");
            Console.WriteLine("2> Convert Binary to Decimal.");
            Console.WriteLine("3> Convert Decimal to Hexadecimal.");
            Console.WriteLine("4> Convert Hexadecimal to Decimal.");
            
            string choiceS = Console.ReadLine();
            int num=0;
            string inputK = null;
            if (int.Parse(choiceS)<4)
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
                Console.WriteLine("Please enter a hex number!");
                string inputS = Console.ReadLine();
                inputK = inputS;
            }



            switch (choiceS)
            {

             // [Marked] Decimal to binary.
                case "1":
                    if (num<0)
                    {
                        Console.WriteLine("Invalid number to convert.");
                    }
                    else
                    {
                        string result = "";
                        int remainder;
                        while (num>0)
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

                // [Marked] Hexadecimal to Decimal.
                case "4":
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
                        
                        foreach(char c in inputK)
                        {
                            resultD += pow.hexTransReverse(c)*pow.pow(16,count);
                            count++;
                        }        
                        Console.WriteLine(resultD);
                    }
                    break;
                    // [/Marked]
            }



        }
    }
}

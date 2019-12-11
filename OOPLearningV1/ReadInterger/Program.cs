using System;
using System.Collections.Generic;

namespace ReadInterger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int min = 0;
            int num;
            var numberList = new List<int>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Please enter a number!");
                    num = ReadNumber(min, 100);
                    numberList.Add(num);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input is not an integer number!" + ex.Message);                
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Input element mus be bigger then previous elements!");
            }
            foreach (int j in numberList)
            {
                Console.WriteLine("");
                Console.Write(" " + j);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < start || n > end)
            {
                throw new ArgumentOutOfRangeException("Number out of range!");
            }
            else
            {
                return n;
            }
        }
    }
}
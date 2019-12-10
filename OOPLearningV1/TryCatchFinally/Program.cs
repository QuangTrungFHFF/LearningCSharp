// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TryCatchFinally
{
    using System;

    internal class Program
    {
        /// <summary>
        /// Get the square root of a number.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double Squr(double num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot get the square root of negative number");
            }
            else
            {
                return Math.Sqrt(num);
            }
        }

        private static void Main(string[] args)
        {
            double number;
            double result;
            Console.WriteLine("Please enter a number!");
            try
            {
                number = int.Parse(Console.ReadLine());
                result = Squr(number);
                Console.WriteLine("Result is: {0}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format!");
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TryCatchFinally
{
    using System;

    /// <summary>
    /// Write a method ReadNumber(int start, int end) that reads an integer from the console in the range [start…end].
    /// In case the input integer is not valid or it is not in the required range throw appropriate exception.
    /// Using this method, write a program that takes 10 integers a1, a2, …, a10 from smallest to biggest.
    /// </summary>
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
using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            double result;
            Console.WriteLine("Please enter a number!");
           try
            {
                number = int.Parse(Console.ReadLine());
                if(number>=0)
                {
                    result = Math.Sqrt(number);
                    Console.WriteLine("Result is: {0}", result);
                }
                else
                {
                    Console.WriteLine("{0} is  <0 ",number);
                }
                
            }
            catch(FormatException)
            {
                Console.WriteLine("Wrong format!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}

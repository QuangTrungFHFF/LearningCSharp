using CreatingAndUsingObjects;
using System;

namespace CountCat
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Console.WriteLine("Let's count the cat.");
            Cat someCat = new Cat();
            someCat.SayMiau();
            Sequence.NextValue();

            Console.WriteLine("The color of cat {0} is {1}.",someCat.Name, someCat.Color);
            Cat someCat2 = new Cat("Johnny", "brown");
            someCat2.SayMiau();
            Console.WriteLine("The color of cat {0} is {1}.",someCat2.Name, someCat2.Color);
            int catNumber = Sequence.NextValue();
            Console.WriteLine("There are {0} cat(s).", catNumber);
        }
    }
}
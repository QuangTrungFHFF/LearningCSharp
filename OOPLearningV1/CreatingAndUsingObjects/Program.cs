using System;
using System.Collections.Generic;
using OOPLearningV1;

namespace CreatingAndUsingObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            var catList = new List<Cat>();
            string catName = "Unnamed";
            string catColor = "Unknown";
            Console.WriteLine("Hello World!");
            for(int i=0; i<10; i++)
            {
                catName = "Cat" + Sequence.NextValue();
                RandomValues ran = new RandomValues();
                catColor = ran.GetRandomColor();
                catList.Add(new Cat(catName,catColor));
                catList[i].SayMiau();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearningV1
{
    public class RandomValues
    {
        public int GetRandomInt(int minRange, int maxRange)
        {
            Random ran = new Random();
            return ran.Next(minRange, maxRange);
        }
        
        public string GetRandomColor()
        {
            List<string> colour = new List<string> {"red","yellow","gray","blue","brown","black","rainbow","purple","green","orange","pink","white","silver","golden"};
            return colour[GetRandomInt(0, colour.Count)]; 
        }

    }
}

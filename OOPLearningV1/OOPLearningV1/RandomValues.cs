using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearningV1
{
    class RandomValues
    {
        public int GetRandomInt(int minRange, int maxRange)
        {
            Random ran = new Random();
            return ran.Next(minRange, maxRange);
        }
    }
}

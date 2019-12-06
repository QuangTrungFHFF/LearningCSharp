using System;
using System.Collections.Generic;
using System.Text;

namespace OOPLearningV1
{
    public class Calculator
    {
        public double GetHypotenuse(double sideA, double sideB)
        {
            double hypotenuse = Math.Sqrt((Math.Pow(sideA,2)+Math.Pow(sideB,2)));
            return hypotenuse; 
        }
    }
}

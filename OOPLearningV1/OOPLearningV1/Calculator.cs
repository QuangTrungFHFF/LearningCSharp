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

        public double GetAreaFromThreeSide(double sideA, double sideB, double sideC)
        {
            double average = (sideA + sideB + sideC) / 2;
            double result = Math.Sqrt(average*(average- sideA) * (average-sideB)*(average-sideC));
            return result;
        }

        public double GetAreaFromSideAndAltitude(double sideA, double altitude)
        {            
            double result = (sideA*altitude)/2;
            return result;
        }

        public double GetAreaFromSideAndAngle(double sideA, double sideB, double angle)
        {
            double result = (sideA * sideB*Math.Sin((angle*Math.PI)/180)) / 2;
            return result;
        }
    }
}

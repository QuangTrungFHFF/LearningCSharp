using System;
using System.Numerics;

namespace NumberConversionV2
{
    public class Converter
    {
        //Reverse the number
        public int ReverseNumber(int num)
        {
            int result = 0;
            int remainder = 0;
            int digit_count = this.CountDigits(num);
            int digit_pos = digit_count - 1; //Get the position of digit

            for (int i = 0; i < digit_count; i++)
            {
                remainder = num % 10;
                num /= 10;
                result += remainder * (int)Math.Pow(10, digit_pos); //Get the most right digit and multiply it with 10^digit pos (10^3 =1000). Then add it to get the result.
                digit_pos--;
            }
            return result;
        }

        //Get number of digits
        public int CountDigits(int num)
        {
            if (num <= 9)
            {
                return 1;
            }
            else
            {
                int result = (int)Math.Floor(Math.Log10(num) + 1);
                return result;
            }
        }

        //Get input array of digits
        public int[] GetDigitArray(int num)
        {
            int digit_count = this.CountDigits(num);
            int[] digitArray = new int[10];
            for (int i = 0; i < digit_count; i++)
            {
                digitArray[i] = num % 10;
                num /= 10;
            }
            return digitArray;
        }

        //Get sum of 2 digit Arrays
        public int[] GetSumOfDigitArray(int[] num1, int[] num2)
        {
            //Transform original array to new array
            int[] firstArray = new int[10000];
            for (int i = 0; i < num1.Length; i++)
            {
                firstArray[i] = num1[i];
            }
            int[] secondArray = new int[10000];
            for (int i = 0; i < num2.Length; i++)
            {
                secondArray[i] = num2[i];
            }

            int result_max_length = (num1.Length >= num2.Length) ? (num1.Length + 1) : (num2.Length + 1);

            int[] sumResult = new int[result_max_length];
            int sum = 0;
            int remainder = 0;
            for (int i = 0; i < (result_max_length - 1); i++)
            {
                sum = firstArray[i] + secondArray[i] + remainder;
                if (sum < 10)
                {
                    sumResult[i] = sum;
                    remainder = 0;
                }
                else
                {
                    sumResult[i] = sum % 10;
                    sum /= 10;
                    remainder = sum % 10;
                }
            }
            if (remainder > 0)
            {
                sumResult[(result_max_length - 1)] = remainder;
            }
            return sumResult;
        }

        //Get input string and Convert to digit Array
        public int[] ParseStringToDigitArray(string inputS)
        {
            char[] charArray = inputS.ToCharArray();
            int arrayLength = charArray.Length;
            int[] resultArray = new int[arrayLength];
            for (int i = 0, j = arrayLength - 1; i < arrayLength; i++, j--)
            {
                resultArray[i] = (int)Char.GetNumericValue(charArray[j]);
            }
            return resultArray;
        }

        //Get element with the biggest value in an interger Array
        public int GetMaxElement(int[] numArray)
        {
            int maxElement = numArray[0];
            for (int i = 1; i < numArray.Length; i++)
            {
                if (maxElement <= numArray[i])
                {
                    maxElement = numArray[i];
                }
            }
            return maxElement;
        }

        //Sort Array using GetMaxElement method
        public int[] SortArray(int[] numArray)
        {
            int arrayLength = numArray.Length;
            int[] result = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                result[i] = GetMaxElementInRange(numArray, i, arrayLength);
            }
            foreach (int j in result)
            {
                Console.Write(j + " ");
            }
            return result;
        }

        //Get max element of an array in a custom range
        public int GetMaxElementInRange(int[] numArray, int rangeMin, int rangeMax)
        {
            int[] numArrayMod = new int[(rangeMax - rangeMin + 1)];
            int currentMax = numArray[rangeMin];
            for (int i = (rangeMin + 1); i < rangeMax; i++)
            {
                if (currentMax < numArray[i]) // Swap position
                {
                    currentMax = numArray[i];
                    numArray[i] = numArray[rangeMin];
                    numArray[rangeMin] = currentMax;
                }
            }
            return numArray[rangeMin];
        }

        public BigInteger result = new BigInteger();
        
        public void GetFactorial(int n)
        {
            //BigInteger result = new BigInteger();
            result = 1;
            for (int i = 1; i < n; i++)
            {
                result *= (i + 1);
            }
            Console.WriteLine("Factorial of {0} is: {1}", n, result);
            return;
        }
    }
}
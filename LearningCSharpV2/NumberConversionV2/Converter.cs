using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConversionV2
{
    class Converter
    {
        //Reverse the number
        public int ReverseNumber(int num)
        {
            int result = 0;
            int remainder = 0;
            int digit_count = this.CountDigits(num);
            int digit_pos = digit_count-1; //Get the position of digit      


            for(int i=0;i<digit_count;i++)
            {
                remainder = num % 10;
                num /= 10;                
                result += remainder * (int)Math.Pow(10,digit_pos); //Get the most right digit and multiply it with 10^digit pos (10^3 =1000). Then add it to get the result.
                digit_pos--;
            }
            return result;

        }



        //Get number of digits
        public int CountDigits(int num)
        {
            if (num<=9)
            {
                return 1;
            }
            else
            {
                int result = (int)Math.Floor(Math.Log10(num)+1);
                return result;
            }

        }
    }
}

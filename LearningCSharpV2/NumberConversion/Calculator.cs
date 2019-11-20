using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConversion
{
    public class Calculator
    {
        public string ReverseText(string text)
        {
            if(text == null)
            {
                return null;
            }
            else
            {
                char[] array = text.ToCharArray();
                Array.Reverse(array);
                return new String(array);
            }
        }

        public int pow(int num1, int num2)
        {
            int result = num1;
            if (num2 ==0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i < num2; i++)
                {
                    result = result * num1;
                }
                return result;
            }
            
        }

        public string hexTrans(int num)
        {
            string[] arrayS = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string result = "error";
            if (num<0)
            {
                return result;
            }
            else
            {
                result = arrayS[num];
                return result;
            }
        }

        public int hexTransReverse(char c)
        {
            string[] arrayS = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string result = c.ToString();
            string sS = null;
            int resultD=0;
            for (int i =0; i<16;i++)
            {
                sS = arrayS[i];
                if (result == sS)
                {
                    resultD = i;
                    break;
                }
            }
            return resultD;
            
        }
    }
}

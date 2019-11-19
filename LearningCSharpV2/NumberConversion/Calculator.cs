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
    }
}

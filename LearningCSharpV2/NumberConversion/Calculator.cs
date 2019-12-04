using System;
using System.Collections.Generic;

namespace NumberConversion
{
    public class Calculator
    {
        public string ReverseText(string text)
        {
            if (text == null)
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
            if (num2 == 0)
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
            if (num < 0)
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
            int resultD = 0;
            for (int i = 0; i < 16; i++)
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

        public string hexTransReverseBinary(char c)
        {
            string[] arrayS = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string[] arrayB = new string[16] { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            string result = c.ToString();
            string sS = null;
            string resultD = null;
            for (int i = 0; i < 16; i++)
            {
                sS = arrayS[i];
                if (result == sS)
                {
                    resultD = arrayB[i];
                    break;
                }
            }
            return resultD;
        }

        public string hexTransReverseBinary(string c)
        {
            string[] arrayS = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string[] arrayB = new string[16] { "0", "1", "10", "11", "100", "101", "110", "111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            string result = c.ToString();
            string sS = null;
            string resultD = null;
            for (int i = 0; i < 16; i++)
            {
                sS = arrayB[i];
                if (result == sS)
                {
                    resultD = arrayS[i];
                    break;
                }
            }
            return resultD;
        }

        public int Roman_Parse(string c)
        {
            int result = 0;
            c = c.ToUpper();

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("M", 1000);
            dic.Add("C", 100);
            dic.Add("L", 50);
            dic.Add("X", 10);
            dic.Add("V", 5);
            dic.Add("I", 1);

            if (dic.ContainsKey(c))
            {
                result = dic[c];
            }
            return result;
        }

        public string Ara_Parse(int num)
        {
            string result = "";

            string[] thou = { "", "M", "MM", "MMM" };
            string[] hun = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            result += thou[(int)(num / 1000) % 10];
            result += hun[(int)(num / 100) % 10];
            result += ten[(int)(num / 10) % 10];
            result += ones[num % 10];
            return result;
        }
    }
}
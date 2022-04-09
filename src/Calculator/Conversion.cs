using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public class Conversion
    {
        private char[] numList = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        
        public string Convert_from_to(string number, string fromBase, string toBase)
        {
            int from = int.Parse(fromBase);
            int to = int.Parse(toBase);

            number = number.ToUpper();

            if (from == to)
                return number;

            int number10Base = 0;
            if (from != 10)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    char temp = number[number.Length - i - 1];

                    int num = getIndexOf(numList, temp, from);
                    if (num != -1)
                    {
                        number10Base += num * Convert.ToInt32(Math.Pow(Convert.ToDouble(from), Convert.ToDouble(i)));
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            else
            {
                number10Base = int.Parse(number);
            }

            if (to != 10)
            {
                Stack<char> final = new Stack<char>();
                while (number10Base != 0)
                {
                    final.Push(numList[number10Base % to]);
                    number10Base /= to;
                }
                string res = String.Empty;
                foreach (char c in final)
                {
                    res += c;
                }
                return res;
            }
            else
            {
                return number10Base.ToString();
            }
        }
        private static int getIndexOf(char[] array, char find, int limit)
        {
            int i;
            for (i = 0; i < array.Length && i < limit; i++)
            {
                if (array[i] == find)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}

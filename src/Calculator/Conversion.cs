/**
 *@file Conversion.cs
 *@brief Třída pro převod čísel mezi soustavami
 *
 * 
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public class Conversion
    {
        private char[] numList = new char[] {   '0', '1', '2', '3', '4', '5',
                                                '6', '7', '8', '9', 'A', 'B', 
                                                'C', 'D', 'E', 'F', 'G', 'H', 
                                                'I', 'J', 'K', 'L', 'M', 'N', 
                                                'O', 'P', 'Q', 'R', 'S', 'T', 
                                                'U', 'V', 'W', 'X', 'Y', 'Z' }; /** Pole znaků, které jsou použity s různých soustavách*/
        
        public string Convert_from_to(string number, string fromBase, string toBase)
        {
            int from = int.Parse(fromBase);
            int to = int.Parse(toBase);
            if(from > 36 || to > 36)
            {
                return null;
            }

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
                        try
                        {
                            number10Base += num * Convert.ToInt32(Math.Pow(Convert.ToDouble(from), Convert.ToDouble(i)));
                        }
                        catch
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }

                }
            }
            else
            {
                if(int.TryParse(number, out number10Base) == false)
                {
                    return null;
                }
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

        /**
         * @brief Funkce na získání pozice prvku v poli
         * @param array Pole znaků, ve kterém chceme najít shodný znak
         * @param find Znak, jehož pozici chceme najít
         * @param limit Omezení procházené oblasti
         * 
         * @return V případě nalezení vrací index prvku, v opačném případě vrací -1
         */
        private static int getIndexOf(char[] array, char find, int limit)
        {
            int i; /** Index aktuálně procházeného prvku */
            for (i = 0; i < array.Length && i < limit; i++) /** Cyklus pro iteraci polem */
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

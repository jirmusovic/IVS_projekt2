/**
 *@file Conversion.cs
 *@class Conversion
 *
 *@brief Třída pro převod čísel mezi soustavami
 *
 *@date 28-04-2022
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

        /**
         * @brief Funkce pro převod čísla mezi soustavami
         * 
         * @param number Číslo pro převod
         * @param fromBase Báze, ze které převádíme číslo 
         * @param toBase Báze, do které převádíme číslo 
         * 
         * @return Číslo reprezentované v nové bázi, null v případě chyby
         */
        public string Convert_from_to(string number, string fromBase, string toBase)
        {
            int from; /**Číselná reprezentace báze, ze které převádíme číslo */
            int to; /**Číselná reprezentace báze, do které převádíme číslo */

            if(int.TryParse(fromBase, out from) == false)
            {
                return null;
            }
            if (int.TryParse(toBase, out to) == false)
            {
                return null;
            }
            if (from > 36 || to > 36) //Ověření korektního vstupu
            {
                return null;
            }

            number = number.ToUpper(); //Převod všech znaků na UpperCase

            if (from == to) //V případě shodnosti bází se převod neprovede
                return number;

            int number10Base = 0; /**Číslo reprezentované v desítkové bázi*/
            if (from != 10) 
            {
                for (int i = 0; i < number.Length; i++)//Cyklus pro převod čísla do desítkové báze
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
                Stack<char> final = new Stack<char>(); /**Výsledná hodnota čísla v požadované bázi*/
                while (number10Base != 0) //Cyklus pro převod čísla do požadované báze
                {
                    final.Push(numList[number10Base % to]);
                    number10Base /= to;
                }
                string res = String.Empty; /**Výsledné číslo reprezentované jako textový řetězec*/
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
/*** Konec souboru Conversion.cs ***/

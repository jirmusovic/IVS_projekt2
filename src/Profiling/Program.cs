using Calc;
using System;
using System.Diagnostics;

namespace Profiling
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = String.Empty; /**Vysledek vyhodnoceni výběrové směrodatné odchylky*/
            string input = String.Empty; /**Proměnná pro uchování dat zadaných uživatelem*/
            string line; /**Proměnná pro uchování aktuálně přečteného řádku*/

            while ((line = Console.ReadLine()) != null) //Čtení všech řádků ze vstupu
            {
                if (input != String.Empty)
                {
                    input += ' ';
                }
                input += line.Trim('\n');
            }
            if (input != String.Empty)
            {
                Deviation dev = new Deviation();

                res = dev.StdDeviation(input);
                if (res != null) //Ověření správného výsledku operace
                    Console.WriteLine(res);
                else
                    Console.WriteLine("Chyba vstupu!");
            }
        }
    }
}

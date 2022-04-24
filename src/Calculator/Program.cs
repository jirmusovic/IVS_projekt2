/**
 * @file Program.cs
 * @class Program
 * 
 * @brief Vstupní bod programu
 */

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
        
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string input = String.Empty; /**Promìnná pro uchování dat zadaných uživatelem*/
            string line; /**Promìnná pro uchování aktuálnì pøeèteného øádku*/
            string res = String.Empty; /**Vysledek vyhodnoceni výbìrové smìrodatné odchylky*/
            Task t = Task.Run(() =>  //Zaèátek operace, která èeká na uživatelský vstup
            {
                while ((line = Console.ReadLine()) != null) //Ètení všech øádkù ze vstupu
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
                    if (res != null) //Ovìøení správného výsledku operace
                        Console.WriteLine(res);
                    else
                        Console.WriteLine("Chyba vstupu!");
                }
            });
            TimeSpan ts = TimeSpan.FromMilliseconds(500);
            if (!t.Wait(ts))
                Console.WriteLine("Èas na zadání dat pro výbìrovou smìrodatnou odchylku vypršel!");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(res)); //Spuštìní formuláøe
        }
    }
}

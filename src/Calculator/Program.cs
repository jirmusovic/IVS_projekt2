/**
 * @file Program.cs
 * @class Program
 * 
 * @brief Vstupn� bod programu
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
            string input = String.Empty; /**Prom�nn� pro uchov�n� dat zadan�ch u�ivatelem*/
            string line; /**Prom�nn� pro uchov�n� aktu�ln� p�e�ten�ho ��dku*/
            string res = String.Empty; /**Vysledek vyhodnoceni v�b�rov� sm�rodatn� odchylky*/
            Task t = Task.Run(() =>  //Za��tek operace, kter� �ek� na u�ivatelsk� vstup
            {
                while ((line = Console.ReadLine()) != null) //�ten� v�ech ��dk� ze vstupu
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
                    if (res != null) //Ov��en� spr�vn�ho v�sledku operace
                        Console.WriteLine(res);
                    else
                        Console.WriteLine("Chyba vstupu!");
                }
            });
            TimeSpan ts = TimeSpan.FromMilliseconds(500);
            if (!t.Wait(ts))
                Console.WriteLine("�as na zad�n� dat pro v�b�rovou sm�rodatnou odchylku vypr�el!");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(res)); //Spu�t�n� formul��e
        }
    }
}

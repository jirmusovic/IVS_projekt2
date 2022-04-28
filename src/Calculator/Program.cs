/**
 * @file Program.cs
 * @class Program
 * 
 * @brief Vstupní bod programu
 * 
 * @date 28-04-2022
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); //Spuštění formuláře
        }
    }
}
/*** Konec souboru Program.cs ***/


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
            string input = String.Empty;
            string line;
            string tmp = String.Empty;
            Task t = Task.Run(() =>
            {
                while ((line = Console.ReadLine()) != null)
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

                    tmp = dev.StdDeviation(input);
                    if (tmp != null)
                        Console.WriteLine(tmp);
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
            Application.Run(new Form1(tmp));
        }
    }
}

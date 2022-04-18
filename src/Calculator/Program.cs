using System;
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
            while((line = Console.ReadLine()) != null)
            {
                if (input != String.Empty)
                {
                    input += ' ';
                }
                input += line.Trim('\n');
                
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(input));
        }
    }
}

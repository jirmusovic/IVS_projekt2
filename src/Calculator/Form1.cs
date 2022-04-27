/**
 * @file Form1.cs
 * 
 * @brief Funkce pro interakci s grafickým rozhraním
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calc
{
    enum Window { CALCULATOR, CONVERTOR, DEVIATION } //Očíslování typu oken

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Switch_active_window(int window)
        {
            DeviationGroupBox.Visible = (window == (int)Window.DEVIATION ? true : false);
            ConverterGroupBox.Visible = (window == (int)Window.CONVERTOR ? true : false); 
            CalculatorGroupBox.Visible = (window == (int)Window.CALCULATOR ? true : false); 

        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            if(CalculatorGroupBox.Visible == true) 
                return;
            else
                Switch_active_window((int)Window.CALCULATOR);
            
        }

        private void Converter_Click(object sender, EventArgs e)
        {
            if (ConverterGroupBox.Visible == true) 
                return;
            else
                Switch_active_window((int)Window.CONVERTOR); 
        }

        private void Deviation_Click(object sender, EventArgs e)
        {
            if (DeviationGroupBox.Visible == true)
                return;
            else
                Switch_active_window((int)Window.DEVIATION);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            InputCalc.Text += clicked.Text;
        }

        private void FileChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = ofd.FileName;
                var stream = ofd.OpenFile();

                using (StreamReader reader = new StreamReader(stream))
                {
                    InDev.Text = reader.ReadToEnd();
                }

            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if(InDev.Text != String.Empty)
            {
                Deviation dev = new Deviation();
                string tmp = dev.StdDeviation(InDev.Text);
                if (tmp != null)
                    OutDev.Text = tmp;
                else
                    OutDev.Text = "Chyba vstupu!";
            }
        }

        private void Eq_Click(object sender, EventArgs e)
        {
            Evaluation eval = new Evaluation();
            if(InputCalc.Text != String.Empty)
            {
                string res = eval.Evaluate(InputCalc.Text);
                if (res == null)
                    OutputCalc.Text = "ERROR";
                else
                    OutputCalc.Text = res;
            }
            
            
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            InputCalc.Text = String.Empty;
            OutputCalc.Text = String.Empty;
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (InputCalc.Text.Length > 0) 
                InputCalc.Text = InputCalc.Text.Substring(0, InputCalc.Text.Length - 1);
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (InputCalc.Text.Length > 0 && InputCalc.Text != "-")
            {
                char tmp = InputCalc.Text[InputCalc.Text.Length - 1];
                if (tmp == '+' || tmp == '-' || tmp == '*' || tmp == '/' || tmp == '/')
                {
                    InputCalc.Text = InputCalc.Text.Substring(0, InputCalc.Text.Length - 1);
                }
                if (clicked.Text[0] == 'X')
                    InputCalc.Text += '*';
                else
                    InputCalc.Text += clicked.Text;
            }
            if (InputCalc.Text.Length == 0 && clicked.Text == "-")
                InputCalc.Text += "-";
        }

        private void funkc_click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (InputCalc.Text.Length > 0)
            {
                char tmp = InputCalc.Text[InputCalc.Text.Length - 1];
                if (!(tmp == '+' || tmp == '-' || tmp == '*' || tmp == '/' || tmp == '(' || tmp == '/'))
                {
                    InputCalc.Text += '*';
                }
            }
            InputCalc.Text += clicked.Text + '(';
        }

        private void Exp10_Click(object sender, EventArgs e)
        {
            if (InputCalc.Text.Length > 0)
            {
                char tmp = InputCalc.Text[InputCalc.Text.Length - 1];
                if (tmp == '+' || tmp == '-' || tmp == '*' || tmp == '/' || tmp == '(' || tmp == '/')
                {
                    InputCalc.Text = InputCalc.Text.Substring(0, InputCalc.Text.Length - 1);
                }
              
                InputCalc.Text += "*10^";
            }
        }

        private void Exponent_Click(object sender, EventArgs e)
        {
            if (InputCalc.Text.Length > 0)
            {
                char tmp = InputCalc.Text[InputCalc.Text.Length - 1];
                if (tmp == '+' || tmp == '-' || tmp == '*' || tmp == '/' || tmp == '(' || tmp == '/')
                {
                    InputCalc.Text = InputCalc.Text.Substring(0, InputCalc.Text.Length - 1);
                }

                InputCalc.Text += '^';
            }
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            Evaluation eval = new Evaluation();
            if (InputCalc.Text.Length >= 4 && eval.RemoveNotNecessaryBrackets(InputCalc.Text.TrimStart('-')) == InputCalc.Text.Substring(2, InputCalc.Text.Length - 3))
                InputCalc.Text = InputCalc.Text.Substring(2, InputCalc.Text.Length - 3);
            else if(InputCalc.Text.Length > 0)
                InputCalc.Text = "-(" + InputCalc.Text + ")";
        }

        private void NRoot_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (InputCalc.Text.Length > 0)
            {
                char tmp = InputCalc.Text[InputCalc.Text.Length - 1];
                if (!(tmp == '+' || tmp == '-' || tmp == '*' || tmp == '/' || tmp == '(' || tmp == '/'))
                {
                    InputCalc.Text += '*';
                }
            }
            InputCalc.Text += "f(";
        }

        private void NRoot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && InputCalc.Text.Length > 2 && InputCalc.Text[InputCalc.Text.Length - 1] != ',') 
                InputCalc.Text += ",";
        }
    }
}

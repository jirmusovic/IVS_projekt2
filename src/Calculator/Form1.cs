using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        private string deviation_input;
        public Form1(string input)
        {
            deviation_input = input;
            InitializeComponent();
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            if(CalculatorGroupBox.Visible == true) return;
            DeviationGroupBox.Visible = false;
            ConverterGroupBox.Visible = false;
            CalculatorGroupBox.Visible = true;
            
        }

        private void Converter_Click(object sender, EventArgs e)
        {
            if (ConverterGroupBox.Visible == true) return;
            DeviationGroupBox.Visible = false;
            CalculatorGroupBox.Visible = false;
            ConverterGroupBox.Visible = true;
        }

        private void Deviation_Click(object sender, EventArgs e)
        {
            if (DeviationGroupBox.Visible == true) return;
            ConverterGroupBox.Visible = false;
            CalculatorGroupBox.Visible = false;
            DeviationGroupBox.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

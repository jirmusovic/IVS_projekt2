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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (deviation_input != String.Empty)
            {
                textBox1.Text = "INPUT GIVEN";
                //prepnuti okna na zalozku smerodatne odchylky
            }
            else
            {
                var conv = new Conversion();
                textBox1.Text = conv.Convert_from_to("256", "10", "8");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}

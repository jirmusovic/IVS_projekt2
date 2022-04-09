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

             Deviation dev = new Deviation();
             textBox1.Text = dev.StdDeviation(deviation_input);
                //textBox1.Text = deviation_input;
                //prepnuti okna na zalozku smerodatne odchylky

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}

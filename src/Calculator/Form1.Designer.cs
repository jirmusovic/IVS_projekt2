
namespace Calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calculator = new System.Windows.Forms.Button();
            this.Converter = new System.Windows.Forms.Button();
            this.Deviation = new System.Windows.Forms.Button();
            this.CalculatorGroupBox = new System.Windows.Forms.GroupBox();
            this.InputCalc = new System.Windows.Forms.RichTextBox();
            this.OutputCalc = new System.Windows.Forms.RichTextBox();
            this.Exp10 = new System.Windows.Forms.Button();
            this.RightBracket = new System.Windows.Forms.Button();
            this.LeftBracket = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Fact = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Pi = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Eq = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.PlusMinus = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.ConverterGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutConvert = new System.Windows.Forms.RichTextBox();
            this.InConvert = new System.Windows.Forms.RichTextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DeviationGroupBox = new System.Windows.Forms.GroupBox();
            this.LabelFileInput = new System.Windows.Forms.Label();
            this.LabelOwnInput = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.FileChoose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InDev = new System.Windows.Forms.RichTextBox();
            this.OutDev = new System.Windows.Forms.RichTextBox();
            this.CalculatorGroupBox.SuspendLayout();
            this.ConverterGroupBox.SuspendLayout();
            this.DeviationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculator.Location = new System.Drawing.Point(125, 96);
            this.Calculator.Margin = new System.Windows.Forms.Padding(4);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(35, 109);
            this.Calculator.TabIndex = 26;
            this.Calculator.Text = "Calculator";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // Converter
            // 
            this.Converter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Converter.Location = new System.Drawing.Point(125, 213);
            this.Converter.Margin = new System.Windows.Forms.Padding(4);
            this.Converter.Name = "Converter";
            this.Converter.Size = new System.Drawing.Size(35, 109);
            this.Converter.TabIndex = 27;
            this.Converter.Text = "Converter";
            this.Converter.UseVisualStyleBackColor = true;
            this.Converter.Click += new System.EventHandler(this.Converter_Click);
            // 
            // Deviation
            // 
            this.Deviation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deviation.Location = new System.Drawing.Point(125, 330);
            this.Deviation.Margin = new System.Windows.Forms.Padding(4);
            this.Deviation.Name = "Deviation";
            this.Deviation.Size = new System.Drawing.Size(35, 109);
            this.Deviation.TabIndex = 28;
            this.Deviation.Text = "Deviation";
            this.Deviation.UseVisualStyleBackColor = true;
            this.Deviation.Click += new System.EventHandler(this.Deviation_Click);
            // 
            // CalculatorGroupBox
            // 
            this.CalculatorGroupBox.Controls.Add(this.InputCalc);
            this.CalculatorGroupBox.Controls.Add(this.OutputCalc);
            this.CalculatorGroupBox.Controls.Add(this.Exp10);
            this.CalculatorGroupBox.Controls.Add(this.RightBracket);
            this.CalculatorGroupBox.Controls.Add(this.LeftBracket);
            this.CalculatorGroupBox.Controls.Add(this.Exponent);
            this.CalculatorGroupBox.Controls.Add(this.Sqrt);
            this.CalculatorGroupBox.Controls.Add(this.Fact);
            this.CalculatorGroupBox.Controls.Add(this.Tan);
            this.CalculatorGroupBox.Controls.Add(this.Cos);
            this.CalculatorGroupBox.Controls.Add(this.Sin);
            this.CalculatorGroupBox.Controls.Add(this.Pi);
            this.CalculatorGroupBox.Controls.Add(this.Log);
            this.CalculatorGroupBox.Controls.Add(this.E);
            this.CalculatorGroupBox.Controls.Add(this.Backspace);
            this.CalculatorGroupBox.Controls.Add(this.Comma);
            this.CalculatorGroupBox.Controls.Add(this.Num0);
            this.CalculatorGroupBox.Controls.Add(this.Num1);
            this.CalculatorGroupBox.Controls.Add(this.Num4);
            this.CalculatorGroupBox.Controls.Add(this.Num7);
            this.CalculatorGroupBox.Controls.Add(this.Num2);
            this.CalculatorGroupBox.Controls.Add(this.Num5);
            this.CalculatorGroupBox.Controls.Add(this.Num8);
            this.CalculatorGroupBox.Controls.Add(this.Num3);
            this.CalculatorGroupBox.Controls.Add(this.Num6);
            this.CalculatorGroupBox.Controls.Add(this.Num9);
            this.CalculatorGroupBox.Controls.Add(this.Mul);
            this.CalculatorGroupBox.Controls.Add(this.Sub);
            this.CalculatorGroupBox.Controls.Add(this.Add);
            this.CalculatorGroupBox.Controls.Add(this.Eq);
            this.CalculatorGroupBox.Controls.Add(this.Div);
            this.CalculatorGroupBox.Controls.Add(this.PlusMinus);
            this.CalculatorGroupBox.Controls.Add(this.ClearAll);
            this.CalculatorGroupBox.Location = new System.Drawing.Point(167, 72);
            this.CalculatorGroupBox.Name = "CalculatorGroupBox";
            this.CalculatorGroupBox.Size = new System.Drawing.Size(592, 381);
            this.CalculatorGroupBox.TabIndex = 42;
            this.CalculatorGroupBox.TabStop = false;
            this.CalculatorGroupBox.Text = "Calculator";
            // 
            // InputCalc
            // 
            this.InputCalc.BackColor = System.Drawing.Color.Aquamarine;
            this.InputCalc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputCalc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.InputCalc.Location = new System.Drawing.Point(58, 16);
            this.InputCalc.Name = "InputCalc";
            this.InputCalc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InputCalc.Size = new System.Drawing.Size(437, 58);
            this.InputCalc.TabIndex = 75;
            this.InputCalc.Text = "";
            // 
            // OutputCalc
            // 
            this.OutputCalc.BackColor = System.Drawing.Color.Aquamarine;
            this.OutputCalc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputCalc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OutputCalc.Location = new System.Drawing.Point(58, 73);
            this.OutputCalc.Name = "OutputCalc";
            this.OutputCalc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutputCalc.Size = new System.Drawing.Size(437, 58);
            this.OutputCalc.TabIndex = 43;
            this.OutputCalc.Text = "";
            this.OutputCalc.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // Exp10
            // 
            this.Exp10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Exp10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exp10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exp10.Location = new System.Drawing.Point(435, 321);
            this.Exp10.Margin = new System.Windows.Forms.Padding(4);
            this.Exp10.Name = "Exp10";
            this.Exp10.Size = new System.Drawing.Size(60, 38);
            this.Exp10.TabIndex = 74;
            this.Exp10.Text = "Exp";
            this.Exp10.UseVisualStyleBackColor = false;
            // 
            // RightBracket
            // 
            this.RightBracket.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.RightBracket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightBracket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RightBracket.Location = new System.Drawing.Point(367, 321);
            this.RightBracket.Margin = new System.Windows.Forms.Padding(4);
            this.RightBracket.Name = "RightBracket";
            this.RightBracket.Size = new System.Drawing.Size(60, 38);
            this.RightBracket.TabIndex = 73;
            this.RightBracket.Text = ")";
            this.RightBracket.UseVisualStyleBackColor = false;
            // 
            // LeftBracket
            // 
            this.LeftBracket.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LeftBracket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftBracket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LeftBracket.Location = new System.Drawing.Point(299, 321);
            this.LeftBracket.Margin = new System.Windows.Forms.Padding(4);
            this.LeftBracket.Name = "LeftBracket";
            this.LeftBracket.Size = new System.Drawing.Size(60, 38);
            this.LeftBracket.TabIndex = 72;
            this.LeftBracket.Text = "(";
            this.LeftBracket.UseVisualStyleBackColor = false;
            // 
            // Exponent
            // 
            this.Exponent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Exponent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exponent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Exponent.Location = new System.Drawing.Point(435, 277);
            this.Exponent.Margin = new System.Windows.Forms.Padding(4);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(60, 38);
            this.Exponent.TabIndex = 71;
            this.Exponent.Text = " x^n";
            this.Exponent.UseVisualStyleBackColor = false;
            // 
            // Sqrt
            // 
            this.Sqrt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Sqrt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sqrt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Sqrt.Location = new System.Drawing.Point(367, 277);
            this.Sqrt.Margin = new System.Windows.Forms.Padding(4);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(60, 38);
            this.Sqrt.TabIndex = 70;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = false;
            // 
            // Fact
            // 
            this.Fact.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Fact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fact.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fact.Location = new System.Drawing.Point(299, 277);
            this.Fact.Margin = new System.Windows.Forms.Padding(4);
            this.Fact.Name = "Fact";
            this.Fact.Size = new System.Drawing.Size(60, 38);
            this.Fact.TabIndex = 69;
            this.Fact.Text = "!";
            this.Fact.UseVisualStyleBackColor = false;
            // 
            // Tan
            // 
            this.Tan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Tan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Tan.Location = new System.Drawing.Point(435, 232);
            this.Tan.Margin = new System.Windows.Forms.Padding(4);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(60, 38);
            this.Tan.TabIndex = 68;
            this.Tan.Text = "tan";
            this.Tan.UseVisualStyleBackColor = false;
            // 
            // Cos
            // 
            this.Cos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Cos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Cos.Location = new System.Drawing.Point(367, 232);
            this.Cos.Margin = new System.Windows.Forms.Padding(4);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(60, 38);
            this.Cos.TabIndex = 67;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = false;
            // 
            // Sin
            // 
            this.Sin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Sin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Sin.Location = new System.Drawing.Point(299, 232);
            this.Sin.Margin = new System.Windows.Forms.Padding(4);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(60, 38);
            this.Sin.TabIndex = 66;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = false;
            // 
            // Pi
            // 
            this.Pi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Pi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Pi.Location = new System.Drawing.Point(435, 187);
            this.Pi.Margin = new System.Windows.Forms.Padding(4);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(60, 38);
            this.Pi.TabIndex = 65;
            this.Pi.Text = " π";
            this.Pi.UseVisualStyleBackColor = false;
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Log.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(367, 187);
            this.Log.Margin = new System.Windows.Forms.Padding(4);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(60, 38);
            this.Log.TabIndex = 64;
            this.Log.Text = "log";
            this.Log.UseVisualStyleBackColor = false;
            // 
            // E
            // 
            this.E.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.E.Cursor = System.Windows.Forms.Cursors.Hand;
            this.E.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.E.Location = new System.Drawing.Point(299, 187);
            this.E.Margin = new System.Windows.Forms.Padding(4);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(60, 38);
            this.E.TabIndex = 63;
            this.E.Text = "e";
            this.E.UseVisualStyleBackColor = false;
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.Color.Transparent;
            this.Backspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backspace.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backspace.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Backspace.Location = new System.Drawing.Point(182, 138);
            this.Backspace.Margin = new System.Windows.Forms.Padding(4);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(60, 38);
            this.Backspace.TabIndex = 62;
            this.Backspace.Text = "<—";
            this.Backspace.UseVisualStyleBackColor = false;
            // 
            // Comma
            // 
            this.Comma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Comma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Comma.Location = new System.Drawing.Point(120, 322);
            this.Comma.Margin = new System.Windows.Forms.Padding(4);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(60, 38);
            this.Comma.TabIndex = 61;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            // 
            // Num0
            // 
            this.Num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num0.Location = new System.Drawing.Point(58, 322);
            this.Num0.Margin = new System.Windows.Forms.Padding(4);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(60, 38);
            this.Num0.TabIndex = 60;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            // 
            // Num1
            // 
            this.Num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num1.Location = new System.Drawing.Point(58, 277);
            this.Num1.Margin = new System.Windows.Forms.Padding(4);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(60, 38);
            this.Num1.TabIndex = 59;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            // 
            // Num4
            // 
            this.Num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num4.Location = new System.Drawing.Point(58, 232);
            this.Num4.Margin = new System.Windows.Forms.Padding(4);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(60, 38);
            this.Num4.TabIndex = 58;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            // 
            // Num7
            // 
            this.Num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num7.Location = new System.Drawing.Point(58, 187);
            this.Num7.Margin = new System.Windows.Forms.Padding(4);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(60, 38);
            this.Num7.TabIndex = 57;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            // 
            // Num2
            // 
            this.Num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num2.Location = new System.Drawing.Point(120, 277);
            this.Num2.Margin = new System.Windows.Forms.Padding(4);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(60, 38);
            this.Num2.TabIndex = 56;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            // 
            // Num5
            // 
            this.Num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num5.Location = new System.Drawing.Point(120, 232);
            this.Num5.Margin = new System.Windows.Forms.Padding(4);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(60, 38);
            this.Num5.TabIndex = 55;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            // 
            // Num8
            // 
            this.Num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num8.Location = new System.Drawing.Point(120, 187);
            this.Num8.Margin = new System.Windows.Forms.Padding(4);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(60, 38);
            this.Num8.TabIndex = 54;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            // 
            // Num3
            // 
            this.Num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num3.Location = new System.Drawing.Point(182, 277);
            this.Num3.Margin = new System.Windows.Forms.Padding(4);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(60, 38);
            this.Num3.TabIndex = 53;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            // 
            // Num6
            // 
            this.Num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num6.Location = new System.Drawing.Point(182, 232);
            this.Num6.Margin = new System.Windows.Forms.Padding(4);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(60, 38);
            this.Num6.TabIndex = 52;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            // 
            // Num9
            // 
            this.Num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Num9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Num9.Location = new System.Drawing.Point(182, 187);
            this.Num9.Margin = new System.Windows.Forms.Padding(4);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(60, 38);
            this.Num9.TabIndex = 51;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            // 
            // Mul
            // 
            this.Mul.BackColor = System.Drawing.Color.Aquamarine;
            this.Mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mul.Location = new System.Drawing.Point(249, 187);
            this.Mul.Margin = new System.Windows.Forms.Padding(4);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(42, 38);
            this.Mul.TabIndex = 50;
            this.Mul.Text = "X";
            this.Mul.UseVisualStyleBackColor = false;
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.Aquamarine;
            this.Sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sub.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sub.Location = new System.Drawing.Point(249, 232);
            this.Sub.Margin = new System.Windows.Forms.Padding(4);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(42, 38);
            this.Sub.TabIndex = 49;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Aquamarine;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(249, 277);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(42, 38);
            this.Add.TabIndex = 48;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // Eq
            // 
            this.Eq.BackColor = System.Drawing.Color.Aquamarine;
            this.Eq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Eq.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Eq.Location = new System.Drawing.Point(182, 322);
            this.Eq.Margin = new System.Windows.Forms.Padding(4);
            this.Eq.Name = "Eq";
            this.Eq.Size = new System.Drawing.Size(109, 38);
            this.Eq.TabIndex = 47;
            this.Eq.Text = "=";
            this.Eq.UseVisualStyleBackColor = false;
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.Aquamarine;
            this.Div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Div.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Div.Location = new System.Drawing.Point(249, 138);
            this.Div.Margin = new System.Windows.Forms.Padding(4);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(42, 38);
            this.Div.TabIndex = 46;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            // 
            // PlusMinus
            // 
            this.PlusMinus.BackColor = System.Drawing.Color.Transparent;
            this.PlusMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusMinus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusMinus.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.PlusMinus.Location = new System.Drawing.Point(120, 138);
            this.PlusMinus.Margin = new System.Windows.Forms.Padding(4);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(60, 38);
            this.PlusMinus.TabIndex = 45;
            this.PlusMinus.Text = "+/-";
            this.PlusMinus.UseVisualStyleBackColor = false;
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.Color.Transparent;
            this.ClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearAll.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.ClearAll.Location = new System.Drawing.Point(58, 138);
            this.ClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(60, 38);
            this.ClearAll.TabIndex = 42;
            this.ClearAll.Text = "CA";
            this.ClearAll.UseVisualStyleBackColor = false;
            // 
            // ConverterGroupBox
            // 
            this.ConverterGroupBox.Controls.Add(this.label2);
            this.ConverterGroupBox.Controls.Add(this.label1);
            this.ConverterGroupBox.Controls.Add(this.OutConvert);
            this.ConverterGroupBox.Controls.Add(this.InConvert);
            this.ConverterGroupBox.Controls.Add(this.Convert);
            this.ConverterGroupBox.Controls.Add(this.comboBox2);
            this.ConverterGroupBox.Controls.Add(this.comboBox1);
            this.ConverterGroupBox.Location = new System.Drawing.Point(610, 459);
            this.ConverterGroupBox.Name = "ConverterGroupBox";
            this.ConverterGroupBox.Size = new System.Drawing.Size(592, 381);
            this.ConverterGroupBox.TabIndex = 44;
            this.ConverterGroupBox.TabStop = false;
            this.ConverterGroupBox.Text = "Converter";
            this.ConverterGroupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 79;
            this.label2.Text = "To base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "From base";
            // 
            // OutConvert
            // 
            this.OutConvert.BackColor = System.Drawing.Color.Aquamarine;
            this.OutConvert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutConvert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OutConvert.Location = new System.Drawing.Point(58, 244);
            this.OutConvert.Name = "OutConvert";
            this.OutConvert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutConvert.Size = new System.Drawing.Size(437, 50);
            this.OutConvert.TabIndex = 77;
            this.OutConvert.Text = "";
            // 
            // InConvert
            // 
            this.InConvert.BackColor = System.Drawing.Color.Aquamarine;
            this.InConvert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InConvert.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.InConvert.Location = new System.Drawing.Point(58, 52);
            this.InConvert.Name = "InConvert";
            this.InConvert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InConvert.Size = new System.Drawing.Size(437, 50);
            this.InConvert.TabIndex = 76;
            this.InConvert.Text = "";
            // 
            // Convert
            // 
            this.Convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Convert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Convert.Location = new System.Drawing.Point(235, 151);
            this.Convert.Margin = new System.Windows.Forms.Padding(4);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(89, 33);
            this.Convert.TabIndex = 61;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.comboBox2.Location = new System.Drawing.Point(367, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(128, 23);
            this.comboBox2.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36"});
            this.comboBox1.Location = new System.Drawing.Point(58, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 23);
            this.comboBox1.TabIndex = 43;
            // 
            // DeviationGroupBox
            // 
            this.DeviationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeviationGroupBox.Controls.Add(this.LabelFileInput);
            this.DeviationGroupBox.Controls.Add(this.LabelOwnInput);
            this.DeviationGroupBox.Controls.Add(this.LabelOutput);
            this.DeviationGroupBox.Controls.Add(this.Calculate);
            this.DeviationGroupBox.Controls.Add(this.FileChoose);
            this.DeviationGroupBox.Controls.Add(this.textBox1);
            this.DeviationGroupBox.Controls.Add(this.InDev);
            this.DeviationGroupBox.Controls.Add(this.OutDev);
            this.DeviationGroupBox.Location = new System.Drawing.Point(12, 459);
            this.DeviationGroupBox.Name = "DeviationGroupBox";
            this.DeviationGroupBox.Size = new System.Drawing.Size(592, 381);
            this.DeviationGroupBox.TabIndex = 45;
            this.DeviationGroupBox.TabStop = false;
            this.DeviationGroupBox.Text = "Deviation";
            this.DeviationGroupBox.Visible = false;
            // 
            // LabelFileInput
            // 
            this.LabelFileInput.AutoSize = true;
            this.LabelFileInput.Location = new System.Drawing.Point(65, 153);
            this.LabelFileInput.Name = "LabelFileInput";
            this.LabelFileInput.Size = new System.Drawing.Size(83, 15);
            this.LabelFileInput.TabIndex = 85;
            this.LabelFileInput.Text = "Input from file";
            // 
            // LabelOwnInput
            // 
            this.LabelOwnInput.AutoSize = true;
            this.LabelOwnInput.Location = new System.Drawing.Point(65, 223);
            this.LabelOwnInput.Name = "LabelOwnInput";
            this.LabelOwnInput.Size = new System.Drawing.Size(63, 15);
            this.LabelOwnInput.TabIndex = 84;
            this.LabelOwnInput.Text = "Own input";
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(65, 47);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(45, 15);
            this.LabelOutput.TabIndex = 83;
            this.LabelOutput.Text = "Output";
            // 
            // Calculate
            // 
            this.Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(435, 162);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(67, 38);
            this.Calculate.TabIndex = 82;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            // 
            // FileChoose
            // 
            this.FileChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileChoose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.FileChoose.Location = new System.Drawing.Point(346, 162);
            this.FileChoose.Margin = new System.Windows.Forms.Padding(4);
            this.FileChoose.Name = "FileChoose";
            this.FileChoose.Size = new System.Drawing.Size(64, 38);
            this.FileChoose.TabIndex = 81;
            this.FileChoose.Text = "Choose a file";
            this.FileChoose.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(65, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(237, 23);
            this.textBox1.TabIndex = 80;
            // 
            // InDev
            // 
            this.InDev.BackColor = System.Drawing.Color.Aquamarine;
            this.InDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InDev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InDev.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.InDev.Location = new System.Drawing.Point(65, 241);
            this.InDev.Name = "InDev";
            this.InDev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InDev.Size = new System.Drawing.Size(437, 50);
            this.InDev.TabIndex = 79;
            this.InDev.Text = "";
            // 
            // OutDev
            // 
            this.OutDev.BackColor = System.Drawing.Color.Aquamarine;
            this.OutDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutDev.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutDev.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.OutDev.Location = new System.Drawing.Point(65, 65);
            this.OutDev.Name = "OutDev";
            this.OutDev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutDev.Size = new System.Drawing.Size(437, 50);
            this.OutDev.TabIndex = 78;
            this.OutDev.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 874);
            this.Controls.Add(this.ConverterGroupBox);
            this.Controls.Add(this.DeviationGroupBox);
            this.Controls.Add(this.CalculatorGroupBox);
            this.Controls.Add(this.Deviation);
            this.Controls.Add(this.Converter);
            this.Controls.Add(this.Calculator);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CalculatorGroupBox.ResumeLayout(false);
            this.ConverterGroupBox.ResumeLayout(false);
            this.ConverterGroupBox.PerformLayout();
            this.DeviationGroupBox.ResumeLayout(false);
            this.DeviationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button Converter;
        private System.Windows.Forms.Button Deviation;
        private System.Windows.Forms.GroupBox CalculatorGroupBox;
        private System.Windows.Forms.Button Exp10;
        private System.Windows.Forms.Button RightBracket;
        private System.Windows.Forms.Button LeftBracket;
        private System.Windows.Forms.Button Exponent;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Fact;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Pi;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Eq;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button PlusMinus;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.RichTextBox OutputCalc;
        private System.Windows.Forms.RichTextBox InputCalc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox ConverterGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox OutConvert;
        private System.Windows.Forms.RichTextBox InConvert;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox DeviationGroupBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button FileChoose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox InDev;
        private System.Windows.Forms.RichTextBox OutDev;
        private System.Windows.Forms.Label LabelFileInput;
        private System.Windows.Forms.Label LabelOwnInput;
        private System.Windows.Forms.Label LabelOutput;
    }
}


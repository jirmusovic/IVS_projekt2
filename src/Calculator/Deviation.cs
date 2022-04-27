/**
 * @file Deviation.cs
 * @class Deviation
 * 
 * @brief Třída obsahující funkce pro výpočet výběrové směrodatné odchylky
 * 
 * @date 28-04-2022
 */



using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Calc
{
    public class Deviation
    {

        public string StdDeviation(string expression)
        {
            expression = expression.Replace('\t', ' ');
            while (expression.IndexOf("  ") >= 0)
                expression = expression.Replace("  ", " ");
            expression = expression.Trim();
#if false
            Stopwatch dataCollect = new Stopwatch();
            dataCollect.Start();
#endif
            string[] numbers_string = expression.Split(' ');
            double[] numbers = new double[numbers_string.Length];
#if false
            dataCollect.Stop();
            Console.WriteLine("Collecting data: " + dataCollect.ElapsedTicks + "(" + dataCollect.ElapsedMilliseconds + " ms)");

            Stopwatch dataParse = new Stopwatch();
            dataParse.Start();
#endif
            for (UInt32 i = 0; i < numbers_string.Length; i++)
            {
                double result;
                if (double.TryParse(numbers_string[i], out result))
                {
                    numbers[i] = result;
                }
                else
                {
                    return null;
                }
            }
#if false
            dataParse.Stop();
            Console.WriteLine("Parsing data: " + dataParse.ElapsedTicks + "(" + dataParse.ElapsedMilliseconds + " ms)");
            Stopwatch calculation = new Stopwatch();
            calculation.Start();
#endif
            Evaluation eval = new Evaluation();
            var x = eval.ArithmeticMean(numbers);

            double res = Math.Sqrt(1.0 / (numbers.Length - 1) * (SumSquared(numbers) - numbers.Length * x * x));
#if false
            calculation.Stop();

            Process process = Process.GetCurrentProcess();
            Console.WriteLine("Memory used: " + process.PrivateMemorySize64/(1024*1024) + " MB");
            Console.WriteLine("Calculating data: " + calculation.ElapsedTicks + "(" + calculation.ElapsedMilliseconds + " ms)");
            Console.WriteLine("Number of tested items: "+numbers_string.Length);
#endif
            return res.ToString();

        }


        private double SumSquared(double[] numbers)
        {
            double res = 0.0;
            foreach(double num in numbers)
            {
                res += num * num;
            }
            return res;
        }
    }
}
/*** Konec souboru Deviation.cs ***/


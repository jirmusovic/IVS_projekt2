/**
 * @file Deviation.cs
 * 
 * @brief Třída obsahující funkce pro výpočet výběrové směrodatné odchylky
 * 
 * @date 28-04-2022
 * @author xnovak3g, xjirmu00
 */


using System;
using System.Diagnostics;

namespace Calc
{
    /**
     * @class Třída obsahující funkce pro výpočet výběrové směrodatné odchylky
     */
    public class Deviation
    {
        /**
         * @brief Funkce pro výpočet výběrové směrodatné odchylky
         * 
         * @param expression Textový řetězec obsahující vstupní hodnoty oddělené bílými znaky
         * 
         * @return Výsledek výpočtu směrodatné odchylky / null v případě chyby
         */
        public string StdDeviation(string expression)
        {
            expression = expression.Replace('\t', ' '); //Nahrazení všech \t znaků za mezery
            expression = expression.Replace('\n', ' '); //Nahrazení všech \n znaků za mezery
            while (expression.IndexOf("  ") >= 0) //Cyklus pro ostranění všech dvojitých mezer
                expression = expression.Replace("  ", " ");
            expression = expression.Trim();
#if false
            Stopwatch dataCollect = new Stopwatch();
            dataCollect.Start();
#endif
            //Rozdělení vstupního řetězce na jednotlivé hodnoty
            string[] numbers_string = expression.Split(' '); /**Pole obsahující všechny vstupní hodnoty - typ string*/
            double[] numbers = new double[numbers_string.Length]; /**Pole obsahující všechny vstupní hodnoty - typ double*/
#if false
            dataCollect.Stop();
            Console.WriteLine("Collecting data: " + dataCollect.ElapsedTicks + "(" + dataCollect.ElapsedMilliseconds + " ms)");

            Stopwatch dataParse = new Stopwatch();
            dataParse.Start();
#endif
            for (UInt32 i = 0; i < numbers_string.Length; i++) //Cyklus pro změnu datového typu všech vstpuních hodnot z typu string na typ double
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
            Evaluation eval = new Evaluation(); //Inicializace matematické knihovny
            var x = eval.ArithmeticMean(numbers); /**Aritmetický průměr*/

            double res = Math.Sqrt(1.0 / (numbers.Length - 1) * (SumSquared(numbers) - numbers.Length * x * x)); /**Výběrová směrodatná odchylka*/
#if false
            calculation.Stop();

            Process process = Process.GetCurrentProcess();
            Console.WriteLine("Memory used: " + process.PrivateMemorySize64/(1024*1024) + " MB");
            Console.WriteLine("Calculating data: " + calculation.ElapsedTicks + "(" + calculation.ElapsedMilliseconds + " ms)");
            Console.WriteLine("Number of tested items: "+numbers_string.Length);
#endif
            return res.ToString();

        }

        /**
         * @brief Pomocná funkce pro výpočet sumy druhých mocnin čísel
         * 
         * @param numbers Pole čísel, ze kterých se má vypočítat výsledek
         * 
         * @return Suma druhých mocnin čísel
         */
        private double SumSquared(double[] numbers)
        {
            double res = 0.0; /**Suma*/
            foreach(double num in numbers)
            {
                res += num * num;
            }
            return res;
        }
    }
}
/*** Konec souboru Deviation.cs ***/


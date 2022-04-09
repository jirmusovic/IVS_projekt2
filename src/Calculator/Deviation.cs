using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public class Deviation
    {
        public string StdDeviation(string expression)
        {
            string[] numbers_string = expression.Split(' ');
            double[] numbers = new double[numbers_string.Length];
            for(UInt32 i = 0; i<numbers_string.Length; i++)
            {
                double result;
                if(double.TryParse(numbers_string[i], out result))
                {
                    numbers[i] = result;
                }
                else
                {
                    return null;
                }
            }

            var x = ArithmeticMean(numbers);

            double res = 1.0 / (numbers.Length - 1) * (SumSquared(numbers) - numbers.Length * x * x);


            return Math.Sqrt(res).ToString();
        }

        private double ArithmeticMean(double[] numbers)
        {
            double res = 0.0;
            foreach (double num in numbers)
            {
                res += num;
            }

            return res / numbers.Length;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    public class Evaluation
    {
        public string Evaluate(string expression)
        {
            return null;
        }

        public double StringToNum(string expression)
        {
            return 0.0f;
        }

        public string N_root(string expression)
        {
            return null;
        }

        public double N_root(double x, double n)
        {
            return 0;
        } 

        public string N_power(string expression)
        {
            double x = 0;
            double n = 0;

            string[] values = expression.Split('^');
            if (values.Length != 2)
                return null;
            if(double.TryParse(values[0], out x) == false)
            {
                return null;
            }

            if (double.TryParse(values[1], out n) == false)
            {
                return null;
            }

            double result = N_power(x, n);

            return result.ToString();
        }

        public double N_power(double x, double n)
        {
            double result = 0;

            result = x;
            for (int i = 0; i < n-1; i++)
            {
                result *= x;
            }
           
            return result;
        }

        public string Factorial(string expression)
        {



            return null;
        }

        private int GetCharIndexPos(string expression, char seeking)
        {
            return 0;
        }

        private int GetSubstringPos(string expression, int starterPos, bool forward)
        {
            return 0;
        }

        private string RemoveNotNecessaryBrackets(string expression)
        {
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (brackets.Count == 1 && i == expression.Length - 1 && expression[i] == ')')
                {
                    expression.Substring(1, expression.Length - 2);
                }

                if (expression[i] == '(')
                {
                    brackets.Push(1);
                }

                if (expression[i] == ')')
                {
                    brackets.Pop();

                    if (brackets.Count == 0 && i != expression.Length - 1)
                    {
                        return expression;
                    }
                }
            }

            return expression.Substring(1, expression.Length - 2);
        }

    }
}

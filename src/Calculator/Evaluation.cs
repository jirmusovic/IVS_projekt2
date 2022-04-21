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
            expression = expression.Replace(" ", String.Empty);

            double x = 0;
            double n = 0;

            char[] startTrim = new char[] { 'f', '(' };

            expression = expression.TrimStart(startTrim);
            expression = expression.TrimEnd(')');
            string[] values = expression.Split(',');
            if (values.Length != 2)
                return null;
            if (double.TryParse(values[0], out x) == false)
            {
                return null;
            }

            if (double.TryParse(values[1], out n) == false)
            {
                return null;
            }

            return Math.Pow(x, 1.0 / n).ToString(); ;
        }



        public string N_power(string expression)
        {
            expression = expression.Replace(" ", String.Empty);

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


            return Math.Pow(x, n).ToString(); ;
        }


        public string Factorial(string expression)
        {
            expression = expression.Replace(" ", String.Empty);

            int num = 0;
            if (int.TryParse(expression.TrimEnd('!'), out num) == false){
                return null;
            }
            if (num < 0)
            {
                return null;
            }
            int result = 1;
            for(; num>0; num--)
            {
                result *= num;
            }


            return result.ToString();
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

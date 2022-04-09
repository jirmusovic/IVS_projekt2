using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Evaluation
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

        public string N_power(string expression)
        {
            return null;
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

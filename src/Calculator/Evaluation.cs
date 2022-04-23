using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Calc
{
    public class Evaluation
    {
        public string Evaluate(string expression)
        {
            expression = expression.Replace(" ", String.Empty);
            double res = Eval(expression);
            if(double.IsNaN(res))
            {
                return null;
            }
            return res.ToString();
        }

        private double Eval(string expression)
        {
            expression = RemoveNotNecessaryBrackets(expression);

            int firstStringPosition;

            

            while ((firstStringPosition = expression.IndexOf('!')) >= 0)
            {
                int lastStringPosition = GetSubstringPos(expression, firstStringPosition - 1, true);
                firstStringPosition = GetSubstringPos(expression, firstStringPosition - 1, false);
                string found = expression.Substring(firstStringPosition, lastStringPosition - firstStringPosition + 1);

                expression = expression.Replace(found, Factorial(found));
            }

            while ((firstStringPosition = expression.IndexOf('^')) >= 0)
            {
                int midPos = firstStringPosition;
                int lastStringPosition = GetSubstringPos(expression, midPos + 1, true);
                firstStringPosition = GetSubstringPos(expression, midPos - 1, false);

                string found = expression.Substring(firstStringPosition, lastStringPosition - firstStringPosition + 1);

                expression = expression.Replace(found, N_power(found));
            }

            while ((firstStringPosition = expression.IndexOf("f(")) >= 0)
            {
                string found = expression.Substring(firstStringPosition, GetSubstringPos(expression, firstStringPosition, true) - firstStringPosition + 1);

                expression = expression.Replace(found, N_root(found));
            }
            while ((firstStringPosition = expression.IndexOf("π")) >= 0)
            {
                string pi = Math.PI.ToString().Replace(',', '.');
                if(firstStringPosition != 0)
                {
                    char tmp = expression[firstStringPosition - 1];
                    if (!(tmp == '*' || tmp == '/' || tmp == '-' || tmp == '+' || tmp == '('))
                        pi = "*" + pi;
                }
                if (firstStringPosition != expression.Length-1)
                {
                    char tmp = expression[firstStringPosition +1];
                    if (!(tmp == '*' || tmp == '/' || tmp == '-' || tmp == '+' || tmp == ')'))
                        pi = pi + "*";
                }
                expression = expression.Replace(expression.Substring(firstStringPosition, 1), pi);

            }
            while ((firstStringPosition = expression.IndexOf("e")) >= 0)
            {
                string e = Math.E.ToString().Replace(',', '.');
                if (firstStringPosition != 0)
                {
                    char tmp = expression[firstStringPosition - 1];
                    if (!(tmp == '*' || tmp == '/' || tmp == '-' || tmp == '+' || tmp == '('))
                        e = "*" + e;
                }
                if (firstStringPosition != expression.Length - 1)
                {
                    char tmp = expression[firstStringPosition + 1];
                    if (!(tmp == '*' || tmp == '/' || tmp == '-' || tmp == '+' || tmp == ')'))
                        e = e + "*";
                }
                expression = expression.Replace(expression.Substring(firstStringPosition, 1), e);

            }

            return StringToNum(expression);
            



        }

        private double StringToNum(string expression)
        {
            DataTable table = new DataTable();
            double res;
            try
            {
                res = Convert.ToDouble(table.Compute(expression, ""));
            }
            catch
            {
                res = double.NaN;
            }

            return res;
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
            if ((x = Eval(values[0])) == double.NaN)
            {
                return null;
            }

            if ((n = Eval(values[1])) == double.NaN)
            {
                return null;
            }

            double result = Math.Round(Math.Pow(x, 1.0 / n), 6);
            if (double.IsNaN(result))
                return null;
            else
                return result.ToString().Replace(',', '.');
        }



        public string N_power(string expression)
        {
            expression = expression.Replace(" ", String.Empty);

            double x = 0;
            double n = 0;

            string[] values = expression.Split('^');
            if (values.Length != 2)
                return null;
            if((x = Eval(values[0])) == double.NaN)
            {
                return null;
            }

            if ((n = Eval(values[1])) == double.NaN)
            {
                return null;
            }


            double result = Math.Round(Math.Pow(x, n), 6);
            if (double.IsNaN(result))
                return null;
            else
                return result.ToString().Replace(',', '.');
        }


        public string Factorial(string expression)
        {
            expression = expression.Replace(" ", String.Empty);

            double numDouble = Eval(expression.TrimEnd('!'));
            int num = -1;
            if(Math.Abs(numDouble%1) <= Double.Epsilon * 100)
            {
                num = Convert.ToInt32(numDouble);
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
            int position = 0;

            int brackets_count = 0;
            for (int i = 0; i < expression.Length; i++)
            {

                if (expression[i] == '(')
                {
                    brackets_count++;
                }

                if (expression[i] == ')')
                {
                    brackets_count--;
                    if (i == expression.Length - 1)
                    {
                        return position;
                    }
                }

                if (expression[i] == seeking)
                {
                    position = i;
                    if (brackets_count == 0)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        private int GetSubstringPos(string expression, int starterPos, bool forward)
        {
            char[] seek = new char[2];
            char[] interrupt = new char[] { '+', '-', '*', '/', '^' };
            int step = 0;
            int char_counter = 0;


            if (forward)
            {
                seek[0] = '(';
                seek[1] = ')';
                step = 1;
            }
            else
            {
                seek[0] = ')';
                seek[1] = '(';
                step = -1;
            }


            for (int i = starterPos; i >= 0 && i < expression.Length; i += step)
            {
                if (char_counter == 0)
                {
                    foreach (char elem in interrupt)
                    {
                        if (expression[i] == elem)
                        {
                            return i - step;
                        }
                    }
                }
                if (expression[i] == seek[0])
                {
                    char_counter++;
                }
                if (expression[i] == seek[1])
                {
                    if (char_counter != 0)
                    {
                        char_counter--;
                    }

                    if (char_counter == 0)
                    {
                        if(forward == false && i > 0)
                        {
                            if (expression[i - 1] == 'f')
                                return i - 1;
                        }
                        return i;
                    }
                }
            }

            if (step == 1)
            {
                return expression.Length - 1;
            }
            else
            {
                return 0;
            }

        }

        private string RemoveNotNecessaryBrackets(string expression)
        {
            if (expression.Length <= 2)
            {
                return expression;
            }
            int count = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                    count++;
                if (expression[i] == ')')
                {
                    if (count > 0)
                        count--;
                    else
                        return expression;
                }
            }
            if (count == 0 && expression[expression.Length - 1] == ')' && expression[0] == '(')
            {
                return expression.Substring(1, expression.Length - 2);
            }
            else
                return expression;
        }

    }
}

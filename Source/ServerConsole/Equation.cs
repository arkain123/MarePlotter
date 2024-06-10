using NCalc;
using System;

namespace Server
{
    internal class Equation
    {
        public string eq = "y - x * x + 1";

        public Equation(string usereq)
        {
            eq = usereq;
        }

        public double f(double x, double y)
        {
            Parse();
            Expression expression = new Expression(eq);

            expression.Parameters["x"] = x;
            expression.Parameters["y"] = y;

            try
            {
                double result = (double)expression.Evaluate();
                return result;
            }
            catch (Exception ex)
            {
                return 0.0;
            }

        }

        public void Parse()
        {
            eq = eq.Replace("abs", "Abs");
            eq = eq.Replace("exp", "Exp");
            eq = eq.Replace("log", "Log");
            eq = eq.Replace("ln", "Log10");
            eq = eq.Replace("pow", "Pow");
            eq = eq.Replace("sqrt", "Sqrt");
            eq = eq.Replace("tan", "Tan");
            eq = eq.Replace("cos", "Cos");
            eq = eq.Replace("sin", "Sin");
        }
    }
}

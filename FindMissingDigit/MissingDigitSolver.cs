using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingDigit
{
    public static class MissingDigitSolver
    {

        public static int FindMissingDigit(string expression)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (IsValid(expression.Replace("?", (i).ToString())))
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool IsValid(string expression)
        {
            string[] parts = expression.Split([' '], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            try
            {
                int leftTerm = int.Parse(parts[0]);
                var eqOperator = parts[1];
                int rightTerm = int.Parse(parts[2]);
                int result = int.Parse(parts[4]);

                bool valid = eqOperator switch
                {
                    "+" => leftTerm + rightTerm == result,
                    "-" => leftTerm - rightTerm == result,
                    "*" => leftTerm * rightTerm == result,
                    "/" when rightTerm != 0 => leftTerm / rightTerm == result,
                    _ => false
                };

                return valid;
            }
            catch
            {
                return false;
            }
        }
    }
}

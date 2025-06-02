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
           int missingDigit = -1;

            for (int i = 0; i <= 9; i++)
            {
              if (IsValid(expression.Replace("?", (i).ToString())))
                {
                    missingDigit = i;
                    break;
                }
            }
            return missingDigit;
        }
        //"1? + 23 = 45"
        public static bool IsValid(string expression)
        {
            string[] parts = expression.Split([' '], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            int leftTerm = int.TryParse(parts[0], out var parsed) ? parsed : 0;
            var eqOperator = parts[1];
            int rightTerm = int.TryParse(parts[2], out parsed) ? parsed : 0;
            int result = int.TryParse(parts[4], out parsed) ? parsed : 0;

            bool valid = eqOperator switch
            {
                "+" => leftTerm + rightTerm == result,
                "-" => leftTerm - rightTerm == result,
                "*" => leftTerm * rightTerm == result   ,
                "/" when rightTerm != 0 => leftTerm / rightTerm == result,
                "/" => false,
                _ => false
            };

            return valid;
        }
    }
}

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
        //expression = "12 + 23 = 35";
        public static int FindMissingDigit(string expression)
        {
            for (int i = 0; i <= 9; i++)
            {
                
                string candidate = expression.Replace("?", i.ToString());
                
                if (IsValid(candidate)) return i;
                
            }

            return -1;
        }


        //expression = "12 + 23 = 35";
        public static bool IsValid(string expression)
        {
            string[] parts = expression.Split([' '], StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 5) return false;

            string leftStr = parts[0];
            string operatorStr = parts[1];
            string rightStr = parts[2];
            string equalStr = parts[3];
            string resultStr = parts[4];

            if (equalStr != "=") return false;

            if (HasLeadingZero(leftStr) || HasLeadingZero(rightStr) || HasLeadingZero(resultStr))
            {
                return false;
            }


            if (!int.TryParse(leftStr, out int leftTerm)) return false;
            if (!int.TryParse(rightStr, out int rightTerm)) return false;
            if (!int.TryParse(resultStr, out int result)) return false;
                       

            return operatorStr switch
            {
                "+" => leftTerm + rightTerm == result,
                "-" => leftTerm - rightTerm == result,
                "*" => leftTerm * rightTerm == result,
                "/" when rightTerm != 0 => leftTerm / rightTerm == result,
                _ => false
            };

        }

        private static bool HasLeadingZero(string s)
        {
            return s.Length > 1 && s.StartsWith("0");
        }
    }
}

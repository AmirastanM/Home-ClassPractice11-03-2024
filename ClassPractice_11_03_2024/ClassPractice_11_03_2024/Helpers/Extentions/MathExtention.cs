using ClassPractice_11_03_2024.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice_11_03_2024.Helpers.Extentions
{
    internal static class MathExtention
    {
        public static int FactorialNamber(this int number)
        {
            int result = 1;
            if(number < 0)
            {
                throw new CustomMathException("Number cannot be negative");
            };
            for ( int i = 1;  i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

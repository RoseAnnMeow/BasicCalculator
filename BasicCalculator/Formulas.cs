using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public delegate double GetAnswer(double num1, double num2);
    class Formulas
    {
        public static double getSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double getMinus(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double getProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double getQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

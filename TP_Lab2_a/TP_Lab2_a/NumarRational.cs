using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab2_a
{
    internal class NumarRational
    {
        private double numValue = 0;
        public double NumValue { get { return numValue; } set { numValue = value; } }

        public NumarRational(double value)
        {
            NumValue = value;
        }

        //operator +
        public static NumarRational operator +(NumarRational num1, NumarRational num2)
        {
            return new NumarRational (num1.NumValue + num2.NumValue);
        }
        public static NumarRational operator +(NumarRational num1, double num2)
        {
            return new NumarRational(num1.NumValue + num2);
        }
        public static NumarRational operator +(double num1, NumarRational num2)
        {
            return new NumarRational(num1 + num2.NumValue);
        }

        //operator -
        public static NumarRational operator -(NumarRational num1, NumarRational num2)
        {
            return new NumarRational(num1.NumValue - num2.NumValue);
        }
        public static NumarRational operator -(NumarRational num1, double num2)
        {
            return new NumarRational(num1.NumValue - num2);
        }
        public static NumarRational operator -(double num1, NumarRational num2)
        {
            return new NumarRational(num1 - num2.NumValue);
        }

        //operator *
        public static NumarRational operator *(NumarRational num1, NumarRational num2)
        {
            return new NumarRational(num1.NumValue * num2.NumValue);
        }
        public static NumarRational operator *(NumarRational num1, double num2)
        {
            return new NumarRational(num1.NumValue * num2);
        }
        public static NumarRational operator *(double num1, NumarRational num2)
        {
            return new NumarRational(num1 * num2.NumValue);
        }

        //operator /
        public static NumarRational operator /(NumarRational num1, NumarRational num2)
        {
            return new NumarRational(num1.NumValue / num2.NumValue);
        }
        public static NumarRational operator /(NumarRational num1, double num2)
        {
            return new NumarRational(num1.NumValue / num2);
        }
        public static NumarRational operator /(double num1, NumarRational num2)
        {
            return new NumarRational(num1 / num2.NumValue);
        }

    }
}

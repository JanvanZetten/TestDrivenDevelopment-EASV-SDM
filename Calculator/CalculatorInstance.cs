using System;

namespace Calculator
{
    public class CalculatorInstance : ICalculator
    {

        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }

        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Divide(double value1, double value2)
        {
            if (value2.Equals(0))
            {
                throw new DivideByZeroException("Can't divide by zero");
            }
            return value1 / value2;
        }

        public int Divide(int value1, int value2)
        {
            if (value2.Equals(0))
            {
                throw new DivideByZeroException("Can't divide by zero");
            }
            return value1 / value2;
        }
    }
}

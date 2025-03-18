//Main Logic, it does actual calculation.

namespace CalculatorLib
{
    public class Calc
    {
        public double Add(double x, double y) => x + y;
        public double Subtract(double x, double y) => x - y;
        public double Multiply(double x, double y) => x * y;
        public double Divide(double x, double y)
        {
            if (y == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return x / y;
        }
    }
}

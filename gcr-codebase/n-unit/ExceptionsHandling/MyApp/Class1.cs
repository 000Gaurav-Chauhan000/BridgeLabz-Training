using System;

namespace MyApp
{
    public class Calculator
    {
        // Divide method with exception handling
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Cannot divide by zero");

            return a / b;
        }
    }
}

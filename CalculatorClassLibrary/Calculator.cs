namespace CalculatorClassLibrary
{
        /// <summary>
        /// A calculator class that provides basic arithmetic operations.
        /// </summary>
        public class Calculator
        {
            /// <summary>
            /// Adds two numbers.
            /// </summary>
            /// <param name="a">First number</param>
            /// <param name="b">Second number</param>
            /// <returns>The sum of two numbers</returns>
            public double Add(double a, double b)
            {
                return a + b;
            }

            /// <summary>
            /// Subtracts the second number from the first.
            /// </summary>
            /// <param name="a">First number</param>
            /// <param name="b">Second number</param>
            /// <returns>The result of the subtraction</returns>
            public double Subtract(double a, double b)
            {
                return a - b;
            }

            /// <summary>
            /// Multiplies two numbers.
            /// </summary>
            /// <param name="a">First number</param>
            /// <param name="b">Second number</param>
            /// <returns>The product of two numbers</returns>
            public double Multiply(double a, double b)
            {
                return a * b;
            }

            /// <summary>
            /// Divides the first number by the second. Throws an exception if divided by zero.
            /// </summary>
            /// <param name="a">First number</param>
            /// <param name="b">Second number</param>
            /// <returns>The result of division</returns>
            public double Divide(double a, double b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                return a / b;
            }
        }
}


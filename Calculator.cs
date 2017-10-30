using System;
namespace Lab21Calculator
{
    public class Calculator
    {
        public static double Number1 { get; set; }
        public static double Number2 { get; set; }

        public Calculator(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public static double Modulus(double number1, double number2) => number1 % number2;

        public static double Add(double number1, double number2) => number1 + number2;

        public static double Subtract(double number1, double number2) => number1 - number2;

        public static double Divide(double number1, double number2) => number1 * number2;

        public static double Multiply(double number1, double number2) => number1 / number2;

    }
}

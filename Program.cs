using System;

namespace Lab21Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                DisplayMenu();
                int selection = RunSelection();

                //ValidateSelection(ref int selection);
                if (selection == 6)
                {
                    Console.WriteLine("Good bye..");
                    break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.WriteLine();

            } while (true);
        }

        private static void ValidateSelection()
        {

        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Calculator Menu");
            Console.WriteLine($"1.  Add");
            Console.WriteLine($"2.  Subtract");
            Console.WriteLine($"3.  Multiply");
            Console.WriteLine($"4.  Divide");
            Console.WriteLine($"5.  Modulus");
            Console.WriteLine($"6.  Quit");
            Console.WriteLine("----------------------------");
        }

        private static int RunSelection()
        {
            Console.Write("Enter your selection [1-6]:");
            int selection = int.Parse(Console.ReadLine());

            if (selection == 6)
            {
                return selection;
            }

            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            DoArithmetic(selection, number1, number2);
            return selection;
        }

        private static void DoArithmetic(int selection, int number1, int number2)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine($"{number1} + {number2} = {Calculator.Add(number1, number2):F}");
                    break;
                case 2:
                    Console.WriteLine($"{number1} - {number2} = {Calculator.Subtract(number1, number2):F}");
                    break;
                case 3:
                    Console.WriteLine($"{number1} * {number2} = {Calculator.Multiply(number1, number2):F}");
                    break;
                case 4:
                    if (number2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero, please try again with valid values");
                        break;
                    }
                    Console.WriteLine($"{number1} / {number2} = {Calculator.Divide(number1, number2):F}");

                    break;
                case 5:
                    Console.WriteLine($"{number1} % {number2} = {Calculator.Modulus(number1, number2):F}");
                    break;
                default:
                    break;
            }

        }
    }
}
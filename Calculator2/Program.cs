using System;

namespace Calculator2
{
    public static class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                double result = 0;

                // Create a simple calculator that asks the user to input two different numbers 
                // and whether they want to add, subtract, multiply or divide them. 

                // Use methods for each type of calculation.

                Console.Write("Enter first number: ");
                string firstNumberInput = Console.ReadLine().Trim();
                double firstNumber = double.Parse(firstNumberInput);

                Console.Write("Enter second number: ");
                string secondNumberInput = Console.ReadLine().Trim();
                double secondNumber = double.Parse(secondNumberInput);

                Console.Write("Enter what operator would you like to choose from add, subtract, multiply, divide: ");
                string userOperatorChoice = Console.ReadLine().Trim();

                if (userOperatorChoice == "add")
                {
                    //Console.WriteLine(add(firstNumber, secondNumber));
                    result = Add(firstNumber, secondNumber);
                }
                else if (userOperatorChoice == "subtract")
                {
                    result = Subtract(firstNumber, secondNumber);
                }
                else if (userOperatorChoice == "multiply")
                {
                    result = Multiply(firstNumber, secondNumber);
                }
                else if (userOperatorChoice == "divide")
                {
                    result = Divide(firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("Wrong Operator! Try Again!");
                }



                Console.WriteLine($"Total = {result}");

                Console.ReadLine();
            }
        }
        private static double Add(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber);
        }

        private static double Subtract(double firstNumber, double secondNumber)
        {
            return (firstNumber - secondNumber);
        }

        private static double Multiply(double firstNumber, double secondNumber)
        {
            return (firstNumber * secondNumber);
        }

        private static double Divide(double firstNumber, double secondNumber)
        {
            return (firstNumber / secondNumber);
        }


    }
}

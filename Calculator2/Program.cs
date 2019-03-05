using System;

namespace Calculator2
{
    /// <summary>
    /// The Program class contains methods for simple math funtions.
    /// It contains basic functions of Add, Subtract, Multiply and Divide doubles
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The Main asks for user input for two doubles.
        /// Asks user what mathematical operator they wish to use and calls that operators method.
        /// All this is tied in while loop to give user multiple chances to work 
        /// with different numbers and operators.
        /// </summary>
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
        /// <summary>
        /// Takes in two parameters of double type and adds them to return the result in double.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        /// The sum of two  doubles
        /// </returns>
        public static double Add(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber);
        }
        /// <summary>
        /// Takes in two parameters of double type and subtracts them to return the result in double.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        /// The difference of two doubles
        /// </returns>
        public static double Subtract(double firstNumber, double secondNumber)
        {
            return (firstNumber - secondNumber);
        }
        /// <summary>
        /// Accepts two parameters of double type.
        /// Multiply the first number by the second number to return the result in double.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        /// The product of two doubles
        /// </returns>
        public static double Multiply(double firstNumber, double secondNumber)
        {
            return (firstNumber * secondNumber);
        }
        /// <summary>
        /// Accepts two parameters of double type.
        /// Divides the first number by the second number to return the result in double.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>
        /// The quotient of two doubles
        /// </returns>
        public static double Divide(double firstNumber, double secondNumber)
        {
            return (firstNumber / secondNumber);
        }


    }
}

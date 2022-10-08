using System;

namespace Control_Flow___Exercise_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2- Write a program which takes two numbers from the console and displays the maximum of the two.

            Console.WriteLine("Please enter a number...");

            int firstNumber = stringToIntegerConversion();

            Console.WriteLine("Please enter a (different) number...");

            int secondNumber = stringToIntegerConversion();

            if (firstNumber != secondNumber && firstNumber > secondNumber)
            {
                Console.WriteLine($"The maximum number is {firstNumber}");
            }
            else
            {
                Console.WriteLine($"The maximum number is {secondNumber}");
            }
        }

        private static int stringToIntegerConversion()
        {
            string Input = Console.ReadLine();
            int Output = Convert.ToInt32(Input);
            return Output;
        }
    }
}

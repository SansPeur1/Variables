using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish variables

            int numberOfCoffeesDaily = 1;
            string fullName = "Sue Myers";
            string todaysDate = "May 12";

            //combine variables
            string v = (numberOfCoffeesDaily + fullName + todaysDate);
            var combineThreeVariablesOnOneLine = v;
            Console.WriteLine(combineThreeVariablesOnOneLine);

            //ask name so as to create a greeting

            Console.WriteLine("What is your full name?");
            var userName = Console.ReadLine();

            //create a greeting that incorporates the user's name

            var greeting = $"Nice to meet you, {userName}.";
            Console.WriteLine(greeting);

            //have user input an integer and create a number as a string

            Console.WriteLine("Please enter an even number less than 59");
            var firstNumberAsString = Console.ReadLine();

            //have user enter a second integer and create a second number as a string

            Console.WriteLine("Please enter an even number less than 59");
            var secondNumberAsString = Console.ReadLine();

            //Set Operands

            double firstOperand = double.Parse(firstNumberAsString);

            double secondOperand = double.Parse(secondNumberAsString);

            double sum = (firstOperand + secondOperand);
            Console.WriteLine($"If you add {firstOperand} and {secondOperand}, you get  {sum}");

            double difference = (firstOperand - secondOperand);
            Console.WriteLine($"If you subtract {firstOperand} from {secondOperand}, you get  {difference}");

            double product = (firstOperand * secondOperand);
            Console.WriteLine($"If you multiply {firstOperand} with {secondOperand}, you get  {product}");

            double quotient = (firstOperand / secondOperand);
            Console.WriteLine($"If you divide {firstOperand} by {secondOperand}, you get  {quotient}");

            double remainder = (firstOperand % secondOperand);
            Console.WriteLine($"You find the remainder when you divide {firstOperand} by {secondOperand}, the resultant figure is the remainder, or {remainder}");










        }
    }
}

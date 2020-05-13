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
      var combineThreeVariablesOnOneLine = ${numberOfCoffeesDaily}, {fullName}, {todaysDate};
      Console.WriteLine (combineThreeVariablesOnOneLine);

      //ask name so as to create a greeting
      
      Console.WriteLine("What is your full name?";
      var userName = Console.ReadLine();

      //create a greeting that incorporates the user's name

      var greeting = $"Nice to meet you, {username}.";

      //have user input an integer and create a number as a string

      Console.WriteLine ("Please enter an even number less than 59");
      var firstNumberAsString = Console.ReadLine();

      //have user enter a second integer and create a second number as a string

      Console.WriteLine ("Please enter an even number less than 59");
      var secondNumberAsString = Console.ReadLine ();

      //Set Operands
      
      double firstOperand = double.Parse(firstNumberAsString);

      double secondOperand = double.Parse(secondNumberAsString);

      var sum = ${firstOperand} + {secondOperand};

      //


    

 


    }
  }
}

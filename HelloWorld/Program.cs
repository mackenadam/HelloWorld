using System;

namespace HelloWorld
{
    // ClassNames in pascal case
    class Program
    {
        // MethodNames also in pascal case
        // methodArguments in camel case
        static void Main(string[] args)
        {
            // localVariables in camel case
            // Numbers
            // Do not use abbreviations in variable names
            int number1 = 13;
            int number2 = 31;
            int sum = number1 + number2;

            double double1 = 3.5;
            double double2 = 1.337;
            double doubleSum = double1 + double2;

            // Use Casting for more complex arithmetic on different number types
            // int integerOverDouble = number1 / double1;

            float float1 = 6.9f;

            // Strings
            string myName = "Adam";
            string message = "Hey, " + myName + ", you can also use the String class methods on string variables. To make them all uppercase for instance...";
            string message2 = "Or even all lowercase.";
            string lowercaseMessage = message2.ToLower();

            // Variables can be values or references

            Console.WriteLine("Hello World!");
            Console.WriteLine("The sum of integers like " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of doubles like " + d1 + " and " + d2 + " is " + dSum);
            Console.WriteLine("You can even add integers like " + num1 + " and doubles like " + d1 + " to get " + (num1 + d1));
            Console.WriteLine("You can perform more advanced operations on like data types i.e " + d1 + " divided by " + d2 + " equals " + (d1 / d2));
            Console.WriteLine("However different data types like " + num1 + " and " + d1 + " will rely on 'casting'");
            Console.WriteLine("Don't forget that floating number types like " + f1 + " need to have an f suffix when declared i.e  float f1 = " + f1 + "f");
            Console.WriteLine("Hello " + myName);
            Console.WriteLine(message.ToUpper());
            Console.WriteLine(lowercaseMessage);

            Console.Write("Now, enter a string and press Enter: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("You have entered: '{0}'", userInput);

            Console.Write("Enter a character and press Enter:");
            int asciiValue = Console.Read();
            Console.Write("The ASCII value for that is: '{0}'", asciiValue);
            Console.ReadKey();
            // Examples of console properties
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Now we can change the colour using Console properties.");

  

            Console.ReadKey();
        }
    }
}

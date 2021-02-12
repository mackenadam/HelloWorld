﻿using System;

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
            // Do not use abbreviations in variable names
            // Do not use numbers at the start of variable names
            // Numbers
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
            Console.WriteLine("The sum of integers like " + number1 + " and " + number2 + " is " + sum);
            Console.WriteLine("The sum of doubles like " + double1 + " and " + double2 + " is " + doubleSum);
            Console.WriteLine("You can even add integers like " + number1 + " and doubles like " + double1 + " to get " + (number1 + double1));
            Console.WriteLine("You can perform more advanced operations on like data types i.e " + double1 + " divided by " + double2 + " equals " + (double1 / double2));
            Console.WriteLine("However different data types like " + number1 + " and " + double1 + " will rely on 'casting'");
            Console.WriteLine("Don't forget that floating number types like " + float1 + " need to have an f suffix when declared i.e  float f1 = " + float1 + "f");
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

            // Practice Implicit and Explicit conversions
            double myDouble = 13.37;
            int myInteger;
            // Explicit conversion
            // Cast double into integer
            myInteger = (int)myDouble;
            Console.WriteLine(myInteger);

            Console.Read();
        }
    }
}

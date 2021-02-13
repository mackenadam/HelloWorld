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
            // Do not use abbreviations in variable names
            // Do not use numbers at the start of variable names
            // Numbers
            int number1 = 13;
            int number2 = 31;
            int sum = number1 + number2;

            double double1 = 3.5;
            double double2 = 1.337;
            double doubleSum = double1 + double2;

            // Use Casting for more complex arithmetic on different number types(see below)
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
            // i.e cast double into integer
            myInteger = (int)myDouble;
            Console.WriteLine("We can cast a double into an integer(explicit conversion). However, integers dont store decimal points so any trailing decimals will be lost.");
            Console.WriteLine("For instance, the double " + myDouble + " will become " + myInteger + ".");

            // Implicit conversion
            // i.e convert into a bigger or smaller type
            int anotherNumber = 1234567890;
            long bigNumber = anotherNumber;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            // Type conversion
            // i.e double to a string
            string myString = myDouble.ToString();
            string newString = myFloat.ToString();
            Console.WriteLine(newString);

            bool sunIsShining = true;
            string myBooleanString = sunIsShining.ToString();
            Console.WriteLine(myBooleanString);

            // Parse string to an integer
            string firstString = "15";
            string secondString = "13";
            int firstNumber = Int32.Parse(firstString);
            int secondNumber = Int32.Parse(secondString);
            int resultInt = firstNumber + secondNumber;
            Console.WriteLine(resultInt);

            // String methods
            // i.e SubString, ToLower, ToUpper, Trim, IndexOf
            string firstName = "Adam";
            string lastName = "Macken";
            string fullName = string.Concat(" ", firstName," ", lastName, " ");
            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToLower());
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.IndexOf("M"));
            Console.WriteLine(String.IsNullOrWhiteSpace(fullName));
            Console.WriteLine(String.Format("Hello, my name is {0}", fullName.Trim()));

            Console.Read();
        }
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 31;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double dSum = d1 + d2;

            // Use Casting
            // int intOverDouble = num1 / d1;

            Console.WriteLine("Hello World!");
            Console.WriteLine("The sum of integers like " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of doubles like " + d1 + " and " + d2 + " is " + dSum);
            Console.WriteLine("You can even add integers like " + num1 + " and doubles like " + d1 + " to get " + (num1 + d1));
            Console.WriteLine("You can perform more advanced operations on like data types i.e " + d1 + " divided by " + d2 + " equals " + (d1 / d2));
            Console.WriteLine("However different data types like " + num1 + " and " + d1 + " will rely on 'casting'");
            Console.Read();
        }
    }
}

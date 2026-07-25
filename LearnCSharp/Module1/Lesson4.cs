using System;
using System.Text;

namespace LearnCSharp
{
    internal class Lesson4
    {
        static void OldMain(string[] args)
        {
            //int firstNumber = 12;
            //int secondNumber = 7;
            //Console.WriteLine(firstNumber + secondNumber);

            //string firstName = "Bob";
            //int widgetsSold = 7;
            //Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.\n");

            //int sum = 7 + 5;
            //int difference = 7 - 5;
            //int product = 7 * 5;
            //int quotient = 7 / 5;

            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Difference: " + difference);
            //Console.WriteLine("Product: " + product);
            //Console.WriteLine("Quotient: " + quotient);
            //Console.WriteLine("\n");

            //decimal decimalQuotient = 7.0m / 5;
            //Console.WriteLine($"Decimal quotient: {decimalQuotient}\n");

            //int first = 7;
            //int second = 5;
            //decimal quotient = (decimal)first / (decimal)second;
            //Console.WriteLine(quotient);

            //Console.WriteLine($"Modulus of 200 / 5 {200 % 5}");
            //Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

            //int value1 = 3 + 4 * 5;
            //int value2 = (3 + 4) * 5;
            //Console.WriteLine(value1);
            //Console.WriteLine(value2);

            //int value = 0;
            //value = value + 5;
            //value += 5;

            //int value = 1;
            //value++;
            //Console.WriteLine("First: " + value);
            //Console.WriteLine($"Second: {value++}");
            //Console.WriteLine("Third: " + value);
            //Console.WriteLine("Fourth: " + (++value));

            //int fahrenheit = 94;
            //decimal celcius = (fahrenheit - 32m) * (5m / 9m);
            //Console.WriteLine($"The temperature is {celcius} Celcius.");

            decimal fahrenheit = 94m;
            decimal celcius = fahrenheit - 32m;
            celcius *= 5m / 9m;
            Console.WriteLine($"The temperature is {celcius} Celcius.");


        }


    }
}
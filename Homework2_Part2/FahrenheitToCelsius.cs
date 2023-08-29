/// Week No. 2 Homework Part No. 2
/// File Name: FahrenheitToCelsius.cs
/// @author: Jason Hamrick
/// Date: August 28, 2023
///
/// Problem Statement: Prompt the user for a Fahrenheit temperature,
/// convert the input to Celius, and display the result on the screen.
///
///
/// Overall Plan:
/// 1) Prompt the user for an integer value Fahrenheit temperature.
/// 2) Pass the user input into a convertToCelsius() method.
/// 3) Perform the conversion with the formula degreesC = 5(degreesF – 32)/9.
/// 4) Print the result in the console with one decimal of precision.
///

using System;

namespace Homework2_Part2
{
    class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            int fahrenheit = promptForFahrenheit();
            decimal celsius = convertToCelsius(fahrenheit);

            static int promptForFahrenheit()
            {
                Console.Write("Enter a temperature in degrees Fahrenheit: ");
                return Int32.Parse(Console.ReadLine());
            }

            static decimal convertToCelsius(int degreesF)
            {
                decimal degreesC = 5 * ((decimal)degreesF - 32) / 9;
                degreesC = Math.Round(degreesC, 1);
                return degreesC;
            }

            static void displayResult(int degreesF, decimal degreesC)
            {
                Console.WriteLine(degreesF + " degrees Fahrenheit = " + degreesC + " degrees Celsius");
            }

            displayResult(fahrenheit, celsius);
        }
    }
}
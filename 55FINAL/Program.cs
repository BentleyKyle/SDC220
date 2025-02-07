// Author: Kyle Bentley
// Date: 1/26/2025
// Assignment: SDC220 Final Practical Exam
// Description: Main application file to retrieve and process

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nKyle Bentley - Final Practical Exam");

        // Create an instance of the Unique class
        Unique uniqueNumbers = new Unique();

        // Call the GetNumbers function to retrieve numbers from the user
        uniqueNumbers.GetNumbers();

        // Display results
        Console.WriteLine("Unique values entered: " + string.Join(", ", uniqueNumbers.GetAllNumbers()));
        Console.WriteLine("Smallest number: " + uniqueNumbers.GetSmallest());
        Console.WriteLine("Largest number: " + uniqueNumbers.GetLargest());
        Console.WriteLine("Sum of all numbers: " + uniqueNumbers.GetSum());
        Console.WriteLine("Average of all numbers: " + uniqueNumbers.GetAverage());

        try
        {
            Console.WriteLine("Last number divided by first number: " + uniqueNumbers.DivideLastByFirst());
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: Division by zero encountered. {ex.Message}");
        }
    }
}

// Author: Kyle Bentley
// Date: 1/26/2025
// Assignment: SDC220 Final Practical Exam
// Description: Class for retrieving and processing unique numbers.

using System;
using System.Collections.Generic;

public class Unique
{
    private List<int> numbers; // List to store unique numbers

    // Constructor
    public Unique()
    {
        numbers = new List<int>();
    }

    // Function to get 5 unique numbers from the user
    public void GetNumbers()
    {
        Console.WriteLine("Please enter 5 unique numbers between 0 and 100 (inclusive):");
        while (numbers.Count < 5)
        {
            try
            {
                Console.Write("Enter a number: ");
                int input = int.Parse(Console.ReadLine());

                if (input < 0 || input > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(input), "The number is out of range (0-100).");
                }

                if (!numbers.Contains(input))
                {
                    numbers.Add(input); // Add unique number to the list
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid integer.");
            }
        }
    }

    // Function to return all stored numbers
    public List<int> GetAllNumbers()
    {
        return numbers;
    }

    // Function to get the largest number
    public int GetLargest()
    {
        return numbers.Count > 0 ? numbers.Max() : 0;
    }

    // Function to get the smallest number
    public int GetSmallest()
    {
        return numbers.Count > 0 ? numbers.Min() : 0;
    }

    // Function to get the sum of all numbers
    public int GetSum()
    {
        return numbers.Count > 0 ? numbers.Sum() : 0;
    }

    // Function to get the average of all numbers
    public double GetAverage()
    {
        return numbers.Count > 0 ? numbers.Average() : 0.0;
    }

    // Function to divide the last number by the first number
    public double DivideLastByFirst()
    {
        if (numbers.Count > 0 && numbers[0] != 0)
        {
            return (double)numbers[^1] / numbers[0]; // ^1 is the last element
        }
        else if (numbers.Count > 0 && numbers[0] == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero. First number is 0.");
        }

        return 0.0;
    }
}

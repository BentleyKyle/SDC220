// Author: Kyle Bentley
// Date of development: 1/16/2025
// Assignment SDC220 PA - Calculations & Unique Numbers
// Allow user to enter 10 integers into an array then add each unique integer to a list and calculate sum, average, and display number of numbers in array/list
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kyle Bentley - Week 3 PA Calculations & Unique Numbers");

        //define array and list
        int[] numbers = new int[10];
        List<int> uniqueNumbers = new List<int>();

        // Get 10 integer values
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Please enter an integer: ");
            numbers[i] = int.Parse(Console.ReadLine());

            //Add the number to the uniqueNumbers list if unique
            if (!uniqueNumbers.Contains(numbers[i]))
            {
                uniqueNumbers.Add(numbers[i]);
            }
        }

        // Calculate and display information for all ints
        Console.WriteLine($"\nCount of integers entered: {numbers.Length}");
        Console.WriteLine($"Sum of integers entered: {CalculateSum(numbers)}");
        Console.WriteLine($"Average of integers entered: {CalculateAverage(numbers)}");

        // Calculate and display information for unique integers
        Console.WriteLine($"\nCount of unique integers enterered: {uniqueNumbers.Count}");
        Console.WriteLine($"Sum of unique integers entered: {CalculateSum(uniqueNumbers)}");
        Console.WriteLine($"Average of unique integers entered: {CalculateAverage(uniqueNumbers)}");
    }

    //Methods to calculate sum for array or list
    static int CalculateSum(int[] numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    //methods to calc average for array/list
    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        return (double)CalculateSum(numbers) / numbers.Length;
    }


    static double CalculateAverage(List<int> numbers)
    {
        if (numbers.Count == 0) return 0;
        return (double)CalculateSum(numbers) / numbers.Count;
    }
}

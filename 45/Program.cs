// Author: Kyle Bentley
// Date: 1/26/2025
// Assignment: SDC220 Performance Assessment - User Entry of Age
// Description: This program prompts the user to enter their age and demonstrates the use of system exceptions. It validates the input and handles errors appropriately.

using System;

class Program
{
    static void Main(string[] args)
    {
        //Print Header
        Console.WriteLine("\nKyle Bentley - Week 4 PA User Entry of Age");

        bool cont = true;

        do
        {
            try
            {
                Console.Write("\nPlease enter your age: ");
                string? val = Console.ReadLine();
                int age = Convert.ToInt32(val);

                if (age < 1 || age > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine($"\nThe age entered is: {age}");
                cont = false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n{0}", e);
                Console.WriteLine("Please enter an integer in range 1-100.");
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\n{0}", e);
                Console.WriteLine("Please enter an integer in range 1-100.");
            }
        } while (cont);
    }
}



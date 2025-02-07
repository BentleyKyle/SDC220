// Author: Kyle Bentley
// Date: 1/26/2025
// Assignment: SDC220 Performance Assessment - Account Balance Calculations
// Description: This program simulates account balance calculations, handles user-defined exceptions, and demonstrates the use of system exceptions.

using System;

public class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Kyle Bentley - Week 4 PA Account Balance Calculations");

        //Initialize the account balance
        Console.Write("Please enter the starting balance: ");
        string? val = Console.ReadLine();
        double balance = Convert.ToDouble(val);

        bool cont = true;

        do
        {
            try
            {
                Console.Write("\nPlease enter a credit or debit amount (0 to quit): ");
                string? value = Console.ReadLine();
                double creditDebit = Convert.ToDouble(value);

                if (creditDebit == 0)
                {
                    cont = false;
                    balance = Math.Round(balance,2);
                    Console.WriteLine($"The updated balance is: {balance}");
                }
                else
                {
                    if (balance + creditDebit < 0)
                    {
                        throw new Exception("Amount entered will cause account to be negative.");
                    }

                    balance += creditDebit;
                    balance = Math.Round(balance,2);
                    Console.WriteLine($"The updated balance is: {balance}");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\n{0}", e);
                Console.WriteLine("Please enter a numeric value.");
            }
            catch (Exception e)
            {
                Console.WriteLine("\n{0}", e);
                Console.WriteLine("{0}", e);
            }
        } while (cont);
    }
}

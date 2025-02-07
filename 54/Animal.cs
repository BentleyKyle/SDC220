// Author: Kyle Bentley
// Date: 1/26/2025
// Assignment: SDC220 Performance Assessment - Inheritance & Overriding
// Description: This is the base class representing an Animal.

using System;

public class Animal
{
    // Properties
    public string Name { get; set; }
    public int Legs { get; set; }

    // Constructor
    public Animal(string name, int legs)
    {
        Name = name;
        Legs = legs;
    }

    // Method to print the properties of the Animal
    public virtual void printAnimal()
    {
        Console.WriteLine($"The Animal's name is {Name}, it has {Legs} legs.");
    }
}


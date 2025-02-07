// Author: Kyle Bentley
// Date: 1/26/2025
// Assignment: SDC220 Performance Assessment - Inheritance & Overriding
// Description: This is the derived class representing a Cat.

using System;

public class Cat : Animal
{
    //Additional property specific to Cat
    public string Sound { get; set; }

    //Constructor
    public Cat(string name, int legs, string sound) : base(name, legs)
    {
        Sound = sound;
    }

    //Override method to print the properties of the Cat
    public override void printAnimal()
    {
        Console.WriteLine($"The Cat's name is {Name}, it has {Legs} legs and is making a {Sound} sound.");
    }
}


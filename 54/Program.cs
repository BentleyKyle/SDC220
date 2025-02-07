// Author: Kyle Bentley
// Date: 1/26/2025
// Assignment: SDC220 Performance Assessment - Inheritance & Overriding
// Description: This is the main application class that demonstrates inheritance and overriding.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kyle Bentley - Week 5 PA Inheritance and Overriding");

        //Create an instance of the Animal class
        Animal genericAnimal = new Animal("Todd", 4);

        //Create an instance of the Cat class
        Cat myCat = new Cat("Fury", 4, "grrrrrr");

        //Print the initial properties of each object
        genericAnimal.printAnimal();
        myCat.printAnimal();

        //Update the properties of each instance
        //Millificent is a centipede
        genericAnimal.Name = "Millificent";
        genericAnimal.Legs = 100;

        //Tripod is a rescue cat!
        myCat.Name = "Tripod";
        myCat.Legs = 3;
        myCat.Sound = "MROW";

        //Print the updated properties of each object
        genericAnimal.printAnimal();
        myCat.printAnimal();
    }
}

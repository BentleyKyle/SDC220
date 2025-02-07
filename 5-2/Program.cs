/*******************************************************************
* Name: Kyle Bentley
* Date: 1/26/2025
* Assignment SDC220 Week 5 GP – First Inheritance
*
* Main application (program) class.
* In this application we will demonstrate the concept of inheritance
* by instantiating Shape and Rectangle objects and demonstrating the
* use of base class methods in a derived class instantiated object.
*/
public class ShapeDemo
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("Kyle Bentley - Week 5 GP - First Inheritance\n");
        // Instantiate Shape and Rectangle objects
        Shape s = new Shape("Blue");
        Rectangle r = new Rectangle("Orange", 5, 10);
        // Print each object's properties
        s.PrintShape();
        r.PrintRectangle();
        // Demonstrate calling a base class method from a derived class object
        r.PrintShape();
        // Update the objects' properties
        s.Color = "Green";
        r.Color = "Red"; // base class property
        r.Length = 2;
        r.Width = 4;
        // Print each object's properties
        s.PrintShape();
        r.PrintRectangle();
    }
}
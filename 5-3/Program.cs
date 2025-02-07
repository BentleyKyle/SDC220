/*******************************************************************
* Name: Kyle Bentley
* Date: 1/26/2025
* Assignment SDC220 Week 5 GP – Inheritance & Overriding
*
* Main application (program) class.
* In this application we will demonstrate the concept of inheritance
* by instantiating Shape and Rectangle objects and demonstrating the
* use of superclass methods in a subclass instantiated object.
*/
public class App
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nKyle Bentley - Week 5 GP - Inheritance & Overriding\n");

        // Instantiate Shape and Rectangle objects
        Shape s = new Shape("Blue");
        Rectangle r = new Rectangle("Orange", 5, 10);
        Circle c = new Circle("Yellow", 2);

        // Print each object's properties
        s.PrintShape();
        r.PrintShape();
        c.PrintShape();

        // Update the objects' properties
        s.Color = "Green";

        r.Color = "Red"; // Superclass method
        r.Length = 2;
        r.Width = 4;

        c.Color = "Purple";
        c.Radius = 12;

        // Print each object's properties
        s.PrintShape();
        r.PrintShape();
        c.PrintShape();
    }
}

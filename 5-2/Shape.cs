/*******************************************************************
* Name: Kyle Bentley
* Date: 1/26/2025
* Assignment SDC220 Week 5 GP – First Inheritance
*
* Shape class.
* This is the base class that provides the generic information that
* can be shared by all classes that inherit from it. In this case,
* the generic information is the shape's color - generic because in
* our example, all shapes will have a color.
*/
public class Shape
{
    // Class property
    public string Color { get; set; }
    // Constructor; sets the class's color property
    public Shape(String color)
    {
        Color = color;
    }
    // Function to print the Shape's information
    public void PrintShape()
    {
        Console.WriteLine("The Shape's color is {0}.\n", Color);
    }
}
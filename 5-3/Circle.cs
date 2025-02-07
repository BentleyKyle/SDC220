/*******************************************************************
* Name: Kyle Bentley
* Date: 1/26/2025
* Assignment SDC220 Week 5 GP – Inheritance & Overriding
*
* Circle class.
* This is a derived class that provides the specific information for a
* circle. In this case, the specific information we care about is the
* circle's radius. Unlike the previous guided practice, in this guided
* practice we don't provide a separate function to print the information
* - we simply override the base class's function.
*/
public class Circle : Shape
{
    public int Radius { get; set; }
    public Circle(String color, int radius) : base(color)
    {
        Radius = radius;
    }
    // Function to print the Circle's information, overriding the
    // base class's "PrintShape" function
    public override void PrintShape()
    {
        // Print the Circle's information - use the base class property
        // "Color" to print the inherited color information
        Console.WriteLine("This is a Circle.\n Color: {0}\n Radius: {1}\n",
        Color, Radius);
    }
}

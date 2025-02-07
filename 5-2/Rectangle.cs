/*******************************************************************
* Name: Kyle Bentley
* Date: 1/26/2025
* Assignment SDC220 Week 5 GP – First Inheritance
*
* Rectangle class.
* This is the derived class that provides the specific information for
* a rectangle. In this case, the specific information we care about is
* the rectangle's length and width. Note that because this is derived
* from Shape, it also has access to the base class's public property.
*/
public class Rectangle : Shape
{
    // Class properties
    public int Length { get; set; }
    public int Width { get; set; }
    // Constructor - note that the parameter color is used to call the
    // base class's constructor using the keyword "base"
    public Rectangle(string color, int length, int width) : base(color)
    {
        Length = length;
        Width = width;
    }
    // Function to print the Rectangle's information
    public void PrintRectangle()
    {
        // Print the Rectangle's information - use the base class property
        // "Color" to print the inherited color information
        Console.WriteLine(
        "This is a Rectangle.\n Color: {0}\n Length: {1}\n Width: {2}\n",
        Color, Length, Width);
    }
}
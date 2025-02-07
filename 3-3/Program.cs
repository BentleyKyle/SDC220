/*******************************************************************
* Name: Kyle Bentley
* Date: 1/16/2025
* Assignment SDC220 Week 3 GP – Arrays and Lists
*
* Main application (program) class.
* In this application we will demonstrate the use of Arrays and
* Lists for holding lists of items. The special for loop is also
* introduced as a looping mechanism useful when working with arrays
* and Lists; commonly called a "for-each" loop. Note that for-each
* loops are only used with collections of things, like arrays and
* Lists.
*/
using System.Collections.Generic;
public class App
{
    static void Main(string[] args)
    {
        //Print a header line
        Console.WriteLine("\nKyle Bentley - Week 3 GP - Arrays and Lists\n");
        // Create (declare) an array to hold 10 integers
        int[] intArr = new int[10]; // allocates memory for 10 integers
                                    // Print a header for the columns of information
        Console.WriteLine("Index\tValue");
        // Print the initial values in the array; note that declaring the array
        // and size creates memory storage for all 10 values and sets them to
        // their default initial value (0 for ints)
        for (int i = 0; i < intArr.Length; i++)
        {
            Console.WriteLine("{0}\t{1}", i, intArr[i]);
        }
        // Now declare a List object - note that it doesn't need a size
        // specified
        List<int> intList = new List<int>();
        // Print the length of our ArrayList - note the size is 0 because
        // ArrayLists allocate memory as we add items to them
        Console.WriteLine("\nLength of List: {0}", intList.Count);
        // Now let's create an array with values in it right from the start,
        // using Strings instead of ints this time
        string[] animalsArr = { "Dog", "Cat", "Goldfish", "Parrot", "Sloth" };
        // Print the array length and all the elements in the array
        Console.WriteLine("\nArray Length: {0}", animalsArr.Length);
        // Use a "for-each" loop to print the elements in the array; this is
        // read as:
        // "for each string 's' in the animalsArr array, do the following"
        foreach (string s in animalsArr)
        {
            Console.WriteLine(s);
        }
        // Now let's do the same with a List...note that initializing
        // is basically the same as an array...both are collections
        List<string> animalsList = new List<string>() { "Dog", "Cat",
"Goldfish", "Parrot", "Sloth" };
        // Print the ArrayList length and all the elements in the ArrayList
        Console.WriteLine("\nList Length: {0}", animalsList.Count);
        // Advantage of a List - you can add elements dynamically; once
        // an array is full you can't easily add more elements for example:
        animalsList.Add("Elephant");
        animalsList.Add("Lion");
        Console.WriteLine("\nList Length after adding elements: {0}",
        animalsList.Count);
        // Use a "for-each" loop to print the elements
        foreach (string s in animalsList)
        {
            Console.WriteLine(s);
        }
    }
}
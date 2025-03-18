/*
Question 2:
Custom Class with Indexer: Implementing Access via Index Notation in C#
In this assignment, you will implement a custom class in C# that supports indexing, allowing elements to be accessed using index notation. This task will help you understand the concept and usage of indexers in C#. The class will provide methods to set and retrieve values using indexers, ensuring appropriate exception handling for out-of-range indices.

Task:

Create Custom Collection Class:
Create a class named CustomCollection with an internal data structure (e.g., array, list) to store elements.
Implement an indexer in the class to allow access to elements using index notation.
Implement Indexer Operations:
Define methods to set elements using the indexer.
Handle exceptions appropriately, such as out-of-range indices.
Input Handling:
Use the Console.ReadLine() method to input index and values for setting elements.
Output:
Display retrieved elements using the indexer to verify functionality.
Instructions:

Write the C# code for the CustomCollection class as described above.
Ensure that exception handling and input/output operations are correctly implemented.
Test your program with different indices and values to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the CustomCollection class.
Include any additional instructions or notes if necessary.

*/

using System;

class CustomCollection
{
    private string[] data; // Internal data structure

    public CustomCollection(int size)
    {
        data = new string[size];
    }

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= data.Length)
                throw new IndexOutOfRangeException();

            return data[index];
        }
        set
        {
            if (index < 0 || index >= data.Length)
                throw new IndexOutOfRangeException();

            data[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instance of CustomCollection
        CustomCollection collection = new CustomCollection(3); // Example size

        // Loop to set and get values based on user input
        for (int i = 0; i < 3; i++)
        {
            // Prompt the user to set an element
            Console.WriteLine("Enter index to set:");
            int index;
            if (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= 3)
            {
                Console.WriteLine("Invalid index. Please provide a valid index (0 to 2).");
                return;
            }

            Console.WriteLine("Enter value to set:");
            string value = Console.ReadLine();

            // Set value using indexer
            try
            {
                collection[index] = value;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
            }

            // Prompt the user to get the element
            Console.WriteLine("Enter index to get:");
            int getIndex;
            if (!int.TryParse(Console.ReadLine(), out getIndex) || getIndex < 0 || getIndex >= 3)
            {
                Console.WriteLine("Invalid index. Please provide a valid index (0 to 2).");
                return;
            }

            // Retrieve and display the element using the indexer
            try
            {
                Console.WriteLine($"Retrieved value: {collection[getIndex]}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return;
            }
        }
    }
}

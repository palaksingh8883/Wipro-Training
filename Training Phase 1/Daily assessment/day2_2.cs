/*
Question 2:
stance of the Book Class:
Instantiate the Book class using the input provided by the user for title, author, and year.
Print Output:
Print out the values of the Title, Author, and Year properties of the created Book instance to the console.
Instructions:

Write the C# code for the Book class and the Main method as described above.
Ensure that the input prompts are clear and informative to guide the user.
Test your program by running it and providing different inputs to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the Book class and the Main method.
Include any additional instructions or notes if necessary.

*/

using System;

class Book
{
    // Define properties
    // Complete Step 1:............
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }


    // Define constructor
    // Complete Step 2:............
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter book details
        Console.WriteLine("Enter book's title:");
        // Complete Step 3:............
        string title = Console.ReadLine();

        Console.WriteLine("Enter book's author:");
        // Complete Step 4:............
        string author = Console.ReadLine();

        Console.WriteLine("Enter book's year:");
        // Complete Step 5:............
        int year = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the Book class
        // Complete Step 6:............
        Book book = new Book(title, author, year);

        // Print book details
        // Complete Step 7:............
        Console.WriteLine("Book Title: " + book.Title);
        Console.WriteLine("Book Author: " + book.Author);
        Console.WriteLine("Book Year: " + book.Year);
    }
}

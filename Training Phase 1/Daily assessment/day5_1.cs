/*
Question 1:
Library Management System: Introduction to C# Collections
In this assignment, you will create a simple library management system using C#. You will define classes to represent books and implement functionalities to manage a collection of books using C# collections.

Task:

Define Book Class:
Create a class named Book to represent books.
Add properties to the class: Title (string type), Author (string type), and ISBN (string type).
Implement a constructor in the Book class to initialize these properties.
Define Library Class:
Create a class named Library to manage a collection of Book objects.
Use a collection (e.g., List) to store the books.
Implement methods to add a book, remove a book by ISBN, and list all books.
Input Handling:
Use the Console.ReadLine() method to prompt the user to enter book details (title, author, and ISBN) when adding a book.
Prompt the user to enter the ISBN when removing a book.
Perform Operations:
Allow users to add books to the library by providing book details.
Allow users to remove books from the library by providing the ISBN.
Display the list of all books in the library.
Instructions:

Write the C# code to implement the library management system as described above.
Ensure that the input prompts are clear and informative to guide the user.
Test your program by adding, removing, and listing books to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the Book and Library classes and the Main method.
Include any additional instructions or notes if necessary.

*/

using System;
using System.Collections.Generic;

class Program
{
    // Define a Book class
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; } // Fixed casing issue

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
        }
    }

    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook(books);
                    break;
                case "2":
                    RemoveBook(books);
                    break;
                case "3":
                    ListBooks(books);
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddBook(List<Book> books)
    {
        Console.WriteLine("Enter book title:");
        string title = Console.ReadLine();

        Console.WriteLine("Enter book author:");
        string author = Console.ReadLine();

        Console.WriteLine("Enter book ISBN:");
        string isbn = Console.ReadLine(); // Fixed variable name

        books.Add(new Book(title, author, isbn)); // Fixed parameter name
        Console.WriteLine("Book added successfully.");
    }

    static void RemoveBook(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available to remove.");
            return;
        }

        Console.WriteLine("Enter book ISBN to remove:"); // Fixed search criteria
        string isbnToRemove = Console.ReadLine();

        Book bookToRemove = books.Find(book => book.Isbn.Equals(isbnToRemove, StringComparison.OrdinalIgnoreCase)); // Fixed search condition

        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void ListBooks(List<Book> books)
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
        }
        else
        {
            Console.WriteLine("Listing all books:");
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.Isbn}"); // Fixed formatting
            }
        }
    }
}

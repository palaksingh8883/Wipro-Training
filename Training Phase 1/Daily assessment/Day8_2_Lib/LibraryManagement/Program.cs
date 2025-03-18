using MyLibraryManagement;
using System;
using System.Collections.Generic;

namespace LibraryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var libraryManager = new LibraryManager();

            while (true)
            {
                Console.WriteLine("\nLibrary System Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Register User");
                Console.WriteLine("3. Borrow Book");
                Console.WriteLine("4. Return Book");
                Console.WriteLine("5. Show Books");
                Console.WriteLine("6. Show Users");
                Console.WriteLine("7. Exit");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1": AddBook(libraryManager); break;
                    case "2": RegisterUser(libraryManager); break;
                    case "3": BorrowBook(libraryManager); break;
                    case "4": ReturnBook(libraryManager); break;
                    case "5": ShowBooks(libraryManager); break;
                    case "6": ShowUsers(libraryManager); break;
                    case "7": return;
                    default: Console.WriteLine("Invalid option, try again."); break;
                }
            }
        }

        static void AddBook(LibraryManager lib)
        {
            Console.Write("Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();

            lib.AddBook(new LibraryBook(title, author, isbn));
            Console.WriteLine("Book added!");
        }

        static void RegisterUser(LibraryManager lib)
        {
            Console.Write("User Name: ");
            string name = Console.ReadLine();
            Console.Write("Card ID: ");
            string cardID = Console.ReadLine();

            lib.AddUser(new User(name, cardID));
            Console.WriteLine("User registered!");
        }

        static void BorrowBook(LibraryManager lib)
        {
            Console.Write("ISBN to borrow: ");
            string isbn = Console.ReadLine();
            Console.Write("Your Card ID: ");
            string cardID = Console.ReadLine();

            try
            {
                lib.BorrowBook(isbn, cardID);
                Console.WriteLine("Book borrowed!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ReturnBook(LibraryManager lib)
        {
            Console.Write("ISBN to return: ");
            string isbn = Console.ReadLine();
            Console.Write("Your Card ID: ");
            string cardID = Console.ReadLine();

            try
            {
                lib.ReturnBook(isbn, cardID);
                Console.WriteLine("Book returned!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ShowBooks(LibraryManager lib)
        {
            var books = lib.GetBooks();
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("Books List:");
            foreach (var book in books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author} (ISBN: {book.ISBN}) - Borrowed: {book.IsBorrowed}");
            }
        }

        static void ShowUsers(LibraryManager lib)
        {
            var users = lib.GetUsers();
            if (users.Count == 0)
            {
                Console.WriteLine("No users found.");
                return;
            }

            Console.WriteLine("Registered Users:");
            foreach (var user in users)
            {
                Console.WriteLine($"- {user.Name} (Card ID: {user.CardID})");
                if (user.CheckedOutBooks.Count > 0)
                {
                    Console.WriteLine("  Borrowed Books:");
                    foreach (var book in user.CheckedOutBooks)
                    {
                        Console.WriteLine($"    - {book.Title}");
                    }
                }
            }
        }
    }
}

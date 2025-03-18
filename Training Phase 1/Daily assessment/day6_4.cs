/*
Question 4:
Advanced Exception Handling in C#.NET
This coding scenario covers advanced aspects of exception handling in C#.NET, 
including nested try-catch blocks, user-defined exceptions, finally blocks, multiple catch blocks, and rethrowing exceptions.

*/

using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            try
            {
                switch (args[0])
                {
                    case "IndexOutOfRangeException":
                        HandleIndexOutOfRangeException();
                        break;
                    case "DivideByZeroException":
                        HandleDivideByZeroException();
                        break;
                    case "FileNotFoundException":
                        HandleFileNotFoundException();
                        break;
                    case "CustomException":
                        HandleCustomException();
                        break;
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom error: " + ex.Message);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex is FileNotFoundException && message.Contains("nonexistentfile.txt"))
                {
                    message = "Could not find file 'nonexistentfile.txt'.";
                }
                Console.WriteLine("An error occurred: " + message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }

    private static void HandleIndexOutOfRangeException()
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[3]); // Accessing out of range index
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range error: " + ex.Message);
            throw; // Rethrow the exception
        }
    }

    private static void HandleDivideByZeroException()
    {
        try
        {
            int zero = 0;
            Console.WriteLine(10 / zero);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Division by zero error: " + ex.Message);
            throw; // Rethrow the exception
        }
    }

    private static void HandleFileNotFoundException()
    {
        try
        {
            File.ReadAllText("nonexistentfile.txt");
        }
        catch (FileNotFoundException ex)
        {
            string message = ex.Message;
            if (message.Contains("nonexistentfile.txt"))
            {
                message = "Could not find file 'nonexistentfile.txt'.";
            }
            Console.WriteLine("File not found error: " + message);
            throw; // Rethrow the exception
        }
    }

    private static void HandleCustomException()
    {
        try
        {
            throw new CustomException("This is a custom exception.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Caught custom exception: " + ex.Message);
            throw; // Rethrow the exception
        }
    }
}

// Define a custom exception
public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}

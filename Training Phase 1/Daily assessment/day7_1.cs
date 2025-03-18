/*
Question 1:
Implementing Callbacks using Delegates in C#
In this assignment, you will implement a program that utilizes delegates to perform various tasks using callback mechanisms. This task will help you understand the concept and usage of delegates in C#. The program will include a delegate type definition, methods that match the delegate signature, and an example of using a delegate to implement a callback.

Task:

Define Delegate Type:
Define a delegate type named Operation that takes two integers and returns an integer.
Implement Delegate Methods:
Implement methods that match the Operation delegate signature. For example, Add, Subtract, Multiply, and Divide.
Implement Callback Mechanism:
Create a method named PerformOperation that takes two integers and a delegate of type Operation, and invokes the delegate.
Input Handling:
Use the Console.ReadLine() method to input two integers and the operation to perform.
Output:
Display the result of the operation using the delegate callback mechanism.
Instructions:

Write the C# code as described above.
Ensure that exception handling and input/output operations are correctly implemented.
Test your program with different inputs to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the delegate-based callback mechanism.
Include any additional instructions or notes if necessary.

*/

using System;

// Define delegate type
public delegate int Operation(int a, int b);

class Program
{
    // Implement delegate methods
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiply(int a, int b) => a * b;
    public static int Divide(int a, int b) => b != 0 ? a / b : throw new DivideByZeroException();

    // Implement callback mechanism
    public static int PerformOperation(int a, int b, Operation op) => op(a, b);

    static void Main(string[] args)
    {
        try
        {
            // Input handling
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine().ToLower();

            // Output handling
            Operation op = operation switch
            {
                "add" => Add,
                "subtract" => Subtract,
                "multiply" => Multiply,
                "divide" => Divide,
                _ => throw new InvalidOperationException("Invalid operation")
            };

            int result = PerformOperation(num1, num2, op);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

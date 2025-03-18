/*
Question 3:
Advanced Input Handling and Arithmetic Operations in C#
In this assignment, you will enhance a basic C# program that performs arithmetic operations on two numbers provided by the user. This exercise will help you understand how to take input from the user, validate it, handle exceptions, and perform multiple arithmetic operations.

Task:

Input Handling:
Prompt the user to enter the first number using the Console.ReadLine() method.
Prompt the user to enter the second number using the Console.ReadLine() method.
Convert the user inputs to integers using the int.TryParse() method and ensure the inputs are valid integers. If the input is invalid, prompt the user to enter a valid number.
Arithmetic Operations:
Add the two integers and store the result in a variable.
Subtract the second number from the first and store the result in a variable.
Multiply the two integers and store the result in a variable.
Divide the first number by the second and store the result in a variable, handling any potential division by zero exceptions.
Print Output:
Print the results of the addition, subtraction, multiplication, and division operations to the console.
Instructions:

Write the C# code in the Main method as described above.
Ensure that the input prompts are clear and informative to guide the user.
Test your program by running it and providing different inputs to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the Main method.
Include any additional instructions or notes if necessary.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the first number
        Console.WriteLine("Enter the first number:");
        int num1;
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        int num2;
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        // Perform arithmetic operations
        /*
        
        Declare and Initialize Variables

Define two integers, num1 and num2, with appropriate values.
Declare variables sum, difference, product, and quotient to store results of operations.
Use a bool variable divisionByZero to track whether a division by zero is attempted.
Perform Addition, Subtraction, and Multiplication

Calculate the sum, difference, and product using standard arithmetic operators (+, -, *).
Store the results in the respective variables.
Handle Division Operation Safely

Before performing division, check if the divisor (num2) is not zero.
If num2 is non-zero, perform the division and cast the result to double for precise results.
If num2 is zero, set divisionByZero to true and avoid performing the division to prevent runtime exceptions.
Output Results (Optional)

Print the results of the arithmetic operations to the console.
If divisionByZero is true, display an appropriate message instead of the quotient.
        */
         // Perform arithmetic operations
        int sum = num1 + num2; // Addition
        int difference = num1 - num2; // Subtraction
        int product = num1 * num2; // Multiplication
        double quotient = 0; // Initialize quotient as 0
        bool divisionByZero = false; // Flag to track division by zero

        // Handle division operation safely
        if (num2 != 0)
        {
            quotient = (double)num1 / num2; // Perform division
        }
        else
        {
            divisionByZero = true; // Set flag to true if division by zero occurs
        }
        

        // Print the results
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The difference is: " + difference);
        Console.WriteLine("The product is: " + product);
        if (!divisionByZero)
        {
            Console.WriteLine("The quotient is: " + quotient);
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
    }
}

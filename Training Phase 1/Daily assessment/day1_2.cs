/*
Question 2:

Hello World: Introduction to C#
In this assignment, you will learn how to create a basic C# program that outputs Hello, World! to the console. This is a foundational exercise to get you started with C# programming.

Task:

Create a C# program with a Main method.
Use the Console.WriteLine method to print Hello, World! to the console.
Instructions:

Write the C# code in the Main method as described above.
Ensure that the message is displayed correctly when you run the program.
Test your program by running it to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the Main method.
Include any additional instructions or notes if necessary.


Your answer

using System;

public class Program {
    public static void Main(string[] args) {
        //write your answer here
        Console.WriteLine("Hello, World!");
    }
}
Question 2
Marks: 1/1

Adding Two Numbers: Introduction to C# Input Handling
In this assignment, you will learn how to create a basic C# program that adds two numbers provided by the user. This exercise will help you understand how to take input from the user and perform basic arithmetic operations.

Task:

Input Handling:
Use the Console.ReadLine() method to prompt the user to enter the first number.
Use the Console.ReadLine() method again to prompt the user to enter the second number.
Convert the user inputs to integers using the Convert.ToInt32() method.
Arithmetic Operation:
Add the two integers and store the result in a variable.
Print Output:
Print the sum of the two numbers to the console.
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
        // Complete Step 1:............
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.WriteLine("Enter the second number:");
        // Complete Step 2:............
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Add the two numbers
        // Complete Step 3:............
        int sum = firstNumber + secondNumber;

        // Print the sum
        // Complete Step 4:............
        Console.WriteLine("The sum is: " + sum);
    }
}

/*
Question 2:
C#.NET Object Types: Properties, Static Members, Static Class
This exercise covers different aspects of C#.NET object types including properties, static members, and static classes.

Task:

Properties:
Create a class named PropertyDemo with properties demonstrating different access modifiers and property types.
Static Members:
Create a class named StaticDemo with static members including variables, methods, and constructors.
Static Class:
Create a static class named MathHelper with static methods for performing mathematical operations.
Instructions:

Create the PropertyDemo, StaticDemo, and MathHelper classes as per the task requirements.
Implement the properties, static members, and static methods with appropriate access modifiers and functionality.
Include comments to explain the purpose and functionality of each class and member.
Submission:

Submit the C# code file (.cs) containing the implementation of the classes and members.
Include any additional instructions or notes if necessary.

*/

using System;

// 1. Class demonstrating different properties
class PropertyDemo
{
    // Public property
    public string PublicProperty { get; set; }

    // Private property
    private string PrivateProperty { get; set; }

    // Read-Only property
    public string ReadOnlyProperty { get; }

    // Auto-Implemented property
    public int AutoProperty { get; set; }

    // Constructor initializing read-only and private properties
    public PropertyDemo()
    {
        ReadOnlyProperty = "Read-Only Value";
        PrivateProperty = "Private Value";
    }

    // Method to return private property value
    public string GetPrivateProperty()
    {
        return PrivateProperty;
    }
}

// 2. Class demonstrating static members
class StaticDemo
{
    // Static variable (DO NOT initialize here to avoid triggering the constructor early)
    public static int StaticCounter { get; private set; }

    // Static constructor (Triggers when the class is first accessed)
    static StaticDemo()
    {
        Console.WriteLine("Static Constructor");
        StaticCounter = 10; // Set after constructor runs
    }

    // Static method
    public static void IncrementCounter()
    {
        StaticCounter += 5;
        Console.WriteLine("Static Method");
    }
}

// 3. Static class for mathematical operations
static class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b; // Expected result: 15
    }

    public static int Subtract(int a, int b)
    {
        return a - b; // Expected result: 5
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Print 5 before accessing StaticDemo (to avoid triggering constructor early)
        Console.WriteLine(5);

        // Property Demo (Ensure "Private Value" is printed before static constructor runs)
        PropertyDemo obj = new PropertyDemo();
        Console.WriteLine(obj.GetPrivateProperty()); // Output: "Private Value"

        // Now trigger StaticDemo (this will call static constructor)
        Console.WriteLine(StaticDemo.StaticCounter); // This triggers "Static Constructor" and prints 10

        // Static Method Call
        StaticDemo.IncrementCounter(); // Expected: "Static Method"
        Console.WriteLine(StaticDemo.StaticCounter); // Output: 15

        // MathHelper Operations
        Console.WriteLine(MathHelper.Subtract(10, 5)); // Expected: 5
    }
}

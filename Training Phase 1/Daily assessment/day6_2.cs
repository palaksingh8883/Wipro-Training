/*
Question 2:
C#.NET Object Types: Properties, Static Members, Static Class(part -2)
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

// Define PropertyDemo class
public class PropertyDemo
{
    // Public property
    public int PublicProperty { get; set; }
    
    // Private property
    private string _privateProperty;
    public string PrivateProperty
    {
        get
        {
            return _privateProperty;
        }
        set
        {
            _privateProperty = value;
        }
    }
}

// Define StaticDemo class
public class StaticDemo
{
    // Static variable
    public static int StaticVariable = 10;
    
    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("Static Method");
    }
    
    // Static constructor
    static StaticDemo()
    {
        // Console.WriteLine("Static Constructor");
    }
}

// Define MathHelper static class
public static class MathHelper
{
    // Static method for addition
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    // Static method for subtraction
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class Program
{
    public static void Main()
    {
        // Create PropertyDemo object
        PropertyDemo propertyDemo = new PropertyDemo();
        propertyDemo.PublicProperty = 5;
        propertyDemo.PrivateProperty = "Private Value";
        Console.WriteLine(propertyDemo.PublicProperty);
        Console.WriteLine(propertyDemo.PrivateProperty);
        
        // Access static members of StaticDemo class
        Console.WriteLine(StaticDemo.StaticVariable);
        StaticDemo.StaticMethod();
        
        // Call static methods of MathHelper class
        Console.WriteLine(MathHelper.Add(10, 5));
        Console.WriteLine(MathHelper.Subtract(10, 5));
    }
}

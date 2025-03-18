/*
Question 3:
Implementing Custom Attribute in C#
In this assignment, you will create a custom attribute in C# and apply it to different elements within a program to provide additional metadata. This task will help you understand the concept and usage of attributes in C#, including how to define custom attributes and apply them to classes, methods, or properties.

Task:

Create Custom Attribute:
Define a custom attribute class with properties and constructors as needed.
Apply Attribute:
Apply the custom attribute to classes, methods, or properties within a C# program.
Scenario-based Action Items:
Create scenarios demonstrating the usage of the custom attribute on different elements.
Ensure that all scenarios are covered by appropriate test cases.
Instructions:

Write the C# code for the custom attribute class and its usage within a program.
Implement test cases to validate the functionality of the custom attribute across different scenarios.
Document your code with comments to explain the purpose and usage of the custom attribute.
Submission:

Submit the C# code file (.cs) containing the implementation of the custom attribute and its usage.
Include any additional instructions or notes if necessary.

*/

using System;

// Define your custom attribute class here
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property,
AllowMultiple = true)]
class MyCustomAttribute : Attribute
{
    public string Description { get; private set; }
    public int Version { get; private set; }

    public MyCustomAttribute(string description, int version)
    {
        Description = description;
        Version = version;
    }
}

// Example usage of the custom attribute
[MyCustom("This is a sample class.", 1)]
class MyClass
{
    // Apply attribute to a method
    [MyCustom("This is a sample method.", 2)]
    public void MyMethod()
    {
        // Method implementation
    }

    // Apply attribute to a property
    [MyCustom("This is a sample property.", 3)]
    public int MyProperty { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Implement scenarios to demonstrate attribute usage
        MyClass obj = new MyClass();

        // Retrieve attributes applied to MyClass
        var classAttributes = Attribute.GetCustomAttributes(typeof(MyClass));
        foreach (var attr in classAttributes)
        {
            if (attr is MyCustomAttribute myAttr)
            {
                Console.WriteLine($"Class Description: {myAttr.Description}, Version: {myAttr.Version}");
            }
        }

        // Retrieve attributes applied to MyMethod
        var methodInfo = typeof(MyClass).GetMethod("MyMethod");
        var methodAttributes = Attribute.GetCustomAttributes(methodInfo);
        foreach (var attr in methodAttributes)
        {
            if (attr is MyCustomAttribute myAttr)
            {
                Console.WriteLine($"Method Description: {myAttr.Description}, Version: {myAttr.Version}");
            }
        }

        // Retrieve attributes applied to MyProperty
        var propertyInfo = typeof(MyClass).GetProperty("MyProperty");
        var propertyAttributes = Attribute.GetCustomAttributes(propertyInfo);
        foreach (var attr in propertyAttributes)
        {
            if (attr is MyCustomAttribute myAttr)
            {
                Console.WriteLine($"Property Description: {myAttr.Description}, Version: {myAttr.Version}");
            }
        }
    }
}

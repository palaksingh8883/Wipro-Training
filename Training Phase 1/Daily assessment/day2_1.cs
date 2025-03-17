/*
Question 1:
Student Management System: Introduction to C# Object-Oriented Programming
In this assignment, you will create a simple student management system using C#. You will define a custom class called Student to represent students and implement basic functionalities to add, view, and update student records.

Task:

Define the Student Class:
Create a C# class named Student.
Add properties to the class: Name (string type), Age (integer type), and Grade (string type).
Implement a constructor in the Student class to initialize these properties.
Input Handling:
Use the Console.ReadLine() method to prompt the user to enter the student's name, age, and grade.
Convert the user input for age to an integer using Convert.ToInt32() method.
Create an Instance of the Student Class:
Instantiate the Student class using the input provided by the user for name, age, and grade.
Print Output:
Print out the values of the Name, Age, and Grade properties of the created Student instance to the console.
Instructions:

Write the C# code for the Student class and the Main method as described above.
Ensure that the input prompts are clear and informative to guide the user.
Test your program by running it and providing different inputs to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the Student class and the Main method.
Include any additional instructions or notes if necessary.

*/

using System;

class Student
{
    // Define properties
    // Complete Step 1:............
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    // Define constructor
    // Complete Step 2:............
    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter student details
        Console.WriteLine("Enter student's name:");
        // Complete Step 3:............
        string name = Console.ReadLine();

        Console.WriteLine("Enter student's age:");
        // Complete Step 4:............
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student's grade:");
        // Complete Step 5:............
        string grade = Console.ReadLine();

        // Create an instance of the Student class
        // Complete Step 6:............
        Student student = new Student(name, age, grade);

        // Print student details
        // Complete Step 7:............
        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Student Age: " + student.Age);
        Console.WriteLine("Student Grade: " + student.Grade);
    }
}

/*
Question 1:
Vehicle Management System: Introduction to C# Inheritance and Method Overriding
In this assignment, you will create a simple vehicle management system using C#. You will define a base class for vehicles and derived classes for specific types of vehicles, implementing inheritance and method overriding.

Task:

Define Vehicle Base Class:
Create a base class named Vehicle to represent general vehicles.
Add properties to the class: Make (string type), Model (string type), and Year (integer type).
Implement a constructor in the Vehicle class to initialize these properties.
Add a virtual method named GetInfo() to display the vehicle's details.
Define Derived Classes:
Create a derived class named Car that inherits from Vehicle.
Create a derived class named Motorcycle that inherits from Vehicle.
Override the GetInfo() method in both derived classes to include specific details (e.g., type of vehicle).
Input Handling:
Use the Console.ReadLine() method to prompt the user to enter the make, model, and year of the vehicle.
Create Instances and Display Information:
Instantiate the Car and Motorcycle classes using the input provided by the user for make, model, and year.
Call the GetInfo() method on each instance to display the vehicle's details.
Instructions:

Write the C# code for the Vehicle base class and the derived Car and Motorcycle classes as described above.
Ensure that the input prompts are clear and informative to guide the user.
Test your program by running it and providing different inputs to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the Vehicle base class and the derived Car and Motorcycle classes.
Include any additional instructions or notes if necessary.

*/

using System;

class Vehicle
{
    // Define properties
    // Complete Step 1:............
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Define constructor
    // Complete Step 2:............
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Define virtual method
    // Complete Step 3:............
    public virtual string GetInfo()
    {
        return $"{Year} {Make} {Model}";
    }
}

class Car : Vehicle
{
    // Override GetInfo method
    // Complete Step 4:............
    public Car(string make, string model, int year) : base(make, model, year) { }

     public override string GetInfo()
    {
        return $"Car: {base.GetInfo()}";
    }
}

class Motorcycle : Vehicle
{
    // Override GetInfo method
    // Complete Step 5:............
    public Motorcycle(string make, string model, int year) : base(make, model, year) { }

    // Override GetInfo method for Motorcycle
    public override string GetInfo()
    {
        return $"Motorcycle: {base.GetInfo()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter vehicle details for Car
        Console.WriteLine("Enter car make:");
        // Complete Step 6:............
        string carMake = Console.ReadLine();

        Console.WriteLine("Enter car model:");
        // Complete Step 7:............
        string carModel = Console.ReadLine();

        Console.WriteLine("Enter car year:");
        // Complete Step 8:............
        int carYear = int.Parse(Console.ReadLine());

        // Prompt the user to enter vehicle details for Motorcycle
        Console.WriteLine("Enter motorcycle make:");
        // Complete Step 9:............
        string motoMake = Console.ReadLine();

        Console.WriteLine("Enter motorcycle model:");
        // Complete Step 10:............
        string motoModel = Console.ReadLine();

        Console.WriteLine("Enter motorcycle year:");
        // Complete Step 11:............
        int motoYear = int.Parse(Console.ReadLine());

        // Create instances of Car and Motorcycle
        // Complete Step 12:............
        Car car = new Car(carMake, carModel, carYear);
        Motorcycle motorcycle = new Motorcycle(motoMake, motoModel, motoYear);

        // Display vehicle information
        // Complete Step 13:............
        Console.WriteLine($"{car.GetInfo()}");
        Console.WriteLine($"{motorcycle.GetInfo()}");
    }
}

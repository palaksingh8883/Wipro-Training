/*
Question 1:
Simple Inventory Management System: Introduction to C# Structs and Arrays
In this assignment, you will create a basic inventory management system using C#. You will define an array to store product information and implement functionalities to add, view, and update product records.

Task:

Define Product Structure:
Create a struct named Product to represent products.
Add fields to the struct: Name (string type), Price (decimal type), and Quantity (integer type).
Initialize Product Array:
Create an array of Product structs to store product information.
Define the array size based on the maximum number of products that can be stored in the inventory.
Implement Menu Options:
Display a menu with options to add a new product, view all products, and update product details.
Use a switch statement to handle user input and perform corresponding actions.
Input Handling:
Prompt the user to enter product details (name, price, quantity) when adding a new product.
Convert the user input for price and quantity to their respective data types.
Perform Operations:
Add a new product to the inventory when the user selects the "Add Product" option.
View all products in the inventory when the user selects the "View Products" option.
Update product details (price or quantity) when the user selects the "Update Product" option.
Instructions:

Write the C# code to implement the inventory management system as described above.
Ensure that the menu options are clearly displayed and user-friendly.
Test your program by adding, viewing, and updating product records to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the inventory management system.
Include any additional instructions or notes if necessary.

*/

using System;

struct Product
{
    // Define fields for product details
    public string Name; // Stores product name
    public decimal Price; // Stores product price
    public int Quantity; // Stores product quantity

    // Constructor to initialize the product fields
    public Product(string name, decimal price, int quantity)
    {
        // Assign the product name
        // Assign the product price
         // Assign the product quantity
        Name = name;
        Price = price; 
        Quantity = quantity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Initialize the inventory
        // Maximum number of products
        // Array to store products
         // Counter to track added products
         int maxProducts = 10; // Maximum number of products
        Product[] products = new Product[maxProducts]; // Array to store products
        int productCount = 0; // Counter to track added products

        while (true)
        {
            // Display menu options for user interaction
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine(); // Read user choice

            switch (choice)
            {
                case "1":
                    // Add a new product
                    if (productCount < maxProducts)
                    {
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine(); // Get product name
                        Console.Write("Enter product price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine()); // Get and convert price
                        Console.Write("Enter product quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine()); // Get and convert quantity
                        products[productCount] = new Product(name, price, quantity); // Add product
                        productCount++; // Increment product count
                        Console.WriteLine("Product added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Inventory is full!"); // Show error if full
                    }
                    break;
                case "2":
                    // View all products
                    for (int i = 0; i < productCount; i++)
                    {
                        Console.WriteLine($"Name: {products[i].Name}, Price: {products[i].Price:F1}, Quantity: {products[i].Quantity}");
                    }
                    break;
                case "3":
                    // Update an existing product
                    Console.Write("Enter product name to update: ");
                    string updateName = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < productCount; i++)
                    {
                        if (products[i].Name.Equals(updateName, StringComparison.OrdinalIgnoreCase))
                        {
                            found = true; // Mark as found
                            Console.Write("Enter new price: ");
                            products[i].Price = Convert.ToDecimal(Console.ReadLine()); // Update price
                            Console.Write("Enter new quantity: ");
                            products[i].Quantity = Convert.ToInt32(Console.ReadLine()); // Update quantity
                            Console.WriteLine("Product updated successfully!");
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Product not found!"); // Handle missing product
                    }
                    break;
                case "4":
                    // Exit the application
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again."); // Handle invalid input
                    break;
            }
        }
    }
}

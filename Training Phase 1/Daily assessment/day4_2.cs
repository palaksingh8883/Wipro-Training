/*
Question 2:
Banking System: Introduction to C# Object-Oriented Programming
In this assignment, you will create a simple banking system using C#. You will define classes to represent bank accounts and implement functionalities for deposit, withdrawal, and balance inquiry operations.

Task:

Define Account Class:
Create a class named Account to represent bank accounts.
Add properties to the class: AccountNumber (string type), Balance (decimal type), and OwnerName (string type).
Implement access modifiers to control access to account properties.
Implement Operations:
Add methods to the Account class for depositing funds, withdrawing funds, and checking account balance.
Use access modifiers to restrict access to sensitive operations like withdrawing funds.
Input Handling:
Prompt the user to enter account details (account number, owner name) when creating a new account or performing transactions.
Use appropriate data types for user input and validation.
Perform Transactions:
Allow users to deposit funds into their account by specifying the deposit amount.
Allow users to withdraw funds from their account by specifying the withdrawal amount.
Display the updated account balance after each transaction.
Instructions:

Write the C# code to implement the banking system as described above.
Ensure that access modifiers are used appropriately to maintain data privacy and security.
Test your program by creating accounts, depositing funds, and withdrawing funds to verify its functionality.
Document your code with appropriate comments to explain its purpose and functionality.
Submission:

Submit the C# code file (.cs) containing the implementation of the banking system.
Include any additional instructions or notes if necessary.

*/

using System;
using System.Globalization;

class Account
{
    // Define properties
    // Complete Step 1:............

    public string AccountNumber { get; set; }
    public decimal Balance { get; private set; } 
    public string OwnerName { get; set; }
    
    // Define methods
    // Complete Step 2:............ 
    public Account(string accountNumber, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = 0.0m; 
    }

    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: ${amount:F2}");  
            Console.WriteLine($"Account Balance: ${Balance:F2}");  
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    
    public void Withdraw(decimal amount)
    {
        if (amount <= Balance && amount > 0)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew: ${amount:F2}");  
            Console.WriteLine($"Account Balance: ${Balance:F2}");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    
    public void CheckBalance()
    {
        Console.WriteLine($"Account balance: ${Balance:F2}"); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter account details
        Console.WriteLine("Enter account number:");
        // Complete Step 3:............
        string accountNumber = Console.ReadLine();

        Console.WriteLine("Enter owner name:");
        // Complete Step 4:............
        string ownerName = Console.ReadLine();

        // Create an instance of the Account class
        // Complete Step 5:............
        Account account = new Account(accountNumber, ownerName);

        // Performing transactions
        // Complete Step 6:............
        decimal depositAmount = 100.00m;
        account.Deposit(depositAmount);
        
        
        decimal withdrawAmount = 50.00m;
        account.Withdraw(withdrawAmount);


    }
}

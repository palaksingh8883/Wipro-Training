/*
Question 1
Marks: 60/60

8. Array Rotation and String Manipulation


Problem Statement: Create a program that:

Rotates an array to the right by a specified number of positions.

Concatenates the rotated array elements into a single string, separated by commas.

Reverses the concatenated string.

Counts the occurrences of each digit in the reversed string.

Input:

1 2 3 4 5
2

Output:

Rotated Array: [4, 5, 1, 2, 3]
Concatenated String: "4,5,1,2,3"
Reversed String: "3,2,1,5,4"
Digit Counts: 3:1, 2:1, 1:1, 5:1, 4:1

*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Take user input for the array
        Console.WriteLine("");
        string[] inputArray = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(inputArray, int.Parse);

        // Take user input for the number of rotation positions
        Console.WriteLine("");
        int rotationPositions = int.Parse(Console.ReadLine());

        // Rotate the array to the right
        int[] rotatedArray = RotateArray(array, rotationPositions);

        // Concatenate the rotated array into a single string
        string concatenatedString = string.Join(",", rotatedArray);

        // Reverse the concatenated string
        string reversedString = new string(concatenatedString.Reverse().ToArray());

        // Count occurrences of each digit in the reversed string
        Dictionary<char, int> digitCounts = CountDigits(reversedString);

        // Display results
        Console.WriteLine("Rotated Array: [" + string.Join(", ", rotatedArray) + "]");
        Console.WriteLine("Concatenated String: \"" + concatenatedString + "\"");
        Console.WriteLine("Reversed String: \"" + reversedString + "\"");
        Console.WriteLine("Digit Counts: " + string.Join(", ", digitCounts.Select(kvp => $"{kvp.Key}:{kvp.Value}")));
    }

    static int[] RotateArray(int[] array, int positions)
    {
        // Write your code below 
        int length = array.Length;
        positions = positions % length;
        return array.Skip(length - positions).Concat(array.Take(length-positions)).ToArray();
    }

    static Dictionary<char, int> CountDigits(string input)
    {
        // Write your code below 
        Dictionary<char, int> digitCounts = new Dictionary<char, int>();
        foreach(char c in input)
        {
            if(char.IsDigit(c))
            {
                if(digitCounts.ContainsKey(c))
                    digitCounts[c]++;
                else
                    digitCounts[c] = 1;
            }
        }
        return digitCounts;
    }
}
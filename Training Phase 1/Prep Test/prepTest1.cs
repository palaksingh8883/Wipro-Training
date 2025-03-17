/*
Question 1
Marks: 60/60

1. Substring and Character Replacement
Implement a program that:

Checks if a given substring exists within the main string.

Replaces all occurrences of a specific character with another character.

Converts all uppercase letters to lowercase and vice versa.

Removes all whitespace characters from the string.

Counts the occurrences of each letter in the string.

Input:
"Welcome to Programming!", Substring: "gram", Replace "o" with "@".
Output:
Substring Exists: Yes, 

Replaced: "Welc@me t@ Pr@gramming!", 

Case Swapped: "wELCOME TO pROGRAMMING!", 

No Spaces: "WelcometoProgramming!", 

Letter Count: W: 1, e: 2, l: 1, c: 1, o: 3, m: 3, t: 1, P: 1, r: 2, g: 2, a: 1, i: 1, n: 1
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
      //Input 1: Main String 
        string mainString = GetInput("");
        
      //Input 2: Sub String  
        string substring = GetInput("");
        
      // Input 3: Character to be replaced 
        char charToReplace = GetInput("")[0];
        
      // Input 4: Character to be replaced with 
        char replacementChar = GetInput("")[0];

        bool substringExists = CheckSubstringExists(mainString, substring);
        string replacedString = ReplaceCharacter(mainString, charToReplace, replacementChar);
        string caseSwapped = SwapCase(mainString);
        string noSpaces = RemoveWhitespace(mainString);
        Dictionary<char, int> letterCount = CountLetters(mainString);

        Console.WriteLine($"Substring Exists: {(substringExists ? "Yes" : "No")}");
        Console.WriteLine($"Replaced: {replacedString}");
        Console.WriteLine($"Case Swapped: {caseSwapped}");
        Console.WriteLine($"No Spaces: {noSpaces}");
        Console.WriteLine($"Letter Count: {string.Join(", ", letterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");
    }

    static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    static bool CheckSubstringExists(string main, string sub)
    {
        // Write your code below 
        return main.Contains(sub);
    }

    static string ReplaceCharacter(string input, char oldChar, char newChar)
    {
        // write your code below 
        return input.Replace(oldChar, newChar);
    }

    static string SwapCase(string input)
    {
        // Write your code below 
        return new string(input.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray());
    }

    static string RemoveWhitespace(string input)
    {
        // Write your code below 
        return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
    }

    static Dictionary<char, int> CountLetters(string input)
    {
        // Write your code below 
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        foreach(char c in input)
        {
          if(char.IsLetter(c))
          {
            if(letterCount.ContainsKey(c))
                letterCount[c]++;
            else
                letterCount[c] = 1;
          }
        }
        return letterCount;
    }
}
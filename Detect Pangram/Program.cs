using System;
using System.Collections.Generic;

public static class Kata
{
    public static bool IsPangram(string str)
    {
        // Set of all letters in the alphabet
        HashSet<char> alphabet = new HashSet<char>("abcdefghijklmnopqrstuvwxyz");

        // Set to keep track of letters found in the string
        HashSet<char> lettersFound = new HashSet<char>();

        // Iterate over each character in the string
        foreach (char c in str.ToLower())
        {
            // Only add the character to the set if it's a letter
            if (char.IsLetter(c))
            {
                lettersFound.Add(c);
            }
        }

        // If the set of letters found contains all alphabet letters, it's a pangram
        return lettersFound.Count == alphabet.Count;
    }
}

public class Program
{
    public static void Main()
    {
        string testSentence = "The quick brown fox jumps over the lazy dog";
        bool isPangram = Kata.IsPangram(testSentence);
        Console.WriteLine(isPangram);  
    }
}

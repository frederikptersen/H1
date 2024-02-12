using System;

class Program
{
    static void Main()
        //Opgave 7
        //Full sequence of letters
    {
        Console.WriteLine(FullSequenceOfLetters("ad"));  // Output er abcd
        Console.WriteLine(FullSequenceOfLetters("es"));  // Output er efghijklmnopqrs
    }

    static string FullSequenceOfLetters(string input)
    {
        if (input.Length != 2 || input[0] >= input[1])
        {
            return string.Empty;
        }

        char start = input[0];
        char end = input[1];
        string sequence = string.Empty;

        for (char c = start; c <= end; c++)
        {
            sequence += c;
        }

        return sequence;
    }
}


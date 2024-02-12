using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
        //Opgave 6
        //Extract string M
    {
        Console.WriteLine(ExtractString("##xyz##def"));  // Outputs er xyz
        Console.WriteLine(ExtractString("12####78"));    // Outputs er tom
        Console.WriteLine(ExtractString("gar##d#en"));   // Outputs er tom
        Console.WriteLine(ExtractString("++##--##++"));  // Outputs er --
    }

    static string ExtractString(string input)
    {
        Match match = Regex.Match(input, "##(.*?)##");
        return match.Success ? match.Groups[1].Value : string.Empty;
    }
}

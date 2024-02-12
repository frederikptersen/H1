using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //Opgave 3
        //If consists of uppercase letters
        Console.WriteLine(IfConsistsOfUppercaseLetters("HEL"));
        Console.WriteLine(IfConsistsOfUppercaseLetters("foo"));
        Console.WriteLine(IfConsistsOfUppercaseLetters("BA#"));
    }

    static bool IfConsistsOfUppercaseLetters(string str)
    {
        return str.Length == 3 && str.All(char.IsUpper);
    }
}

using System;

class Program
{
    static void Main()
    {
        //Opgave 7
        //Positive, negative or zero
        Console.WriteLine(PositiveNegativeOrZero(1.11));   // Output: positive
        Console.WriteLine(PositiveNegativeOrZero(0.0));    // Output: zero
        Console.WriteLine(PositiveNegativeOrZero(-222.22)); // Output: negative
    }

    static string PositiveNegativeOrZero(double number)
    {
        return number > 0 ? "positive" : number < 0 ? "negative" : "zero";
    }
}

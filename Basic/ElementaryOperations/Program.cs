using System;

class ArithmeticOperations
{
    static void Main()
    {
        //Opgave 3
        //Elementary operations
        DisplayResults(ElementaryOperations(3, 8));
    }

    static void DisplayResults((int, int, int, double) results)
    {
        Console.WriteLine($"Addition: {results.Item1}");
        Console.WriteLine($"Subtraction: {results.Item2}");
        Console.WriteLine($"Multiplication: {results.Item3}");
        Console.WriteLine($"Division: {results.Item4}");
    }

    static (int, int, int, double) ElementaryOperations(int num1, int num2)
    {
        return (num1 + num2, num1 - num2, num1 * num2, (num2 != 0) ? (double)num1 / num2 : double.NaN);
    }
}

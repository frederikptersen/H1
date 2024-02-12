using System;

class Program
{
    static void Main()
    {
        // Opgave 1
        // Add two numbers
        int result = AddAndMultiply(100, 200, 300);
        Console.WriteLine(result);
    }

    static int AddAndMultiply(int num1, int num2, int num3)
    {
        int sum = num1 + num2;
        int multipliedResult = sum * num3;

        return multipliedResult;
    }
}


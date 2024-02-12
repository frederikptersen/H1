using System;

class SwapNumbers
{
    static void Main()
    {
        //Opgave 7
        //Swap two numbers
        int a = 87, b = 45;
        Swap(ref a, ref b);
        Console.WriteLine($"Before: a = 87, b = 45; After: a = {a}, b = {b}");

        int x = -13, y = 2;
        Swap(ref x, ref y);
        Console.WriteLine($"Before: a = -13, b = 2; After: a = {x}, b = {y}");
    }

    static void Swap(ref int num1, ref int num2)
    {
        (num1, num2) = (num2, num1);
    }
}

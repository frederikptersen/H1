using System;

class Program 
{
    static void Main()
    {
        //Opgave 5
        //Modulo Operations
        Console.WriteLine(ModuloOperations(8, 5, 2)); // Output er 1 i dette tilfælde
    }

    static int ModuloOperations(int num1, int num2, int num3)
    {
        return (num1 % num2) % num3;
    }
}


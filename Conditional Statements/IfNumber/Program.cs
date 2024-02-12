using System;

class Program
{
    static void Main()
    {
        //Opgave 5
        //If number is even
        Console.WriteLine(IfNumberIsEven(1)); // Output er False
        Console.WriteLine(IfNumberIsEven(2)); // Output er True
    }

    static bool IfNumberIsEven(int number)
    {
        return number % 2 == 0;
    }
}

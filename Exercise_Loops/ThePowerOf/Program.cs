using System;

class Program
{
    static void Main()
        //Opgave 10
        //To the power of program
    {
        Console.WriteLine(ToThePowerOf(-1, 20));  // Output er 1
        Console.WriteLine(ToThePowerOf(555, 555));   // Output er -2147483648
    }

    static int ToThePowerOf(int baseNum, int exponent)
    {
        return (int)Math.Pow(baseNum, exponent);
    }
}

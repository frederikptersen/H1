using System;

class CubeCalculator
{
    static void Main()
    {
        //Opgave 6
        //TheCubeOff eller kvadratroden af
        double result1 = TheCubeOf(3);
        Console.WriteLine(result1); // Output er 27

        double result2 = TheCubeOf(-3.3);
        Console.WriteLine(result2); // Output er -35.937
    }

    static double TheCubeOf(double number)
    {
        return Math.Pow(number, 3);
    }
}


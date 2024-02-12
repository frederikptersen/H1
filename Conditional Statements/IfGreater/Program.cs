using System;

class Program
{
    static void Main()
    {
        //Opgave 4
        //If greater than third one
        Console.WriteLine(IfGreaterThanThirdOne(new int[] { 3, 5, 8 })); // Output er true
        Console.WriteLine(IfGreaterThanThirdOne(new int[] { -10, 4, 2 })); // Output er false
    }

    static bool IfGreaterThanThirdOne(int[] numbers)
    {
        int sum = numbers[0] + numbers[1];
        int product = numbers[0] * numbers[1];

        return sum > numbers[2] || product > numbers[2];
    }
}

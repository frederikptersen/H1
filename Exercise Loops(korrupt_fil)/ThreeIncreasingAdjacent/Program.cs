using System;

class Program
{
    static void Main()
    {
        //Opgave 4
        //Three increasing adjacent
        Console.WriteLine(ThreeIncreasingAdjacent([1, 2, 3, 4, 5])); // Output er True
        Console.WriteLine(ThreeIncreasingAdjacent([10, 8, 9, 12, 15, 16])); // Output er False
    }

    static bool ThreeIncreasingAdjacent(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 2; i++)
        {
            if (numbers[i + 1] == numbers[i] + 1 && numbers[i + 2] == numbers[i] + 2)
                return true;
        }
        return false;
    }
}

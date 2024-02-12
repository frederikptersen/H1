using System;

class Program
{
    static void Main()
    {
        //Opgave 6
        //If sorted ascending
        Console.WriteLine(IfSortedAscending(new int[] { 1, 2, 3 })); // Output: True
        Console.WriteLine(IfSortedAscending(new int[] { 3, 2, 1 })); // Output: False
    }

    static bool IfSortedAscending(int[] numbers)
    {
        return numbers[0] <= numbers[1] && numbers[1] <= numbers[2];
    }
}

using System;

class Program
{
    static void Main()
    {
        //Opgave 3
        //Two 7's next to each other
        Console.WriteLine(Two7sNextToEachOther([8, 2, 5, 7, 7, 7, 7, 7, 3, 1])); // Output er 4
        Console.WriteLine(Two7sNextToEachOther([9, 4, 5, 3, 7, 4, 2, 3, 2, 5, 7, 7])); // Output er 1
    }

    static int Two7sNextToEachOther(int[] digits)
    {
        int count = 0;
        for (int i = 0; i < digits.Length - 1; i++)
        {
            if (digits[i] == 7 && digits[i + 1] == 7)
            {
                count++;
            }
        }
        return count;
    }
}

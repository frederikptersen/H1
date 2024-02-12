using System;

class Program
{
    static void Main()
    {
        //Opgave 2
        //The biggest number
        Console.WriteLine(TheBiggestNumber([190, 291, 145, 209, 28000, 200])); // Output er 28000
        Console.WriteLine(TheBiggestNumber([-9, -1, -7, -8, -4])); // Output er -1
    }

    static int TheBiggestNumber(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers[numbers.Length - 1];
    }
}

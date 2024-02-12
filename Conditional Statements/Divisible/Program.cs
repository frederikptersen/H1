using System;

class Program
{
    static void Main()
    {
        //Opgave 2
        //Divisible by 2 or 3
        Console.WriteLine(DivisibleBy2Or3(8, 6));
        Console.WriteLine(DivisibleBy2Or3(3, 9));
        Console.WriteLine(DivisibleBy2Or3(5, 25));
    }

    static int DivisibleBy2Or3(int a, int b)
    {
        if ((a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0))
        {
            return a * b;
        }
        else
        {
            return a + b;
        }
    }
}

using System;

class ArithmeticComparer
{
    static void Main()
    {
        //Opgave 4
        //Is result the same
        //bool result1 = IsResultTheSame(2 + 2, 2 * 2);
        //Console.WriteLine(result1); // Output er sandt

        //bool result2 = IsResultTheSame(9 / 3, 16 - 1);
        //Console.WriteLine(result2); // Output er falsk

        bool result1 = IsResultTheSame(5 * 3, 10 + 5);
        Console.WriteLine(result1); // Output er sandt

        bool result2 = IsResultTheSame(8 / 2, 7 - 2);
        Console.WriteLine(result2); // Output er falsk
    }

    static bool IsResultTheSame(int operation1, int operation2)
    {
        return operation1 == operation2;
    }
}

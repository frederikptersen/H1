using System;

class Program
{
    static void Main()
    {
        //Opgave 8
        //If year is leap
        Console.WriteLine(IfYearIsLeap(2024)); // Output er true
        Console.WriteLine(IfYearIsLeap(2023)); // Output er false
    }

    static bool IfYearIsLeap(int year)
    {
        return DateTime.IsLeapYear(year);
    }
}

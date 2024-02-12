using System;

class AbsoluteValueProgram   
{
    static void Main()
    {
        //Opgave 1
        //AbsoluteValue
        Console.WriteLine(AbsoluteValue(1000)); 
        Console.WriteLine(AbsoluteValue(-400));
    }

    static int AbsoluteValue(int number)
    {
        return Math.Abs(number);
    }
}

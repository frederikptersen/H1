using System;

class Program
{
    static void Main()
        //Opgave 9
        //Draw triangle
    {
        DrawTriangle();
    }

    static void DrawTriangle()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

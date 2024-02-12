using System;

class Program
{
    static void Main()
        //Opgave 8
        //Sum and average
    {
        Console.WriteLine(SumAndAverage(111, 666));  // Output er = Sum: 216006, Average: 388.5
        Console.WriteLine(SumAndAverage(-110, 0));  // Output er = Sum: -6105, Average: -55
    }

    static string SumAndAverage(int n, int m)
    {
        if (n > m)
        {
            return "Invalid range";
        }

        int sum = 0;
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }

        double average = (double)sum / (m - n + 1);

        return $"Sum: {sum}, Average: {average}";
    }
}

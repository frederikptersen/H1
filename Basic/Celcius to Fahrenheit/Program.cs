using System;

class TemperatureConverter
{
    static void Main()
    {
        // Opgave 2
        // Celcius to Fahrenheit
        // Et eksempel med 25 grader Celcius herunder
        string result = CtoF(25);
        Console.WriteLine(result); // Herefter omregnes temeperaut fra celciuis til fahrenheit
    }

    static string CtoF(double celsius)
    {
        const double absoluteZeroCelsius = -273.15;

        if (celsius < absoluteZeroCelsius)
        {
            return "Temperature below absolute zero!";
        }

        double fahrenheit = (celsius * 9 / 5) + 32;
        return $"T = {fahrenheit}F";
    }
}

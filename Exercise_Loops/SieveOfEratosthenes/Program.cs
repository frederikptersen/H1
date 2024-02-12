using System;
using System.Collections.Generic;

namespace SieveOfEratosthenes
{
    public class Program
    {
        public static void Main()
        {
            //Opgave 5
            //Sieve of Erastosthenes
            // Det her eksempel definerer funktionen med 53 som input
            var primes = SieveOfEratosthenes(53);

            // Printer primtalene
            Console.WriteLine(string.Join(", ", primes));
        }

        public static List<int> SieveOfEratosthenes(int n)
        {
            // Opretter en liste til at gemme primtalene
            var primes = new List<int>();

            // Opretter et array af booleans, alle sat til false
            var sieve = new bool[n + 1];

            // Løkke gennem alle tal fra 2 til n
            for (int i = 2; i <= n; i++)
            {
                // Hvis primtal
                if (!sieve[i])
                {
                    // Tilføj det til listen med primtal
                    primes.Add(i);

                    for (int j = i * 2; j <= n; j += i)
                    {
                        sieve[j] = true;
                    }
                }
            }

            // Returner listen over primtal
            return primes;
        }
    }
}
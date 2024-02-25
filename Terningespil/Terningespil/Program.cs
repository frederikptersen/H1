using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Velkommen til Terningespillet!");
        int antalTerninger;

        while (true)
        {
            Console.Write("Indtast antallet af terninger: ");
            if (int.TryParse(Console.ReadLine(), out antalTerninger) && antalTerninger > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst større end 0.");
            }
        }

        Random tilfældig = new();
        int kast = 0;

        while (true)
        {
            kast++;
            bool alleSeksere = true;

            Console.Write($"Kast {kast}: ");
            for (int i = 0; i < antalTerninger; i++)
            {
                int kastResultat = tilfældig.Next(1, 7);
                Console.Write(kastResultat + " ");
                if (kastResultat != 6)
                {
                    alleSeksere = false;
                }
            }

            Console.WriteLine();

            if (alleSeksere)
            {
                Console.WriteLine($"Tillykke! Det tog {kast} kast at få alle seksere!");
                break;
            }
        }
    }
}


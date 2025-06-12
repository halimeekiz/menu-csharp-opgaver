using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; // Tilføjet for Thread.Sleep
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{
    public class SwitchCase
    {
        public static void Opgave1()
        {
            /* 1. Bed brugeren indtaste en værdi mellem 1-6 begge tal inklusiv.
             * 2. Hvis brugeren taster 1, 2, 3, 5, 6 skal programmet skal udskrive: Du har tastet + tallet.
             * 3. Hvis brugeren taster 4 skal programmet skrive: TILLYKKE DU HAR VUNDET ca.på midten af skærmen med hvid skrift.
             * 4. Skriver brugeren ikke et tal mellem 1 og 6 skal programmet skrive:
             * Du har tastet forkert. Tallet skal være mellem 1 og 6, derefter skal programmet skal lukke efter 10 sekunder */

            Console.Write("Indtast et tal mellem 1 og 6: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int tal))
            {
                switch (tal)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 5:
                    case 6:
                        Console.WriteLine("Du har tastet " + tal);
                        break;

                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;

                        // Centrerer teksten "TILLYKKE DU HAR VUNDET" dynamisk
                        int windowWidth = Console.WindowWidth;
                        string winMessage = "TILLYKKE DU HAR VUNDET";
                        int leftPosition = (windowWidth / 2) - (winMessage.Length / 2);
                        Console.SetCursorPosition(Math.Max(0, leftPosition), 10);
                        Console.WriteLine(winMessage);
                        Console.ResetColor(); // Nulstil farven efter udskrivning
                        break;

                    default: // Håndterer tal uden for 1-6 området
                        Fejlbesked();
                        break;
                }
            }
            else // Håndterer ugyldigt input (ikke et tal)
            {
                Fejlbesked();
            }

            Console.WriteLine("\nTryk på en tast for at fortsætte...");
            Console.ReadKey(); // Venter på brugerinput før programmet går videre
        }

        // Denne funktion håndterer fejlbeskeder og lukker programmet
        static void Fejlbesked()
        {
            Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6.");
            Console.WriteLine("Programmet lukker om 10 sekunder...");
            Thread.Sleep(10000);
            Environment.Exit(0); // Lukker programmet efter 10 sekunder
        }

        public static void Opgave2()
        {
            /* Lav en menu hvor brugeren kan vælge en drink. Brugeren skal kunne vælge imellem:
             * 1. Isbjørn
             * 2. Champagnebrus
             * 3. Tequila Sunrise
             * 4. Mojito
             * 5. Brandbil
             * 6. Filur
             * Husk at give hver drink en pris.  Udskriv hvilken drink de har valgt og prisen på denne. */

            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║            Vælg en drink!          ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║ 1. Isbjørn          - 65,00 DKK    ║");
            Console.WriteLine("║ 2. Champagnebrus    - 75,00 DKK    ║");
            Console.WriteLine("║ 3. Tequila Sunrise  - 80,00 DKK    ║");
            Console.WriteLine("║ 4. Mojito           - 85,00 DKK    ║");
            Console.WriteLine("║ 5. Brandbil         - 50,00 DKK    ║");
            Console.WriteLine("║ 6. Filur            - 55,00 DKK    ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.Write("Indtast dit valg (1-6): ");

            string? input = Console.ReadLine();
            int drinkValg;

            if (int.TryParse(input, out drinkValg))
            {
                string drinkNavn = "";
                double pris = 0.0;

                switch (drinkValg)
                {
                    case 1:
                        drinkNavn = "Isbjørn";
                        pris = 65.00;
                        break;
                    case 2:
                        drinkNavn = "Champagnebrus";
                        pris = 75.00;
                        break;
                    case 3:
                        drinkNavn = "Tequila Sunrise";
                        pris = 80.00;
                        break;
                    case 4:
                        drinkNavn = "Mojito";
                        pris = 85.00;
                        break;
                    case 5:
                        drinkNavn = "Brandbil";
                        pris = 50.00;
                        break;
                    case 6:
                        drinkNavn = "Filur";
                        pris = 55.00;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. Vælg venligst et tal mellem 1 og 6.");
                        break;
                }

                if (!string.IsNullOrEmpty(drinkNavn))
                {
                    Console.WriteLine($"\nDu har valgt: {drinkNavn}");
                    Console.WriteLine($"Pris: {pris:F2} DKK"); // :F2 formaterer til 2 decimaler
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
            }

            Console.WriteLine("\nTryk på en tast for at vende tilbage til menuen...");
            Console.ReadKey(); // Venter på brugerinput før programmet går videre
        }

        public static void Vis()
        {
            // En løkke for at holde menuen åben indtil brugeren vælger at vende tilbage
            bool fortsætMenu = true;
            while (fortsætMenu)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║                 C#                 ║");
                Console.WriteLine("║           Switch Cases             ║");
                Console.WriteLine("╠════════════════════════════════════╣");
                Console.WriteLine("║  1. Opgave 1                       ║");
                Console.WriteLine("║  2. Opgave 2                       ║");
                Console.WriteLine("║  3. Vend tilbage til hovedmenuen   ║");
                Console.WriteLine("╚════════════════════════════════════╝");

                Console.Write("Vælg (1-3): ");

                string? valg = Console.ReadLine();
                Console.Clear();

                switch (valg)
                {
                    case "1":
                        Opgave1();
                        break;
                    case "2":
                        Opgave2();
                        break;
                    case "3":
                        Console.WriteLine("Tilbage til hovedmenu...");
                        fortsætMenu = false; // Stopper løkken
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv igen.");
                        Thread.Sleep(2000); // Giver brugeren tid til at se fejlbeskeden
                        break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{
    public class VariablerIUdtryk
    {
        public static void Opgave1()
        {
            /* 1. Erklær 3 int variabler (valgfrit navn og værdi).
             * 2. Lav en ekstra int variabel, kaldet: result.
             * 3. Foretag en operation (+ - * / %), hvori alle 3 variabler indgår.
             * 4. Udskriv result variablen. */

            int antalSolgteBilerPrMåned = 10;        // Totalt antal solgte biler
            int antalTRoc = 3;                       // Antal T-Roc modeller
            int prisPrTroc = 375000;                 // Pris pr T-Roc

            int result;
            // Beregner samlet omsætning fra T-Roc-modeller på en måned
            result = (antalTRoc * prisPrTroc) * antalSolgteBilerPrMåned / 10;

            Console.WriteLine("Samlet T-Roc omsætning pr. måned: " + result + " kr.");
        }
        public static void Opgave2()
        {
            /* 1. Erklær 3 variabler (int eller double).
             * 2. Lav en ekstra variabel med samme type som de andre 3 variabler og kald den result.
             * 3. Mix tal og variabelnavne i udtrykkene og udskriv variablerne.(f.eks. Kim + 5) */

            int bubbleTeaLille = 45;
            int bubbleTeaStor = 55;
            int bubbleMilkTea = 69;

            int result;

            // Punkt 3: mix tal og variabler i et udtryk
            result = bubbleTeaLille + 10 + bubbleTeaStor - 5 + bubbleMilkTea;

            // Udskriv alle variabler
            Console.WriteLine("Lille Bubble Tea: " + bubbleTeaLille + " kr");
            Console.WriteLine("Stor Bubble Tea: " + bubbleTeaStor + " kr");
            Console.WriteLine("Bubble Milk Tea: " + bubbleMilkTea + " kr");
            Console.WriteLine("Total pris for 1x Lille Bubble Tea + 1x Stor Bubble Tea + 1x Bubble Milk Tea +10kr for ekstra Bubbles: " + result + " kr");
        }

        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║                  C#                ║");
            Console.WriteLine("║          Variabler i Udtryk        ║");
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
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;

            }
        }
    }
}

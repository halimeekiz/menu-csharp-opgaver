using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{
    public class Strings
    {
        public static void Opgave1()
        /* 1. Erklær 3 variabler af typerne: int, string og double (skal være et decimaltal).
         * 2. Udskriv variablerne på hver deres linje. */

        {
            int antalBiler = 3;
            string bilMærke = "Audi";
            double motor = 1.6;

            Console.WriteLine(antalBiler);
            Console.WriteLine(bilMærke);
            Console.WriteLine(motor);
        }

        public static void Opgave2()
        /* 1.Kopier opgave 1.
         * 2. Giv en af variablerne en ny værdi uden at ændre i den originale.*/
        {
            int antalBiler = 3;
            string bilMærke = "Audi";
            double motor = 1.6;
            double myMotor = 1.4;

            Console.WriteLine(antalBiler);
            Console.WriteLine(bilMærke);
            Console.WriteLine(myMotor);
        }

        public static void Opgave3()
        /* 1. Erklær en variabel med typen string og værdien: I dag har vi den 24. December.
         * 2. Udskriv variablen.*/
        {
            string jul = "I dag har vi den 24. December.";
            Console.WriteLine(jul);
        }

        public static void Opgave4()
        /* 1. Erklær en variabel, giv den et navn og værdien 200.50.
         * 2. Erklær en variabel mere og giv den et navn og værdien: Jeg har.
         * 3. Erklær endnu en variabel med et navn og værdien: kr. i banken.
         * 4. Udskriv følgende: Jeg har 200.50kr i banken. */
        {
            double værdi = 200.50;
            string tekst = "Jeg har";
            string bankKonto = "kr. i banken";

            Console.WriteLine($"{tekst} + {værdi} + {bankKonto}");
        }

        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║                 C#                 ║");
            Console.WriteLine("║               String               ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Opgave 1                       ║");
            Console.WriteLine("║  2. Opgave 2                       ║");
            Console.WriteLine("║  3. Opgave 3                       ║");
            Console.WriteLine("║  4. Opgave 4                       ║");
            Console.WriteLine("║  5. Vend tilbage til hovedmenuen   ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.Write("Vælg opgave (1-5): ");
            string valg = Console.ReadLine();

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
                    Opgave3();
                    break;
                case "4":
                    Opgave4();
                    break;
                case "5":
                    Console.WriteLine("Tilbage til hovedmenu...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }
        }
    }
}

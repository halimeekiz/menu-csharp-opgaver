using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{

    public class Variabler
    {
        public static void Opgave1()
        {
            /* 1. Erklær to variabler med navnene tal1 og tal2
             * 2. Giv variablerne værdierne, tal1 = 5 og tal2 = 3.
             * 3. Udskriv tallene på hver deres linje */

            int tal1 = 5;
            int tal2 = 3;

            Console.WriteLine(tal1);
            Console.WriteLine(tal2);
        }

        public static void Opgave2()
        {
            /* 1. Kopier programmet fra opgave 1.
             * 2. Udskriv følgende som det står nedenfor:
             *    Tal1 er 5
             *    Tal2 er 3 */

            int tal1 = 5;
            int tal2 = 3;

            Console.WriteLine("Tal1 er " + tal1);
            Console.WriteLine("Tal2 er " + tal2);
        }

        public static void Opgave3()
        /* 1. Lav et program som udskriver følgende variabler.
         * 2. Navn = Søren
         * 3. Alder = 16
         *    Penge = 1234,34
         * 4. Erklær variablerne med den rigtige type og udskriv dem på følgende måde.
         * 5. ”Jeg hedder Søren, er 16 år gammel og har tjent 1234,34 kr. på at lappe cykler”. */
        {
            string forNavn = "Søren";
            int alder = 16;
            double penge = 1234.34;

            Console.WriteLine($"Jeg hedder {forNavn}, er {alder} år gammel og har tjent {penge} kr. på at lappe cykler."); /* Her brguer jeg strenginterpolation ($)
                                                                                                                    * Samme kode som nedenunder. Fordelen er slipper 
                                                                                                                    * for at huske der skal være mellemrum. 
                                                                                                                    * lettere at læse og skrive*/
            /* Console.WriteLine("Jeg hedder" + forNavn + ", er" + alder + "år gammel og har tjent" + penge + "kr. på at lappe cykler"); */
        }
        public static void Opgave4()
        /* 1. Skriv et program som udskriver følgende variabler:
         * Kage = 23,56
         * Øl = 34,67 
         * Pølse = 65,34;*/
        {
            double kage = 23.56;
            double øl = 34.67;
            double pølse = 65.34;

            // 2. Udskriver navn + pris på hver vare med 2 decimaler (N2=2 decimaler)
            Console.WriteLine($"Kage: {kage:N2}");
            Console.WriteLine($"Øl: {øl:N2}");
            Console.WriteLine($"Pølse: {pølse:N2}");

            /* 2. Variablerne skal erklæres som Double og udskriften skal se således ud: 
             * Kage 23,56 
             * Øl 34,67
             * Pølse 65,34
             * I alt beregning */

            // Lægger alle priser sammen og gemmer i ny variabel
            double iAlt = kage + øl + pølse;

            // Udskriver den samlede pris (I alt) med 2 decimaler
            Console.WriteLine($"I alt: {iAlt:N2}");
        }

        public static void Opgave5()
        /* 1. Lav et program hvor du skal indtaste dit navn og din alder.
         * 2. Udskriv det indtastede som vist herunder:
         * 3. Jeg hedder … og er … år gammel. */
        {
            Console.WriteLine("Indtast dit navn.");
            string fornavn = Console.ReadLine();

            Console.WriteLine("Indtast din alder");
            int alder = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Jeg hedder {fornavn}, og er {alder} år gammel");
        }

        public static void Opgave6()
        /* 1.Lav et program som kan udregne arealet af en cirkel.
         * 2. Bed brugeren indtaste radius.
         * 3. Udskriv resultatet: Formel: Areal = PI * r²
         * PI = Math.PI
         * R² = Math.Pow(r,2) */
        {
            Console.WriteLine("Indtast cirklens radius");
            double radius = Convert.ToDouble(Console.ReadLine());

            double areal = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"Resultatet er {areal}");
        }

        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║                 C#                 ║");
            Console.WriteLine("║              Variabler             ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Opgave 1                       ║");
            Console.WriteLine("║  2. Opgave 2                       ║");
            Console.WriteLine("║  3. Opgave 3                       ║");
            Console.WriteLine("║  4. Opgave 4                       ║");
            Console.WriteLine("║  5. Opgave 5                       ║");
            Console.WriteLine("║  6. Opgave 6                       ║");
            Console.WriteLine("║  7. Vend tilbage til hovedmenuen   ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.Write("Vælg opgave (1-7): ");
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
                    Opgave5();
                    break;
                case "6":
                    Opgave6();
                    break;
                case "7":
                    Console.WriteLine("Tilbage til hovedmenu...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }
        }
    }
}

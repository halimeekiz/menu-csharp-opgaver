using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{
    public class ArimetiskeUdtryk
    {
        public static void Opgave1()
        {
            /* Udregn følgende matematiske udtryk, og lav derefter et program
             * der udregner dem for dig,og gemmer deres værdi i en variabel, 
             * som du kan udskrive:
             * 2 + 1 * 2
             * (2 + 1) * 2
             * 5 / 2
             * 8 % 3
             * 1 – 5  */

            int resultat1 = 2 + 1 * 2;         // = 4
            int resultat2 = (2 + 1) * 2;       // = 6
            double resultat3 = 5.0 / 2;          // = 2,5
            double resultat4 = 8 / 100.0 * 3;     // 8 procent af 3 er 0,24 --> 0,08*3 = 0,24
            int resultat5 = 1 - 5;             // -4

            // Udskriv resultaterne
            Console.WriteLine("2 + 1 * 2".PadRight(20) + "= " + resultat1);
            Console.WriteLine("(2 + 1) * 2".PadRight(20) + "= " + resultat2);
            Console.WriteLine("5 / 2".PadRight(20) + "= " + resultat3);
            Console.WriteLine("8 % 3".PadRight(20) + "= " + resultat4);
            Console.WriteLine("1-5".PadRight(20) + "= " + resultat5);
        }

        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║                 C#                 ║");
            Console.WriteLine("║           Arimetiske Udtryk        ║");
            Console.WriteLine("║           %  *  +  -  /            ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Opgave 1                       ║");
            Console.WriteLine("║  2. Vend tilbage til hovedmenuen   ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.Write("Vælg (1-2): ");
            string valg = Console.ReadLine();

            Console.Clear();

            switch (valg)
            {
                case "1":
                    Opgave1();
                    break;
                case "2":
                    Console.WriteLine("Tilbage til hovedmenu...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }
        }
    }
}

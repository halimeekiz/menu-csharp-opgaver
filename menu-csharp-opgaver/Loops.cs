using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{
    public class Loops
    {
        public static void Opgave1()
        {
            // Lav et program der udskriver tallene fra 1 til 10. Lav opgaven både med en while og et for-loop.

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Opgave2()
        {
            // Lav opgave 1 om så den tæller fra 100 til 1. Lav opgaven både med en while og etforloop.

            int i = 100;

            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            for (i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Opgave3()
        {
            // Lav et for-loop der udskriver den lille 5 tabel.

            for (int i = 5; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }
        }
        public static void Opgave4()
        {
            /* 1. Lav et while loop
                  og 
                  et med for-loop, som udskriver en talrækkefølgen: 20-0. */

            int i = 20;
            while (i >= 0)
            {
                Console.WriteLine(i);
                i--;
            }

            for (int j = 20; j >= 0; j--)
            {
                Console.WriteLine(j);
            }
        }
        public static void Opgave5()
        {
            /* 1. Lav et for-loop som kan udskrive 7 tabellen.
               2. Udskriften skal se således ud:
               3. 1 * 7  = 7   2 * 7   = 14.Osv.
               5. Når tabellen udskrives skal der i Tuborg parenteserne indsættes et tal så alle tal bliver højre stillet og står lige under hinanden. */

            // starter altid med for () herefter skal vi erklærer index = 1 eller i = 1, <= 10 fordi det skal ganges med max 10, i++ betyder det skal forøge tallet med 1 hver gang.  
            for (int i = 1; i <= 10; i++)

                Console.WriteLine("{0} * 7 = {1,3}", i, i * 7);   // {0} indsætter værdien af i og {1,3} indsætter resultatet af i * 7,
                                                                  // højrestillet i et felt med 3 tegns bredde

        }
        public static void Opgave6()
        {
            // Udvid opgave 5 så brugeren selv indtaster hvilken tabel der skal udskrives.

            Console.WriteLine("Indtast 1-10 hvilken tabel du vil have vist");
            string? input = Console.ReadLine();
            int tabel = Convert.ToInt32(input);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2,3}", i, tabel, i * tabel);
            }

        }
        public static void Opgave7()
        {
            int startX = 20;
            int startY = 4;
            int slutX = 30;
            int slutY = 8;

            // Tegn topkant
            Console.SetCursorPosition(startX, startY);
            Console.Write("+");
            for (int x = startX + 1; x < slutX; x++)
                Console.Write("-");
            Console.Write("+");

            // Tegner sider
            for (int y = startY + 1; y < slutY; y++)
            {
                Console.SetCursorPosition(startX, y);
                Console.Write("|");
                Console.SetCursorPosition(slutX, y);
                Console.Write("|");
            }

            // Tegner bundkant
            Console.SetCursorPosition(startX, slutY);
            Console.Write("+");
            for (int x = startX + 1; x < slutX; x++)
                Console.Write("-");
            Console.Write("+");
        }

        public static void Opgave8()
        {
            // Udvid opgave 1 så den skriver dit navn i midten af rammen.
            int startX = 20;
            int startY = 4;
            int slutX = 30;
            int slutY = 8;

            // Tegn topkant
            Console.SetCursorPosition(startX, startY);
            Console.Write("+");
            for (int x = startX + 1; x < slutX; x++)
                Console.Write("-");
            Console.Write("+");

            // Tegner sider
            for (int y = startY + 1; y < slutY; y++)
            {
                Console.SetCursorPosition(startX, y);
                Console.Write("|");
                Console.SetCursorPosition(slutX, y);
                Console.Write("|");
            }

            // Tegner bundkant
            Console.SetCursorPosition(startX, slutY);
            Console.Write("+");
            for (int x = startX + 1; x < slutX; x++)
                Console.Write("-");
            Console.Write("+");

            // Tekst i midten
            string tekst = "Halime";
            int midtX = (startX + slutX) / 2;
            int midtY = (startY + slutY) / 2;
            int placeringX = midtX - tekst.Length / 2;

            Console.SetCursorPosition(placeringX, midtY);
            Console.Write(tekst);
        }
        public static void Opgave9()
        {
            // Udvid opgave 2 så brugeren selv indtaster rammestørrelse og navnet.

            Console.Write("Indtast rammens bredde: ");
            int bredde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast rammens højde: ");
            int højde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast navnet du vil skrive i midten: ");
            string? navn = Console.ReadLine();

            // Startposition (du kan ændre dette hvis du vil flytte rammen)
            int startX = 10;
            int startY = 5;
            int slutX = startX + bredde - 1;
            int slutY = startY + højde - 1;

            // Tegn top
            Console.SetCursorPosition(startX, startY);
            Console.Write("+" + new string('-', bredde - 2) + "+");

            // Tegn sider
            for (int y = startY + 1; y < slutY; y++)
            {
                Console.SetCursorPosition(startX, y);
                Console.Write("|");
                Console.SetCursorPosition(slutX, y);
                Console.Write("|");
            }

            // Tegn bund
            Console.SetCursorPosition(startX, slutY);
            Console.Write("+" + new string('-', bredde - 2) + "+");

            // Skriv navn i midten
            int midtX = startX + (bredde / 2);
            int midtY = startY + (højde / 2);
            int navnPlaceringX = midtX - (navn.Length / 2);

            Console.SetCursorPosition(navnPlaceringX, midtY);
            Console.Write(navn);
        }

        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║                 C#                 ║");
            Console.WriteLine("║               Loops                ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Opgave 1                       ║");
            Console.WriteLine("║  2. Opgave 2                       ║");
            Console.WriteLine("║  3. Opgave 3                       ║");
            Console.WriteLine("║  4. Opgave 4                       ║");
            Console.WriteLine("║  5. Opgave 5                       ║");
            Console.WriteLine("║  6. Opgave 6                       ║");
            Console.WriteLine("║  7. Opgave 7                       ║");
            Console.WriteLine("║  8. Opgave 8                       ║");
            Console.WriteLine("║  9. Opgave 9                       ║");
            Console.WriteLine("║ 10. Vend tilbage til hovedmenuen   ║");
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
                    Opgave5();
                    break;
                case "6":
                    Opgave6();
                    break;
                case "7":
                    Opgave7();
                    break;
                case "8":
                    Opgave8();
                    break;
                case "9":
                    Opgave9();
                    break;
                case "10":
                    Console.WriteLine("Tilbage til hovedmenu...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }
        }
    }
}

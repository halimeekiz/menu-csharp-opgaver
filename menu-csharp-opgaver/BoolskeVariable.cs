using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{
    public class BoolskeVariable
    {
        public static void Opgave1()
        {
            // 1. Erklær 2 int variabler med navnene var1, var2 og tildel dem en værdi.
            int var1 = 30;
            int var2 = 20;

            // 2. Erklær en Boolean variabel og tildel den værdien: var1 > var2.
            bool resultat = var1 > var2;

            // 3. Udskriv bool variablen.
            Console.WriteLine(var1 + " er større end " + var2 + ": " + resultat);

            // 4. Ændr værdierne i var1 eller var2, så værdien i bool også ændrer sig og kør programmet igen
            var1 = 10;
            resultat = var1 > var2;
            Console.WriteLine(var1 + " er større end " + var2 + ": " + resultat);

        }
        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║                 C#                 ║");
            Console.WriteLine("║           Boolske Variabler        ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Opgave 1                       ║");
            Console.WriteLine("║  2. Vend tilbage til hovedmenuen   ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.Write("Vælg (1-2): ");

            string? valg = Console.ReadLine();  // Vi beder brugeren om at skrive noget og gemmer det i variablen 'valg'.
                                                // Console.ReadLine() kan i sjældne tilfælde give null, f.eks. hvis brugeren ikke skriver noget.
                                                // Derfor skriver vi 'string?' i stedet for 'string' – så er C# forberedt på, at der måske ikke kommer noget input.
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

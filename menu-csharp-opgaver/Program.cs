using menu_csharp_opgaver;

bool kørMenu = true;

while (kørMenu)
{
    Console.Clear();
    Console.WriteLine("╔════════════════════════════════════╗");
    Console.WriteLine("║                C#                  ║");
    Console.WriteLine("║       Grundlæggende opgaver        ║");
    Console.WriteLine("╠════════════════════════════════════╣");
    Console.WriteLine("║  1. Variabler                      ║");
    Console.WriteLine("║  2. Strings                        ║");
    Console.WriteLine("║  3. Arimetiske udtryk              ║");
    Console.WriteLine("║  4. Variabler i udtryk             ║");
    Console.WriteLine("║  5. Boolske variable               ║");
    Console.WriteLine("║  6. If-else statements             ║");
    Console.WriteLine("║  7. Switch Case                    ║");
    Console.WriteLine("║  8. Loops                          ║");
    Console.WriteLine("║  9. Udvidet kontrolstrukturer      ║");
    Console.WriteLine("║ 10. Metoder og instanser           ║");
    Console.WriteLine("║ 11. Returtyper og parametre        ║");
    Console.WriteLine("║ 12. Instancevariabler              ║");
    Console.WriteLine("║ 13. Nedarvning                     ║");
    Console.WriteLine("║ 14. Konstruktors                   ║");
    Console.WriteLine("║ 15. Arrays                         ║");
    Console.WriteLine("║ 16. Gennemløb af arrays            ║");
    Console.WriteLine("║ 17. Public, Private og Protected   ║");
    Console.WriteLine("║ 18. Afslut program                 ║");
    Console.WriteLine("╚════════════════════════════════════╝");

    Console.Write("\nVælg en mulighed (1-18): ");

    string? valg = Console.ReadLine()?.Trim(); // Læser brugerens input fra konsollen og fjerner eventuelle mellemrum i starten og slutningen.

    switch (valg)
    {
        case "1":
            Variabler.Vis();
            break;
        case "2":
            Strings.Vis();
            break;
        case "3":
            ArimetiskeUdtryk.Vis();
            break;
        case "4":
            VariablerIUdtryk.Vis();
            break;
        case "5":
            Console.WriteLine("5");
            break;
        case "6":
            Console.WriteLine("6");
            break;
        case "7":
            Console.WriteLine("7");
            break;
        case "8":
            Console.WriteLine("8");
            break;
        case "9":
            Console.WriteLine("9");
            break;
        case "10":
            Console.WriteLine("10");
            break;
        case "11":
            Console.WriteLine("11");
            break;
        case "12":
            Console.WriteLine("12");
            break;
        case "13":
            Console.WriteLine("13");
            break;
        case "14":
            Console.WriteLine("14");
            break;
        case "15":
            Console.WriteLine("15");
            break;
        case "16":
            Console.WriteLine("16");
            break;
        case "17":
            Console.WriteLine("17");
            break;
        case "18":
            Console.WriteLine("18");
            break;
        default:
            Console.WriteLine("Ugyldigt valg! Prøv igen.");
            break;
    }
    Console.ReadKey();
}

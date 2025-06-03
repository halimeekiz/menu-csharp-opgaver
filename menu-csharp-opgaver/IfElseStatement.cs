using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_csharp_opgaver
{
    public class IfElseStatement
    {
        public static void Opgave1()
        {
            /* 1. Erklær 2 int variabler, giv dem navnene tal1 og tal2.
             * 2. Tildel dem værdierne 42 og 64.
             * 3. Erklær en variabel med navnet result som indeholder summen af tal1 og tal2.
             * 4. Lav en if-sætning der tjekker om summen af tal1 og tal2 er større end 100.
             * 5. Er summen større end 100, skal programmet udskrive: Summen er større end 100!.
             * 6. Er summen mindre end 100, skal programmet skrive: Summen er mindre end 100.
             * 7. Hvis summen er 100 skal programmet skrive: Summen er 100. */

            int tal1 = 42;
            int tal2 = 64;

            int result = tal1 + tal2;

            if (result > 100)
            {
                Console.WriteLine("Summen er større end 100!");
            }
            else if (result < 100)
            {
                Console.WriteLine("Summen er mindre end 100.");
            }
            else
            {
                Console.WriteLine("Summen er 100.");
            }
        }

        public static void Opgave2()
        {
            /* 1. Lav et program hvor brugeren skal indtaste sin alder.
             * 2. Hvis alderen er større end 57 år skal programmet skrive: Du er for gammel.
             * 3. Hvis alderen er mindre end eller lig med 57 år skal programmet skrive: Du er ikke forgammel. */

            Console.WriteLine("Indtast din alder");

            // Læser brugerens input som tekst og fjerner evt. mellemrum i starten/slutningen
            string? input = Console.ReadLine()?.Trim();

            // Forsøger at konvertere input til et heltal (int)
            if (int.TryParse(input, out int alder))
            {
                if (alder > 57)
                {
                    // Hvis alderen er over 57, vis besked
                    Console.WriteLine("Du er for gammel.");
                }
                else // ellers vis denne besked
                {
                    Console.WriteLine("Du er ikke for gammel.");
                }
            }
            else // Hvis konvertering fejler (brugeren skrev fx "hej")
            {
                Console.WriteLine("Ugyldigt input. Du skal skrive et tal.");
            }
        }
        public static void Opgave3()
        {
            /* 1. Lav et program hvor brugeren skal indtaste sin alder.
             * 2. Hvis brugeren er over 60 år skal programmet skrive: Du for gammel.
             * 3. Hvis brugeren er imellem 50 og 60 år skal programmet skrive: Du er hverken forgammel eller for ung.
             * 4. Hvis brugeren er under 50 år gammel skal programmet skrive: Du er for ung. */


            Console.WriteLine("Indtast din alder");

            // Læser brugerens input som tekst og fjerner evt. mellemrum i starten/slutningen
            string? input = Console.ReadLine()?.Trim();

            // Forsøger at konvertere input til et heltal (int)
            if (int.TryParse(input, out int alder))
            {
                if (alder > 60)
                {
                    // Hvis alderen er over 57, vis besked
                    Console.WriteLine("Du er for gammel.");
                }

                // '&&' betyder "og" – begge betingelser SKAL være sande for at dette sker
                else if (alder >= 50 && alder <= 60)
                {
                    Console.WriteLine("Du er hverken forgammel eller for ung. ");
                }

                else // ellers vis denne besked
                {
                    Console.WriteLine("Du er ikke for gammel.");
                }
            }
            else // Hvis konvertering fejler (brugeren skrev fx "hej")
            {
                Console.WriteLine("Ugyldigt input. Du skal skrive et tal.");
            }
        }

        public static void Opgave4()
        {
            /* 1. Lav et program hvor brugeren skal indtaste sit navn, brugernavn og et password.
             * 2. Erklær 3 variabler med navnene: navn, brugernavn og password. Du bestemmer selvværdierne.
             * 3. Hvis brugeren taster korrekt brugernavn og password skal programmet skrive:Velkommen + brugerens navn.
             * 4. Hvis brugeren taster forkert skal programmet skrive: brugernavn eller password er forkert. */

            Console.Write("Indtast dit navn: ");
            string? name = Console.ReadLine()?.Trim(); //Erklær variblenavn name

            Console.WriteLine("Burgernavn: ");
            string? userName = Console.ReadLine()?.Trim(); //Erklær variblenavn userName

            Console.WriteLine("Indtast Password: ");
            String? password = Console.ReadLine()?.Trim(); //Erklær variblenavn password

            // vi hardcoder brugernavn og password for at tilkomme opgaven. 
            string korrektBrugernavn = "admin";
            string korrektPassword = "1234";

            if (userName == korrektBrugernavn && password == korrektPassword)
            {
                Console.WriteLine("Velkommen " + name);
            }

            else // Hvis konvertering fejler (brugeren skrev fx "hej")
            {
                Console.WriteLine("Brugernavn eller password er forkert. Prøv igen");
            }
        }
        public static void Opgave5()
        {
            /* 1. Udvid opgave 4 så programmet først spørger brugeren om brugernavn.
             * 2. Hvis brugernavnet er forkert skal programmet skrive: brugernavnet er forkert.
             * 3. Hvis brugernavnet er korrekt skal programmet bede brugeren om password.
             * 4. Hvis ikke passwordet er korrekt skal programmet skrive: Passwordet er forkert.
             * 5. Hvis både brugernavn og password er korrekt skal programmet skrive: Velkommen + brugerens navn. */


            // Hardcoded korrekt login-oplysninger
            string korrektBrugernavn = "admin";
            string korrektPassword = "1234";

            // 1. Spørg om brugernavn
            Console.Write("Indtast brugernavn: ");
            string? userName = Console.ReadLine()?.Trim();

            // 2. Tjek brugernavn
            if (userName != korrektBrugernavn)
            {
                Console.WriteLine("Brugernavnet er forkert.");
            }
            else
            {
                // 3. Spørg om password (kun hvis brugernavnet er korrekt)
                Console.Write("Indtast password: ");
                string? password = Console.ReadLine()?.Trim();

                if (password != korrektPassword)
                {
                    // 4. Forkert password
                    Console.WriteLine("Passwordet er forkert.");
                }
                else
                {
                    // 5. Alt er korrekt → spørg om navn og vis velkomst
                    Console.Write("Indtast dit navn: ");
                    string? name = Console.ReadLine()?.Trim();

                    Console.WriteLine("Velkommen " + name);
                }
            }

            Console.WriteLine("\nTryk på en tast for at vende tilbage til menuen...");
            Console.ReadKey();
        }
        public static void Opgave6()
        {
            /* 1. Spørg brugeren hvor mange km der køres hver dag til og fra arbejde.
             * 2. Hvis brugeren kører 24 km eller mindre pr. dag gives der ikke noget fradrag og programmet skal skrive: Du får ikke noget fradrag.
             * 3. Hvis brugeren kører 25 - 120 km pr. dag gives der 1,93 kr. pr. km i fradrag og programmet skal så udregne hvor højt fradraget er 
             *    og udskrive dette. (Formel = (km pr. dag – 24) * 1,93)
             * 4. Hvis brugeren kører over 121 km pr. dag gives 0,97 kr. pr. km i fradrag
             *    og programmet skalså udregne hvor højt fradraget er og udskrive dette. 
             *    (Formel = 96 * 1,93 + (km pr. dag –120) * 0,97) */

            Console.WriteLine("Hvor mange km der køres hver dag til og fra arbejde? ");
            int antalKm = Convert.ToInt32(Console.ReadLine());

            double fradrag = (antalKm - 24) * 1.93;

            if (antalKm <= 24)
            {
                Console.WriteLine("Du får ikke noget fradrag.");
            }
            else if (antalKm >= 25 && antalKm <= 120) // antalKm 25 - 120
            {
                Console.WriteLine("Dit fradrag er: " + fradrag + " kr.");
            }
            else // antalKm > 120
            {
                double fradragOver120 = 96 * 1.93 + (antalKm - 120) * 0.97;
                Console.WriteLine("Dit fradrag er: " + fradragOver120 + " kr.");
            }

        }
        public static void Opgave7()
        {
            /* 1. If/elseProgrammet skal have titlen: Festen. Vi bruger Console.Title.
             *    Vi spørger brugeren om hvilken farve de foretrækker når de kan vælge mellem rød,grøn, blå og gul. 
             *    Spørg derefter om brugerens alder. Gem deres svar i en variabel. 
             *    Vi skal bruge 3 variabler. 2 strings hvoraf en skal konverteres til en int. 
             *    Derfor skal vi også erklære en int variabel.If yndlingsfarven er X. 
             *    Skal baggrundfarven sættes til X efterfulgt af Clear. 
             *    If personen er over 18 velkommen til cocktailbaren. 
             *    Else personen er under 18 og programmet skal skrive velkommen til sodavandsbaren. 
             *    Programmet skal lukke ned efter 10 sekunder. 2.Lav programmet ud fra pseudokoden. */


            // 1. Sæt titlen på konsolvinduet
            Console.Title = "Festen";

            // 2. Spørg brugeren om yndlingsfarve
            Console.Write("Hvilken farve foretrækker du? (rød, grøn, blå, gul): ");
            string? farve = Console.ReadLine()?.ToLower().Trim(); // Gemmes i string-variabel

            // 3. Sæt baggrundsfarve efter brugerens valg
            if (farve == "rød")
                Console.BackgroundColor = ConsoleColor.Red;
            else if (farve == "grøn")
                Console.BackgroundColor = ConsoleColor.Green;
            else if (farve == "blå")
                Console.BackgroundColor = ConsoleColor.Blue;
            else if (farve == "gul")
                Console.BackgroundColor = ConsoleColor.Yellow;
            else
                Console.BackgroundColor = ConsoleColor.Black; // fallback hvis farven ikke genkendes

            Console.Clear(); // Opdater konsollen med den nye baggrundsfarve

            // 4. Spørger om alder
            Console.Write("Hvor gammel er du? ");
            int alder = Convert.ToInt32(Console.ReadLine());
           
            // 5. If/else baseret på alder
            if (alder > 18)
                Console.WriteLine("Velkommen til cocktailbaren!");
            else
                Console.WriteLine("Velkommen til sodavandsbaren!");

            // 6. Vent 10 sekunder før programmet lukker
            Console.WriteLine("Programmet lukker om 10 sekunder...");
            System.Threading.Thread.Sleep(10000);
        }
        public static void Vis()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║                 C#                 ║");
            Console.WriteLine("║           If Else Staement         ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Opgave 1                       ║");
            Console.WriteLine("║  2  Opgave 2                       ║");
            Console.WriteLine("║  3  Opgave 3                       ║");
            Console.WriteLine("║  4  Opgave 4                       ║");
            Console.WriteLine("║  5. Opgave 5                       ║");
            Console.WriteLine("║  6. Opgave 6                       ║");
            Console.WriteLine("║  7. Opgave 7                       ║");
            Console.WriteLine("║  8. Vend tilbage til hovedmenuen   ║");
            Console.WriteLine("╚════════════════════════════════════╝");

            Console.Write("Vælg (1-7): ");

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
                    Console.WriteLine("Tilbage til hovedmenu...");
                    break;

                default:
                    Console.WriteLine("Ugyldigt valg.");
                    break;
            }
        }


    }
}

namespace CinemaMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Berätta för användaren att de har kommit till huvudmenyn och de kommer navigera
            // genom att skriva in siffror för att testa olika funktioner.

            // 2.Skapa skalet till en Switch-sats som till en början har Två Cases.Ett för ”0” som
            // stänger ner programmet och ett default som berättar att det är felaktig input.

            // 3.Skapa en oändlig iteration, alltså något som inte tar slut innan vi säger till att den
            // ska ta slut.Detta löser ni med att skapa en egen bool med tillhörande while-loop.

            // 4.Bygg ut menyn med val att exekvera de övriga övningarna.
                
            Boolean appRunning = true;

            do
            {
                Console.Clear();

                // Main menu
                Console.WriteLine("Welcome to the main menu\n");

                Console.WriteLine("Options:");
                Console.WriteLine(" 0)      Exit");
                Console.WriteLine(" 1)      ...");
                Console.WriteLine();

                Console.Write("Select option: ");
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine();
                        Console.WriteLine("Exiting the program...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            } while (appRunning);
        }
    }
}

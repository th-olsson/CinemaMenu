namespace CinemaMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean appRunning = true;
            do
            {
                Console.Clear();

                // Main menu
                Console.WriteLine("Välkommen till huvudmenyn\n");

                Console.WriteLine("Alternativ:");
                Console.WriteLine(" 0)      Avsluta program");
                Console.WriteLine(" 1)      Se ditt biljettpris");
                Console.WriteLine();

                Console.Write("Välj alternativ: ");
                switch (Console.ReadLine())
                {
                    case "0":
                        // Exit
                        Console.WriteLine();
                        Console.WriteLine("Avslutar programmet...");
                        Environment.Exit(0);
                        break;
                    case "1":
                        // Ticket price from age
                        Boolean validAge = false;
                        do
                        {
                            Console.Clear();
                            Console.Write("Ange din ålder: ");
                            var input = Console.ReadLine();
                            Console.WriteLine();
                            if (int.TryParse(input, out int age))
                            {
                                if (age < 0)
                                {
                                    Console.WriteLine("Ogiltig inmatning. Vänligen ange en giltig ålder.");
                                    Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    validAge = true;
                                    if (age < 20)
                                    {
                                        Console.WriteLine("Ungdomspris: 80kr");
                                    }
                                    else if (age > 64)
                                    {
                                        Console.WriteLine("Pensionärspris: 90kr");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Standardpris: 120kr");
                                    }
                                    Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ogiltig inmatning. Vänligen ange en giltig ålder.");
                                Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                                Console.ReadKey();
                            }
                        } while (!validAge);
                        Console.Clear();
                        Console.WriteLine("Ange din ålder:");
                        
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Ogiltig inmatning.");
                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                        Console.ReadKey();
                        break;
                }
            } while (appRunning);
        }
    }
}

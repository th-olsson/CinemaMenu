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
                Console.WriteLine(" 2)      Se biljettpris för en grupp");
                Console.WriteLine(" 3)      Upprepa din text 10 gånger");
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
                        {
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
                                        // Invalid age
                                        Console.WriteLine("Ogiltig inmatning. Vänligen ange en giltig ålder.");
                                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        // Valid age
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
                                    // Invalid input
                                    Console.WriteLine("Ogiltig inmatning. Vänligen ange en giltig ålder.");
                                    Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                                    Console.ReadKey();
                                }
                            } while (!validAge); // Repeat prompt until valid age
                            Console.Clear();
                            Console.WriteLine("Ange din ålder:");

                            break;
                        }
                    case "2":
                        {
                            // Ticket price for a group
                            Boolean validGroupSize = false;
                            do
                            {
                                Console.Clear();
                                Console.Write("Ange antal personer i gruppen: ");
                                var input = Console.ReadLine();
                                if (int.TryParse(input, out int groupSize))
                                {
                                    if (groupSize < 1)
                                    {
                                        // Invalid group size
                                        Console.WriteLine();
                                        Console.WriteLine("Ogiltig inmatning. Vänligen ange ett giltigt antal personer.");
                                        Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        // Valid group size -> calculate total price
                                        validGroupSize = true;
                                        int totalPrice = 0;
                                        for (int i = 1; i <= groupSize; i++)
                                        {
                                            Boolean validAge = false;
                                            do
                                            {
                                                Console.Write($"Ange ålder för person {i}: ");
                                                var ageInput = Console.ReadLine();
                                                if (int.TryParse(ageInput, out int age))
                                                {
                                                    if (age < 0)
                                                    {
                                                        // Invalid age
                                                        Console.WriteLine("Ogiltig inmatning. Vänligen ange en giltig ålder.");
                                                    }
                                                    else
                                                    {
                                                        // Valid age -> add to total price
                                                        validAge = true;
                                                        if (age < 20)
                                                        {
                                                            totalPrice += 80;
                                                        }
                                                        else if (age > 64)
                                                        {
                                                            totalPrice += 90;
                                                        }
                                                        else
                                                        {
                                                            totalPrice += 120;
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    // Invalid input
                                                    Console.WriteLine();
                                                    Console.WriteLine("Ogiltig inmatning. Vänligen ange en giltig ålder.");
                                                    Console.WriteLine();
                                                }
                                            } while (!validAge); // Repeat prompt until valid age
                                        }
                                        // Total price for the group
                                        Console.WriteLine($"Totalpris för gruppen: {totalPrice}kr\n");
                                        Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    // Invalid input
                                    Console.WriteLine();
                                    Console.WriteLine("Ogiltig inmatning. Vänligen ange ett giltigt antal personer.");
                                    Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                                    Console.ReadKey();
                                }
                            } while (!validGroupSize); // Repeat prompt until valid group size
                            break;
                        }
                    case "3":
                        {
                            // Repeat user text input 10 times
                            string userText = "";
                            do
                            {
                                Console.Clear();
                                Console.Write("Ange en text att upprepa 10 gånger: ");
                                userText = Console.ReadLine();

                                if (string.IsNullOrEmpty(userText))
                                {
                                    // Invalid input
                                    Console.WriteLine();
                                    Console.WriteLine("Ogiltig inmatning. Vänligen ange en giltig text.");
                                    Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    // Valid input -> repeat to user 10 times
                                    Console.WriteLine();
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {userText}");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("Tryck på valfri tangent för att återgå till huvudmenyn...");
                                    Console.ReadKey();
                                }
                            } while (string.IsNullOrEmpty(userText)); // Repeat prompt until valid input
                            break;
                        }
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

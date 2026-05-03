using System.Collections.Generic;
using System;

namespace CET2007_GameStats {
    class Program {
        static void Main(string[] args) {
            bool running = true;

            while (running) {
                Console.Clear();
                Console.WriteLine("=== Game Library & Player Stats Manager ===");
                Console.WriteLine("1. Add player");
                Console.WriteLine("2. View all players");
                Console.WriteLine("3. Update player stats");
                Console.WriteLine("4. Search player by ID");
                Console.WriteLine("5. Search player by username");
                Console.WriteLine("6. Show top scores");
                Console.WriteLine("7. Show most active players");
                Console.WriteLine("8. Save data");
                Console.WriteLine("9. Load data");
                Console.WriteLine("0. Exit");
                Console.Write("\nChoose an option: ");

                string? choice = Console.ReadLine();

                switch (choice) {
                    case "1":
                        Console.WriteLine("Add player selected.");
                        break;
                    case "2":
                        Console.WriteLine("View all players selected.");
                        break;
                    case "3":
                        Console.WriteLine("Update player stats selected.");
                        break;
                    case "4":
                        Console.WriteLine("Search by ID selected.");
                        break;
                    case "5":
                        Console.WriteLine("Search by username selected.");
                        break;
                    case "6":
                        Console.WriteLine("Top scores selected.");
                        break;
                    case "7":
                        Console.WriteLine("Most active players selected.");
                        break;
                    case "8":
                        Console.WriteLine("Save data selected.");
                        break;
                    case "9":
                        Console.WriteLine("Load data selected.");
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (running) {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
using System.Collections.Generic;
using System;

namespace CET2007_GameStats {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== Game Stats Manager ===");
            Console.WriteLine("1. Add player");
            Console.WriteLine("2. List players");
            Console.WriteLine("3. Exit");

            Console.Write("Choose an option: ");
            List<string> players = new List<string>();
            bool running = true;
            string choice = Console.ReadLine();

            if (choice == "1") {
                Console.Write("Enter player name: ");
                string name = Console.ReadLine();
                players.Add(name);
                Console.WriteLine("Player added");
            } else if (choice == "2") {
                Console.WriteLine("Players:");
                foreach (string p in players) {
                    Console.WriteLine(p);
                }
            } else {
                Console.WriteLine("Goodbye");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

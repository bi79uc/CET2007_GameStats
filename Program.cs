using CET2007_GameStats.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CET2007_GameStats {
    class Program {
        static List<Player> players = new List<Player>();
        static string filePath = "players.json";

        static void Main(string[] args) {
            LoadData();

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
                        AddPlayer();
                        break;
                    case "2":
                        ViewAllPlayers();
                        break;
                    case "3":
                        UpdatePlayerStats();
                        break;
                    case "4":
                        SearchPlayerById();
                        break;
                    case "5":
                        SearchPlayerByUsername();
                        break;
                    case "6":
                        ShowTopScores();
                        break;
                    case "7":
                        ShowMostActivePlayers();
                        break;
                    case "8":
                        SaveData();
                        Console.WriteLine("Data saved.");
                        break;
                    case "9":
                        LoadData();
                        Console.WriteLine("Data loaded.");
                        break;
                    case "0":
                        SaveData();
                        running = false;
                        Console.WriteLine("Data saved. Goodbye.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                if (running) {
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }
        }

        static void AddPlayer() {
            Console.Write("Enter player ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter username: ");
            string username = Console.ReadLine() ?? "";

            Console.Write("Enter hours played: ");
            double hoursPlayed = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter high score: ");
            int highScore = int.Parse(Console.ReadLine() ?? "0");

            Player player = new Player {
                Id = id,
                Username = username,
                HoursPlayed = hoursPlayed,
                HighScore = highScore
            };

            players.Add(player);
            SaveData();

            Console.WriteLine("Player added.");
        }

        static void ViewAllPlayers() {
            if (players.Count == 0) {
                Console.WriteLine("No players found.");
                return;
            }

            foreach (Player player in players) {
                DisplayPlayer(player);
            }
        }

        static void UpdatePlayerStats() {
            Console.Write("Enter player ID to update: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Player? player = players.Find(p => p.Id == id);

            if (player == null) {
                Console.WriteLine("Player not found.");
                return;
            }

            Console.Write("Enter new hours played: ");
            player.HoursPlayed = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter new high score: ");
            player.HighScore = int.Parse(Console.ReadLine() ?? "0");

            SaveData();

            Console.WriteLine("Player stats updated.");
        }

        static void SearchPlayerById() {
            Console.Write("Enter player ID: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Player? player = players.Find(p => p.Id == id);

            if (player == null) {
                Console.WriteLine("Player not found.");
                return;
            }

            DisplayPlayer(player);
        }

        static void SearchPlayerByUsername() {
            Console.Write("Enter username: ");
            string username = Console.ReadLine() ?? "";

            Player? player = players.Find(p => p.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (player == null) {
                Console.WriteLine("Player not found.");
                return;
            }

            DisplayPlayer(player);
        }

        static void ShowTopScores() {
            if (players.Count == 0) {
                Console.WriteLine("No players found.");
                return;
            }

            List<Player> sortedPlayers = new List<Player>(players);
            sortedPlayers.Sort((a, b) => b.HighScore.CompareTo(a.HighScore));

            Console.WriteLine("=== Top Scores ===");

            foreach (Player player in sortedPlayers) {
                DisplayPlayer(player);
            }
        }

        static void ShowMostActivePlayers() {
            if (players.Count == 0) {
                Console.WriteLine("No players found.");
                return;
            }

            List<Player> sortedPlayers = new List<Player>(players);
            sortedPlayers.Sort((a, b) => b.HoursPlayed.CompareTo(a.HoursPlayed));

            Console.WriteLine("=== Most Active Players ===");

            foreach (Player player in sortedPlayers) {
                DisplayPlayer(player);
            }
        }

        static void DisplayPlayer(Player player) {
            Console.WriteLine($"ID: {player.Id} | Username: {player.Username} | Hours: {player.HoursPlayed} | High Score: {player.HighScore}");
        }

        static void SaveData() {
            string json = JsonSerializer.Serialize(players, new JsonSerializerOptions {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
        }

        static void LoadData() {
            if (!File.Exists(filePath)) {
                players = new List<Player>();
                return;
            }

            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json)) {
                players = new List<Player>();
                return;
            }

            players = JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
        }
    }
}
using CET2007_GameStats.Models;
using System;
using System.Collections.Generic;

namespace CET2007_GameStats.Services {
    public class PlayerManager {
        private List<Player> players = new List<Player>();

        public List<Player> GetAllPlayers() {
            return players;
        }

        public void AddPlayer(Player player) {
            players.Add(player);
        }

        public Player? SearchById(int id) {
            return players.Find(p => p.Id == id);
        }

        public Player? SearchByUsername(string username) {
            return players.Find(p => p.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdateStats(int id, double hoursPlayed, int highScore) {
            Player? player = SearchById(id);

            if (player != null) {
                player.HoursPlayed = hoursPlayed;
                player.HighScore = highScore;
            }
        }

        public List<Player> GetTopScores() {
            List<Player> sortedPlayers = new List<Player>(players);
            sortedPlayers.Sort((a, b) => b.HighScore.CompareTo(a.HighScore));
            return sortedPlayers;
        }

        public List<Player> GetMostActivePlayers() {
            List<Player> sortedPlayers = new List<Player>(players);
            sortedPlayers.Sort((a, b) => b.HoursPlayed.CompareTo(a.HoursPlayed));
            return sortedPlayers;
        }
    }
}
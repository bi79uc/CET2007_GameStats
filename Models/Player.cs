namespace CET2007_GameStats.Models {
    public class Player {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public double HoursPlayed { get; set; }
        public int HighScore { get; set; }
    }
}
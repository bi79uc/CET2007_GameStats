using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET2007_GameStats.Models
{
    class Player
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public double HoursPlayed { get; set; }
        public int HighScore { get; set; }
    }
}

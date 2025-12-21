using CET2007_GameStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CET2007_GameStats.Data
{
    interface IPlayerRepository
    {
        // get all players
        List<Player> GetAll();
        // get player by id
        Player? GetById(int id);
        // get player by username
        Player? GetByUsername(string username);
        
        void Add(Player player);
        // update player's stats
        bool Update(Player player);
        // remove player by id
        bool Remove(int id);
        
        void Load();
        void Save();
    }
}

using CET2007_GameStats.Models;
using System.Collections.Generic;
using System.Numerics;

namespace CET2007_GameStats.Data {
    public interface IPlayerRepository {
        List<Player> GetAll();
        Player? GetById(int id);
        Player? GetByUsername(string username);
        void Add(Player player);
        void Update(Player player);
        void Remove(int id);
        void Load();
        void Save();
    }
}
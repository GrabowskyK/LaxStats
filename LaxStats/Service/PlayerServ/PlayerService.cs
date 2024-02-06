using LaxStats.Database;
using LaxStats.Models;
using Microsoft.EntityFrameworkCore;

namespace LaxStats.Service.PlayerServ
{
    public class PlayerService : IPlayerService
    {

        private readonly DatabaseContext databaseContext;
        public PlayerService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public void AddPlayer(Player player)
        {
            databaseContext.Add(player);
            databaseContext.SaveChanges();
        }

        public IEnumerable<Player> GetPlayers() => databaseContext.Players.Include(p => p.Team);

    }
}

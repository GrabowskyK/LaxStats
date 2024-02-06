using LaxStats.Models;

namespace LaxStats.Service.PlayerServ
{
    public interface IPlayerService
    {
        void AddPlayer(Player player);
        IEnumerable<Player> GetPlayers();
    }
}

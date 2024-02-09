using LaxStats.Models;

namespace LaxStats.Service.PlayerServ
{
    public interface IPlayerService
    {
        void AddPlayer(Player player);
        //IEnumerable<Player> GetPlayers();
        public IEnumerable<Player> GetPlayersFromTeam(int teamId);

        public void AddPlayersList(List<Player> players);
    }
}

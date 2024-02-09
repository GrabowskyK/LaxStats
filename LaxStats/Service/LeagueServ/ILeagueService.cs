using LaxStats.Models;

namespace LaxStats.Service.LeagueServ
{
    public interface ILeagueService
    {
        public void AddLeague(League league);
        public IEnumerable<League> GetLeagues(); // Get all leagues
        public IEnumerable<TeamsInLeague> GetTeamsFromLeague(int leagueId);
        public void AddTeamsToLeague(Team team, League league);
    }
}

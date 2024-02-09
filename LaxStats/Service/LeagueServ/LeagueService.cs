using LaxStats.Database;
using LaxStats.Models;
using Microsoft.EntityFrameworkCore;

namespace LaxStats.Service.LeagueServ
{
    public class LeagueService : ILeagueService
    {
        private readonly DatabaseContext databaseContext;

        public LeagueService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public void AddLeague(League league)
        {
            databaseContext.Leagues.Add(league);
            databaseContext.SaveChanges();
        }
        
        public IEnumerable<League> GetLeagues() => databaseContext.Leagues;
        public IEnumerable<TeamsInLeague> GetTeamsFromLeague(int leagueId) => databaseContext.TeamsInLeagues.Include(t => t.League).Include(t => t.Team).Where(t => t.LeagueId == leagueId);

        public void AddTeamsToLeague(Team team, League league)
        {
            TeamsInLeague teamInLeague = new TeamsInLeague(team, league);
            databaseContext.TeamsInLeagues.Add(teamInLeague);
            databaseContext.SaveChanges();
        }
    }
}

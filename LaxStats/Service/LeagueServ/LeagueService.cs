using LaxStats.Database;
using LaxStats.Models;

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

    }
}

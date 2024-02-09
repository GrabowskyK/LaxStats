using LaxStats.Database;
using LaxStats.Models;
using Microsoft.EntityFrameworkCore;

namespace LaxStats.Service.MatchServ
{
    public class MatchService : IMatchService
    {
        private readonly DatabaseContext databaseContext;
        public MatchService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }
        public void AddMatch(Match match)
        {
            databaseContext.Matches.Add(match);
            databaseContext.SaveChanges();
        }

        public IEnumerable<Match> GetMatches(int leagueId) => databaseContext.Matches
            .Include(m => m.AwayTeam)
            .Include(m => m.HomeTeam)
            .Include(m => m.League)
            .Where(m => m.LeagueId == leagueId);

        public Match GetSingleMatch(int matchId)
        {
            var singleMatch = databaseContext.Matches
            .Include(m => m.AwayTeam)
            .Include(m => m.HomeTeam)
            .Include(m => m.Goals)
            .Include(m => m.Penalty)
            .Where(m => m.Id == matchId)
            .FirstOrDefault();
            return singleMatch;
        }
   

    }
}

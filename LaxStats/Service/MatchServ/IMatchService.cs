using LaxStats.Models;

namespace LaxStats.Service.MatchServ
{
    public interface IMatchService
    {
        public void AddMatch(Match match);
        public IEnumerable<Match> GetMatches(int leagueId);
        public Match GetSingleMatch(int matchId);
    }
}

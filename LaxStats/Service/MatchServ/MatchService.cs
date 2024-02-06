using LaxStats.Database;
using LaxStats.Models;

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
    }
}

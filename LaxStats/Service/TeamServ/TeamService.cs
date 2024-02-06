using LaxStats.Database;
using LaxStats.Models;
using Microsoft.EntityFrameworkCore;

namespace LaxStats.Service.TeamServ
{
    public class TeamService : ITeamService
    {
        private readonly DatabaseContext databaseContext;

        public TeamService(DatabaseContext _databaseContext)
        {
            databaseContext = _databaseContext;
        }

        public void AddTeam(Team team)
        {
            databaseContext.Add(team);
            databaseContext.SaveChanges();
        }

        public IEnumerable<Team> GetTeams() => databaseContext.Teams;

    }
}
